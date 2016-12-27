using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.DAO.Abstraction
{
    public interface IRepository<TEntity, TKey> : IRepository where TEntity : class, IModelWithId<TKey> where TKey : struct
    {
        DbSet<TEntity> Table { get; set; }

        TEntity Get(TKey id);

        Task<TEntity> GetAsync(TKey id);

        IQueryable<TEntity> Get();

        Task<IEnumerable<TEntity>> GetAsync();

        TEntity GetForEdit(TKey id);

        Task<TEntity> GetForEditAsync(TKey id);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);


        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        void Add(params TEntity[] entity);


        void Remove(params TEntity[] entity);


        int Count();

        Task<int> CountAsync();


        int Count(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetChanges();

        IEnumerable<TEntity> GetAdded();

        IEnumerable<TEntity> GetRemoved();

        bool IsModified(TEntity entity);

        bool IsNew(TEntity entity);

        IQueryable<TView> GetView<TView>();
        Task<IEnumerable<TView>> GetViewAsync<TView>();

        IQueryable<TView> FindView<TView>(Expression<Func<TView, bool>> predicate);
        Task<IEnumerable<TView>> FindViewAsync<TView>(Expression<Func<TView, bool>> predicate);

        IQueryable<TView> FindViewByModel<TView>(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TView>> FindViewByModelAsync<TView>(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetTopAsync(int qtdTop);
        IQueryable<TEntity> GetTop(int qtdTop);
        IQueryable<TEntity> FindTop(Expression<Func<TEntity, bool>> predicate, int qtdTop);
        Task<IEnumerable<TEntity>> FindTopAsync(Expression<Func<TEntity, bool>> predicate, int qtdTop);




        IQueryable<TView> GetViewTop<TView>(int Qtd);
        Task<IEnumerable<TView>> GetViewTopAsync<TView>(int qtd);
        IQueryable<TView> FindViewTop<TView>(Expression<Func<TView, bool>> predicate, int qtd);
        Task<IEnumerable<TView>> FindViewTopAsync<TView>(Expression<Func<TView, bool>> predicate, int qtd);
        IQueryable<TView> FindViewByModelTop<TView>(Expression<Func<TEntity, bool>> predicate, int qtd);
        Task<IEnumerable<TView>> FindViewByModelTopAsync<TView>(Expression<Func<TEntity, bool>> predicate, int qtd);


    }

    public interface IRepository
    {
        void SetContext(BaseContext context);
    }


    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IModelWithId<int>
    {

    }

}