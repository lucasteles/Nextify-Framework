using Pragma.Abstraction;
using Pragma.Abstraction.DAO;
using Pragma.Core;
using Pragma.DAO.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Pragma.DAO
{
    [DbConfigurationType(typeof(EntityFrameworkConfiguration))]
    public abstract class BaseContext : DbContext, IContext
    {
        internal IList<Action<DbModelBuilder>> modelConfigurationActions = new List<Action<DbModelBuilder>>();
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
            Configuration.ProxyCreationEnabled = true;
            Database.CommandTimeout = int.MaxValue;


        }

        public DateTime GetServerDate()
        {
            var serverDate = ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DateTime>("CurrentDateTime()").AsEnumerable().First();

            return serverDate;
        }


        internal void LoadRepository<T>() where T : class, IEntityConfiguration<T>, new()
        {
            var repository = (T)Activator.CreateInstance(typeof(T), args: null);

            modelConfigurationActions.Add(c =>
                c.Configurations.Add(repository.GetConfiguration())
            );
        }   
        
          
        protected virtual void SetRepositories(DbModelBuilder modelBuilder)
        {
            var type = typeof(IEntityConfiguration<>);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

            foreach (var item in types)
            {
                var method = item.GetMethod(nameof(IEntityConfiguration<string>.GetConfiguration));
                var genericMethod = method.MakeGenericMethod(type);
                genericMethod.Invoke(null, null); 
            }

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            loaded = true;
            SetRepositories(modelBuilder);

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
