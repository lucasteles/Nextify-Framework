
using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Extensions;
using Pragma.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.DAO
{
    public class SimpleRepository<TEntity> : ISimpleRepository<TEntity> where TEntity : class
    {

        #region propriedades

        protected BaseContext Context;
        public DbSet<TEntity> Table { get; set; }

        protected IList<Expression<Func<TEntity, object>>> EditNavigationProperties { get; set; } = new List<Expression<Func<TEntity, object>>>();

        protected IDbConnection db { get { return Context.Database.Connection; } }

        #endregion

        #region Construtor
        public SimpleRepository(IContext context)
        {

            SetContext(context);

        }
        #endregion

        #region "Meotodos base busca"

        // Gets
        public virtual IQueryable<TEntity> Get() => Table;

        public async Task<IEnumerable<TEntity>> GetAsync() => await Get().ToListAsync();

        public IQueryable<TEntity> Get(params Expression<Func<TEntity, object>>[] include)
            => PrepareNavigations(Table, include);

        public async Task<IEnumerable<TEntity>> GetAsync(params Expression<Func<TEntity, object>>[] include)
            => await PrepareNavigations(Table, include).ToListAsync();
        public IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order) => PrepareOrder(Get(), order);
        public IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
         => PrepareOrder(Get(include), order);
        public async Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order) => await Get(order).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => await Get(order, include).ToListAsync();
        public virtual IQueryable<TEntity> Get(int top) => Get().TakeIfNotZero(top);

        public IQueryable<TEntity> Get(int top, params Expression<Func<TEntity, object>>[] include) => Get(include).TakeIfNotZero(top);
        public virtual IQueryable<TEntity> Get(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order) => Get(order).TakeIfNotZero(top);

        public IQueryable<TEntity> Get(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => Get(order, include).TakeIfNotZero(top);
        public virtual async Task<IEnumerable<TEntity>> GetAsync(int top)
            => await Get(top).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(int top, params Expression<Func<TEntity, object>>[] include)
            => await Get(top, include).ToListAsync();
        public virtual async Task<IEnumerable<TEntity>> GetAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
            => await Get(top, order).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => await Get(top, order, include).ToListAsync();
        //Finds
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where)
            => Get().WhereIfNotNull(where);

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include)
            => PrepareNavigations(Get(where), include);
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
            => PrepareOrder(Get(where), order);

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => PrepareNavigations(Get(where, order), include);
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where)
            => await Get(where).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include)
            => await Get(where, include).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
         => await Get(where, order).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => await Find(where, order, include).ToListAsync();
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top)
            => Get(where).TakeIfNotZero(top);
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, params Expression<Func<TEntity, object>>[] include)
             => Get(where, include).TakeIfNotZero(top);
        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
            => Get(where, order).TakeIfNotZero(top);
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
             => Find(where, order, include).TakeIfNotZero(top);
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top)
            => await Get(where).TakeIfNotZero(top).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, params Expression<Func<TEntity, object>>[] include)
            => await Get(where, top, include).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
            => await Get(where, top, order).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => await Get(where, top, order, include).ToListAsync();
        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where)
            => Get().SingleOrDefault(where);
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include)
            => PrepareNavigations(null, include).SingleOrDefault(where);
        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
            => PrepareOrder(Get(), order).SingleOrDefault(where);
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => PrepareNavigations(PrepareOrder(Get(), order), include).SingleOrDefault(where);
        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where)
            => await Get().SingleOrDefaultAsync(where);

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] include)
            => await PrepareNavigations(null, include).SingleOrDefaultAsync(where);
        public async virtual Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order)
          => await PrepareOrder(Get(), order).SingleOrDefaultAsync(where);
        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params Expression<Func<TEntity, object>>[] include)
            => await PrepareNavigations(PrepareOrder(Get(), order), include).SingleOrDefaultAsync(where);
        #region findAllProperties
        public IQueryable<TEntity> FindAllProperties(params string[] value) => Get().WhereAllPropertiesContains(value);
        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(params string[] value) => await FindAllProperties(value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(params string[] value) => Get<TView>().WhereAllPropertiesContains(value);
        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(params string[] value) => await FindViewAllProperties<TView>(value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(int top, params string[] value) => FindAllProperties(value).TakeIfNotZero(top);
        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, params string[] value) => await FindAllProperties(top, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(int top, params string[] value) => FindViewAllProperties<TView>(value).TakeIfNotZero(top);
        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, params string[] value) => await FindViewAllProperties<TView>(top, value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(Expression<Func<TEntity, bool>> where, params string[] value)
            => FindAllProperties(value).WhereIfNotNull(where);

        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Expression<Func<TEntity, bool>> where, params string[] value)
            => await FindAllProperties(where, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(Expression<Func<TView, bool>> where, params string[] value)
            => FindViewAllProperties<TView>(value).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Expression<Func<TView, bool>> where, params string[] value)
            => await FindViewAllProperties(where, value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(int top, Expression<Func<TEntity, bool>> where, params string[] value)
             => FindAllProperties(top, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Expression<Func<TEntity, bool>> where, params string[] value)
            => await FindAllProperties(top, where, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(int top, Expression<Func<TView, bool>> where, params string[] value)
              => FindViewAllProperties<TView>(top, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Expression<Func<TView, bool>> where, params string[] value)
              => await FindViewAllProperties<TView>(top, where, value).ToListAsync();

        public IQueryable<TEntity> FindAllProperties(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => Get(order).WhereAllPropertiesContains(value);
        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => await FindAllProperties(order, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => Get<TView>(order).WhereAllPropertiesContains(value);
        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => await FindViewAllProperties<TView>(order, value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => FindAllProperties(order, value).TakeIfNotZero(top);
        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => await FindAllProperties(top, order, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(int top, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => FindViewAllProperties<TView>(order, value).TakeIfNotZero(top);
        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => await FindViewAllProperties<TView>(top, order, value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => FindAllProperties(order, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => await FindAllProperties(where, order, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => FindViewAllProperties<TView>(order, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => await FindViewAllProperties(where, order, value).ToListAsync();
        public IQueryable<TEntity> FindAllProperties(int top, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => FindAllProperties(top, order, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order, params string[] value) => await FindAllProperties(top, where, order, value).ToListAsync();
        public IQueryable<TView> FindViewAllProperties<TView>(int top, Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => FindViewAllProperties<TView>(top, order, value).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int top, Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order, params string[] value) => await FindViewAllProperties<TView>(top, where, order, value).ToListAsync();
        #endregion
        // calculus

        public virtual int Count() => Table.Count();
        public virtual async Task<int> CountAsync() => await Table.CountAsync();
        public virtual int Count(Expression<Func<TEntity, bool>> where) => Table.Count(where);
        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> where) => await Table.CountAsync(where);


        public TResult Max<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> maxSelector) => Table.Where(where).Max(maxSelector);


        public TResult Min<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> minSelector) => Table.Where(where).Min(minSelector);

        public TResult Max<TResult>(Expression<Func<TEntity, TResult>> maxSelector) => Table.Max(maxSelector);
        public TResult Min<TResult>(Expression<Func<TEntity, TResult>> minSelector) => Table.Min(minSelector);

        public async Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> maxSelector) => await Table.Where(where).MaxAsync(maxSelector);


        public async Task<TResult> MinAsync<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> minSelector) => await Table.Where(where).MinAsync(minSelector);

        public async Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> maxSelector) => await Table.MaxAsync(maxSelector);

        public async Task<TResult> MinAsync<TResult>(Expression<Func<TEntity, TResult>> minSelector) => await Table.MinAsync(minSelector);


        public long Sum(Expression<Func<TEntity, long>> selector) => Table.Sum(selector);
        public double Sum(Expression<Func<TEntity, double>> selector) => Table.Sum(selector);
        public float Sum(Expression<Func<TEntity, float>> selector) => Table.Sum(selector);
        public int Sum(Expression<Func<TEntity, int>> selector) => Table.Sum(selector);
        public decimal Sum(Expression<Func<TEntity, decimal>> selector) => Table.Sum(selector);
        public async Task<long> SumAsync(Expression<Func<TEntity, long>> selector) => await Table.SumAsync(selector);
        public async Task<double> SumAsync(Expression<Func<TEntity, double>> selector) => await Table.SumAsync(selector);
        public async Task<float> SumAsync(Expression<Func<TEntity, float>> selector) => await Table.SumAsync(selector);
        public async Task<int> SumAsync(Expression<Func<TEntity, int>> selector) => await Table.SumAsync(selector);
        public async Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> selector) => await Table.SumAsync(selector);
        public long Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long>> selector) => Table.Where(where).Sum(selector);
        public double Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double>> selector) => Table.Where(where).Sum(selector);
        public float Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float>> selector) => Table.Where(where).Sum(selector);
        public int Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int>> selector) => Table.Where(where).Sum(selector);
        public decimal Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal>> selector) => Table.Where(where).Sum(selector);
        public async Task<long> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<double> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<float> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<int> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<decimal> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal>> selector) => await Table.Where(where).SumAsync(selector);



        public long? Sum(Expression<Func<TEntity, long?>> selector) => Table.Sum(selector);
        public double? Sum(Expression<Func<TEntity, double?>> selector) => Table.Sum(selector);
        public float? Sum(Expression<Func<TEntity, float?>> selector) => Table.Sum(selector);
        public int? Sum(Expression<Func<TEntity, int?>> selector) => Table.Sum(selector);
        public decimal? Sum(Expression<Func<TEntity, decimal?>> selector) => Table.Sum(selector);
        public async Task<long?> SumAsync(Expression<Func<TEntity, long?>> selector) => await Table.SumAsync(selector);
        public async Task<double?> SumAsync(Expression<Func<TEntity, double?>> selector) => await Table.SumAsync(selector);
        public async Task<float?> SumAsync(Expression<Func<TEntity, float?>> selector) => await Table.SumAsync(selector);
        public async Task<int?> SumAsync(Expression<Func<TEntity, int?>> selector) => await Table.SumAsync(selector);
        public async Task<decimal?> SumAsync(Expression<Func<TEntity, decimal?>> selector) => await Table.SumAsync(selector);
        public long? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long?>> selector) => Table.Where(where).Sum(selector);
        public double? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double?>> selector) => Table.Where(where).Sum(selector);
        public float? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float?>> selector) => Table.Where(where).Sum(selector);
        public int? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int?>> selector) => Table.Where(where).Sum(selector);
        public decimal? Sum(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal?>> selector) => Table.Where(where).Sum(selector);
        public async Task<long?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, long?>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<double?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, double?>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<float?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, float?>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<int?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, int?>> selector) => await Table.Where(where).SumAsync(selector);
        public async Task<decimal?> SumAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, decimal?>> selector) => await Table.Where(where).SumAsync(selector);

        #endregion

        #region "Metodos de persistencia"
        public virtual void Add(params TEntity[] entity)
        {

            if (entity.Count() == 1)
                Table.Add(entity.FirstOrDefault());
            else
                Table.AddRange(entity as IEnumerable<TEntity>);
        }

        public virtual void Remove(params TEntity[] entity)
        {
            if (entity.Count() == 1)
                Table.Remove(entity.FirstOrDefault());
            else
                Table.RemoveRange(entity as IEnumerable<TEntity>);
        }

        #endregion

        #region "Metodos de viewmodel"
        public IQueryable<TView> Get<TView>() => Get().MapTo<TView>();

        public async Task<IEnumerable<TView>> GetAsync<TView>()
            => await Get<TView>().ToListAsync();

        public IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where)
            => Get<TView>().WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where)
            => await Get(where).ToListAsync();

        public IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where)
            => Get(where).MapTo<TView>();

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where)
            => await Get<TView>(where).ToListAsync();
        public TView SingleOrDefault<TView>(Expression<Func<TView, bool>> where)
             => Get<TView>().SingleOrDefault(where);

        public async Task<TView> SingleOrDefaultAsync<TView>(Expression<Func<TView, bool>> where)
            => await Get<TView>().SingleOrDefaultAsync(where);
        public IQueryable<TView> Get<TView>(int top) => Get(top).MapTo<TView>();

        public async Task<IEnumerable<TView>> GetAsync<TView>(int top)
            => await Get(top).MapTo<TView>().ToListAsync();
        public IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where, int top)
            => Get<TView>(top).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where, int top)
            => await Get(where, top).ToListAsync();

        public IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where, int top)
            => Get(where, top).MapTo<TView>();

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where, int top)
            => await Get<TView>(where, top).ToListAsync();
        public IQueryable<TView> Get<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order) => PrepareOrder(Get().MapTo<TView>(), order);

        public async Task<IEnumerable<TView>> GetAsync<TView>(Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => await Get(order).ToListAsync();

        public IQueryable<TView> Get<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => Get(order).WhereIfNotNull(where);

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => await Get(where, order).ToListAsync();

        public IQueryable<TView> Get<TView>(Expression<Func<TEntity, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => PrepareOrder(Get(where).MapTo<TView>(), order);

        public async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => await Get<TView>(where, order).ToListAsync();
        public TView SingleOrDefault<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
             => Get<TView>(order).SingleOrDefault(where);

        public async Task<TView> SingleOrDefaultAsync<TView>(Expression<Func<TView, bool>> where, Func<IQueryable<TView>, IOrderedQueryable<TView>> order)
            => await Get<TView>(order).SingleOrDefaultAsync(where);

        #endregion

        #region  "Metodos de estado de entidades"

        public bool IsModified(TEntity entity)
            => Context.Entry(entity).State == EntityState.Modified;

        public bool IsNew(TEntity entity)
                => Context.Entry(entity).State == EntityState.Added;

        public IEnumerable<TEntity> GetChanges() =>
                Context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Modified) && x.Entity is TEntity)
                        .Select(x => x.Entity as TEntity).ToList();

        public IEnumerable<TEntity> GetAdded() =>
                Context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Added) && x.Entity is TEntity)
                        .Select(x => x.Entity as TEntity).ToList();

        public IEnumerable<TEntity> GetRemoved() =>
             Context.ChangeTracker.Entries()
                 .Where(x => (x.State == EntityState.Deleted) && x.Entity is TEntity)
                     .Select(x => x.Entity as TEntity).ToList();

        #endregion

        #region "Metodos auxiliares"

        protected void IncludeForEdit(params Expression<Func<TEntity, object>>[] navigationProperties)
            => EditNavigationProperties = navigationProperties;
        protected IQueryable<TEntity> PrepareNavigations(params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            return PrepareNavigations(null, navigationProperties);
        }

        protected IQueryable<TEntity> PrepareNavigations(IQueryable<TEntity> baseQuery = null, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            var query = baseQuery ?? Get();
            foreach (var item in navigationProperties)
                query = query.Include(item) ?? query;

            return query;
        }
        private static IQueryable<TModel> PrepareOrder<TModel>(IQueryable<TModel> query, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> order)
        {
            return order?.Invoke(query) ?? query;
        }
        private void SetContext(IContext context)
        {
            Context = context as BaseContext;

            var config = new EntityTypeConfiguration<TEntity>();
            OnModelConfiguration(config);
            Context.AddConfiguration(config);

            Table = Context.Set<TEntity>();

        }

#pragma warning disable CC0057 // Unused parameters
        protected virtual void OnModelConfiguration(EntityTypeConfiguration<TEntity> modelConfig)
#pragma warning restore CC0057 // Unused parameters
        {

        }

        public void SetDefaultFields(TEntity entity)
        {
            if (entity is IBase)
            {
                var baseEntity = entity as IBase;

                var changed = false;
                if (Context.Entry(baseEntity).State == EntityState.Added || (!baseEntity.DhInclusao.HasValue))
                {
                    baseEntity.DhInclusao = DateTime.Now;
                    changed = true;
                }

                if (Context.Entry(baseEntity).State == EntityState.Modified)
                {
                    baseEntity.DhAlteracao = DateTime.Now;
                    changed = true;
                }

                if (changed && UserData.UserID.HasValue)
                {
                    baseEntity.Owner = UserData.UserID;
                }

            }

        }




        #endregion

    }

}