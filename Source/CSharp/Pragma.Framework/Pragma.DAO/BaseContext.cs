using Pragma.Abstraction;
using Pragma.Abstraction.DAO;
using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Extensions;
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
    public  class BaseContext : DbContext, IContext
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


        public void LoadRepository<T,TEntity>() where T :  IEntityConfiguration<TEntity> where TEntity :class
        {
            var repository = (T)Activator.CreateInstance(typeof(T), args: this);

            modelConfigurationActions.Add(c =>
                c.Configurations.Add(repository.GetConfiguration())
            );
        }   
        
          
        protected virtual void SetRepositories(DbModelBuilder modelBuilder)
        {
            var type = typeof(IEntityConfiguration<>);
            var types = AppDomain.CurrentDomain.GetAssemblies()
             .SelectMany(s => {
                  try
                  {
                      return s.GetTypes();
                  }
                  catch
                  {
                      return new Type[] { };
                  }

              })
              .Where(e=>e.Name.ToLower().Contains("repository") && !e.IsInterface
                    && e != (typeof(BaseRepository<>))
                    && e != (typeof(BaseRepository<,>))
                    && e != (typeof(SimpleRepository<>))

              )

                .Where(p => p.IsAssignableToGenericType(type))
                .ToList();


            

            foreach (var item in types)
            {

                MethodInfo method = GetType().GetMethod(nameof(LoadRepository));
                var entityType = item.GetInterfaces().Where(e=>e.IsAssignableToGenericType(type)).FirstOrDefault().GetGenericArguments().FirstOrDefault();
                MethodInfo genericMethod = method.MakeGenericMethod(item, entityType);
                genericMethod.Invoke(this, null);

               
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
