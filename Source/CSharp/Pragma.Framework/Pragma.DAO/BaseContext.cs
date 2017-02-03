using Pragma.Core;
using Pragma.DAO.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Pragma.DAO
{
    [DbConfigurationType(typeof(EntityFrameworkConfiguration))]
    public abstract class BaseContext : DbContext, IContext
    {
        internal IList<Action<DbModelBuilder>> modelConfigurationActions = new List<Action<DbModelBuilder>>();
        internal IList<Type> modelConfiguration = new List<Type>();
        protected bool loaded;
        protected BaseContext(string connectionString) : base(connectionString)
        {
        }

        protected BaseContext(System.Data.Common.DbConnection connection, bool destroyAfterUse)
            : base(connection, destroyAfterUse)
        {
            Setup();
        }

        protected BaseContext() : base()
        {
            Setup();
        }


        protected void Setup()
        {
            Database.SetInitializer<BaseContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.CommandTimeout = 99999;


        }

        public DateTime GetServerDate()
        {
            var serverDate = ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DateTime>("CurrentDateTime()").AsEnumerable().First();

            return serverDate;
        }

        public void AddConfiguration<TEntity>(EntityTypeConfiguration<TEntity> config) where TEntity : class
        {

            var t = typeof(TEntity);
            if (modelConfiguration.Contains(t) || loaded)
                return;

            modelConfiguration.Add(t);
            modelConfigurationActions.Add(c =>
                c.Configurations.Add(config)
            );
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            loaded = true;
            foreach (var item in modelConfigurationActions)
                item(modelBuilder);
        }

        IEnumerable<IOperationResult> IContext.GetValidationErrors()
        {
            return GetValidationErrors().Select(e =>
                                new OperationResult
                                {
                                    Success = e.IsValid,
                                    ErrorList = e.ValidationErrors.Select(i =>
                                                new ErrorMessage
                                                {
                                                    Message = i.ErrorMessage,
                                                    Severity = FailureSeverity.Warning,
                                                    Property = i.PropertyName,
                                                    Value = e.Entry
                                                }).Cast<IErrorMessage>().ToList()
                                });
        }
    }



}
