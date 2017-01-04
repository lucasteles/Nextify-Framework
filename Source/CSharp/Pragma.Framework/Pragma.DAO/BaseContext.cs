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
    public abstract class BaseContext : DbContext, IContext
    {
        internal IList<Action<DbModelBuilder>> modelConfigurationActions = new List<Action<DbModelBuilder>>();
        internal IList<Type> modelConfiguration = new List<Type>();

        protected BaseContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DateTime GetServerDate()
        {
            var serverDate = ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DateTime>("CurrentDateTime()").AsEnumerable().First();

            return serverDate;
        }

        internal void AddConfiguration<TEntity>(EntityTypeConfiguration<TEntity> config) where TEntity : class
        {

            var t = typeof(TEntity);
            if (modelConfiguration.Contains(t))
                return;

            modelConfiguration.Add(t);
            modelConfigurationActions.Add(c =>
                c.Configurations.Add(config)
            );
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
