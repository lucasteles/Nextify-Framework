using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Pragma.DAO
{
    public abstract class BaseContext : DbContext
    {
        internal IList<Action<DbModelBuilder>> modelConfigurationActions = new List<Action<DbModelBuilder>>();
        internal IList<Type> modelConfiguration = new List<Type>();

        public BaseContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
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
    }
}
