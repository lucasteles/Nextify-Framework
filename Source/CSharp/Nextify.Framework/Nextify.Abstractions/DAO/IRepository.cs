using  Nextify.Abstraction;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nextify.Abstraction.DAO
{
    public interface IRepository<TEntity, TKey> : ISimpleRepository<TEntity> where TEntity : class, IModelWithKey<TKey>
    {

        TEntity GetById(TKey id);

        TEntity GetById(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties);

        Task<TEntity> GetByIdAsync(TKey id);

        Task<TEntity> GetByIdAsync(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties);

        TEntity GetForEdit(TKey id);

        Task<TEntity> GetForEditAsync(TKey id);

    }

    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IModelWithKey<int>
    {

    }

}