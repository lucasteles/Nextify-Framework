
using Nextify.Abstraction;
using Nextify.Abstraction.DAO;
using Nextify.Core;
using Nextify.DAO.Abstraction;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nextify.DAO
{
    public class BaseRepository<TEntity, TKey> : SimpleRepository<TEntity>, IRepository<TEntity, TKey> where TEntity : class, IModelWithKey<TKey>
    {
        public BaseRepository(IContext context) : base(context)
        {
        }
        public virtual TEntity GetById(TKey id)
        {
            var idEquals = KeyedModelHelper<TEntity, TKey>.IdEquals(id);
            return Table.FirstOrDefault(idEquals);
        }

        public virtual TEntity GetById(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            var idEquals = KeyedModelHelper<TEntity, TKey>.IdEquals(id);

            var query = PrepareNavigations(navigationProperties);

            return query.FirstOrDefault(idEquals);
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            var idEquals = KeyedModelHelper<TEntity, TKey>.IdEquals(id);

            return await Table.FirstOrDefaultAsync(idEquals);
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            var idEquals = KeyedModelHelper<TEntity, TKey>.IdEquals(id);
            var query = PrepareNavigations(navigationProperties);
            return await query.FirstOrDefaultAsync(idEquals);
        }

        public virtual TEntity GetForEdit(TKey id)
        {
            return GetById(id, EditNavigationProperties.ToArray());
        }

        public virtual async Task<TEntity> GetForEditAsync(TKey id)
        {
            return await GetByIdAsync(id, EditNavigationProperties.ToArray());
        }

    }

    public class BaseRepository<TEntity> : BaseRepository<TEntity, int>, IRepository<TEntity> where TEntity : class, IModelWithKey<int>
    {
        public BaseRepository(IContext context) : base(context)
        {
        }
    }

}