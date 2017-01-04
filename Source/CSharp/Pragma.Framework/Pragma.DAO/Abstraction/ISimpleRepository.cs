using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.DAO.Abstraction
{
    public interface ISimpleRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> Table { get; set; }

        void Add(params TEntity[] entity);
        int Count();
        int Count(Expression<Func<TEntity, bool>> where);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> FindAllProperties(params string[] value);
        IQueryable<TEntity> FindAllProperties(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        IQueryable<TEntity> FindAllProperties(int top, params string[] value);
        IQueryable<TEntity> FindAllProperties(Expression<Func<TEntity, bool>> where, params string[] value);
        IQueryable<TEntity> FindAllProperties(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        IQueryable<TEntity> FindAllProperties(int top, Expression<Func<TEntity, bool>> where, params string[] value);
        IQueryable<TEntity> FindAllProperties(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        IQueryable<TEntity> FindAllProperties(int top, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Expression<Func<TEntity, bool>> where, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Expression<Func<TEntity, bool>> where, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where);
        IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where, int top);
        IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        IQueryable<TView> FindViewAllProperties<TView>(params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(int top, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(Expression<Func<TView, bool>> where, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(int top, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(int top, Expression<Func<TView, bool>> where, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        IQueryable<TView> FindViewAllProperties<TView>(int top, Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Expression<Func<TView, bool>> where, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Expression<Func<TView, bool>> where, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where, int top);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where);
        IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where, int top);
        IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where, int top);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(int top);
        IQueryable<TEntity> Get(params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        IQueryable<TEntity> Get(int top, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IQueryable<TEntity> Get(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IEnumerable<TEntity> GetAdded();
        Task<IEnumerable<TEntity>> GetAsync();
        Task<IEnumerable<TEntity>> GetAsync(params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(int top);
        Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        Task<IEnumerable<TEntity>> GetAsync(int top, params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        Task<IEnumerable<TEntity>> GetAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        IEnumerable<TEntity> GetChanges();
        IEnumerable<TEntity> GetRemoved();
        IQueryable<TView> Get<TView>();
        IQueryable<TView> Get<TView>(int top);
        IQueryable<TView> Get<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        Task<IEnumerable<TView>> GetAsync<TView>();
        Task<IEnumerable<TView>> GetAsync<TView>(int top);
        Task<IEnumerable<TView>> GetAsync<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        bool IsModified(TEntity entity);
        bool IsNew(TEntity entity);
        void Remove(params TEntity[] entity);
        void SetDefaultFields(TEntity entity);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include);
        TView SingleOrDefault<TView>(Expression<Func<TView, bool>> where);
        TView SingleOrDefault<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);
        Task<TView> SingleOrDefaultAsync<TView>(Expression<Func<TView, bool>> where);
        Task<TView> SingleOrDefaultAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order);

        TResult Max<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> maxSelector);
        TResult Min<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> minSelector);

        TResult Max<TResult>(Expression<Func<TEntity, TResult>> maxSelector);
        TResult Min<TResult>(Expression<Func<TEntity, TResult>> minSelector);


        Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> maxSelector);
        Task<TResult> MinAsync<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> minSelector);

        Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> maxSelector);
        Task<TResult> MinAsync<TResult>(Expression<Func<TEntity, TResult>> minSelector);


        long Sum(Expression<Func<TEntity, long>> selector);

        double Sum(Expression<Func<TEntity, double>> selector);

        float Sum(Expression<Func<TEntity, float>> selector);

        int Sum(Expression<Func<TEntity, int>> selector);

        decimal Sum(Expression<Func<TEntity, decimal>> selector);

        Task<long> SumAsync(Expression<Func<TEntity, long>> selector);

        Task<double> SumAsync(Expression<Func<TEntity, double>> selector);

        Task<float> SumAsync(Expression<Func<TEntity, float>> selector);

        Task<int> SumAsync(Expression<Func<TEntity, int>> selector);

        Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> selector);
        long Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long>> selector);

        double Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double>> selector);

        float Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float>> selector);

        int Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int>> selector);

        decimal Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal>> selector);

        Task<long> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long>> selector);

        Task<double> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double>> selector);

        Task<float> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float>> selector);

        Task<int> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int>> selector);

        Task<decimal> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal>> selector);




        long? Sum(Expression<Func<TEntity, long?>> selector);

        double? Sum(Expression<Func<TEntity, double?>> selector);

        float? Sum(Expression<Func<TEntity, float?>> selector);

        int? Sum(Expression<Func<TEntity, int?>> selector);

        decimal? Sum(Expression<Func<TEntity, decimal?>> selector);

        Task<long?> SumAsync(Expression<Func<TEntity, long?>> selector);

        Task<double?> SumAsync(Expression<Func<TEntity, double?>> selector);

        Task<float?> SumAsync(Expression<Func<TEntity, float?>> selector);

        Task<int?> SumAsync(Expression<Func<TEntity, int?>> selector);

        Task<decimal?> SumAsync(Expression<Func<TEntity, decimal?>> selector);
        long? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long?>> selector);

        double? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double?>> selector);

        float? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float?>> selector);

        int? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int?>> selector);

        decimal? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal?>> selector);

        Task<long?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long?>> selector);

        Task<double?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double?>> selector);

        Task<float?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float?>> selector);

        Task<int?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int?>> selector);

        Task<decimal?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal?>> selector);


    }
}