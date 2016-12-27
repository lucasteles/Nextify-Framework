
using Pragma.Core;
using Pragma.DAO.Abstraction;
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
    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IModelWithId<TKey> where TKey : struct
    {
        protected BaseContext Context;
        public DbSet<TEntity> Table { get; set; }

        protected IList<Expression<Func<TEntity, object>>> NavigationProperties { get; set; }

        protected IDbConnection db { get { return Context.Database.Connection; } }

        public BaseRepository()
        {
        }

        protected void IncludeForEdit(params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            NavigationProperties = navigationProperties;

        }


        protected IQueryable<TEntity> PrepareNavigations(params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            IQueryable<TEntity> query = Table;
            foreach (var item in navigationProperties)
                query = query.Include(item) ?? query;

            return query;
        }


        public bool IsModified(TEntity entity)
                => Context.Entry(entity).State == EntityState.Modified;


        public bool IsNew(TEntity entity)
                => Context.Entry(entity).State == EntityState.Added;



        public virtual void SetContext(BaseContext context)
        {
            Context = context;

            var config = new EntityTypeConfiguration<TEntity>();
            OnModelConfiguration(config);
            context.AddConfiguration(config);

            Table = context.Set<TEntity>();

        }

        public virtual TEntity Get(TKey id)
        {
            return _get(id);
        }

        public virtual TEntity _get(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            var idEquals = KeyedBaseModel<TEntity, TKey>.IdEquals(id);

            var query = PrepareNavigations(navigationProperties);

            return query.FirstOrDefault(idEquals);
        }


        public virtual async Task<TEntity> GetAsync(TKey id)
        {
            return await _getAsync(id);
        }

        public virtual async Task<TEntity> _getAsync(TKey id, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            var idEquals = KeyedBaseModel<TEntity, TKey>.IdEquals(id);
            var query = PrepareNavigations(navigationProperties);
            return await query.FirstOrDefaultAsync(idEquals);
        }


        public virtual IQueryable<TEntity> Get()
        {
            return Table;
        }


        public virtual async Task<IEnumerable<TEntity>> GetTopAsync(int qtdTop)
        {
            return await Get().Take(qtdTop).ToListAsync();
        }

        public virtual IQueryable<TEntity> GetTop(int qtdTop)
        {
            return Get().Take(qtdTop);
        }

        public virtual IQueryable<TEntity> FindTop(Expression<Func<TEntity, bool>> predicate, int qtdTop)
        {
            return Table.Take(qtdTop).Where(predicate);
        }


        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.Where(predicate);
        }


        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Find(predicate).ToListAsync();
        }


        public async Task<IEnumerable<TEntity>> FindTopAsync(Expression<Func<TEntity, bool>> predicate, int qtdTop)
        {
            return await Find(predicate).Take(qtdTop).ToListAsync();
        }



        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.SingleOrDefault(predicate);
        }

        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.SingleOrDefaultAsync(predicate);
        }

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



        public virtual int Count()
        {
            return Table.Count();
        }

        public virtual async Task<int> CountAsync()
        {
            return await Table.CountAsync();
        }


        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.Count(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.CountAsync(predicate);
        }



        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await Get().ToListAsync();
        }


        protected virtual void OnModelConfiguration(EntityTypeConfiguration<TEntity> modelConfig)
        {

        }




        public IQueryable<TView> GetView<TView>()
        {
            return Get().MapTo<TView>();
        }

        public async Task<IEnumerable<TView>> GetViewAsync<TView>()
        {
            return await Get().MapTo<TView>().ToListAsync();
        }

        public IQueryable<TView> FindView<TView>(Expression<Func<TView, bool>> predicate)
        {
            return GetView<TView>().Where(predicate);
        }

        public async Task<IEnumerable<TView>> FindViewAsync<TView>(Expression<Func<TView, bool>> predicate)
        {
            return await FindView(predicate).ToListAsync();
        }

        public IQueryable<TView> FindViewByModel<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return Find(predicate).MapTo<TView>();
        }

        public async Task<IEnumerable<TView>> FindViewByModelAsync<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return await FindViewByModel<TView>(predicate).ToListAsync();
        }



        public IQueryable<TView> GetViewTop<TView>(int Qtd)
        {
            return GetTop(Qtd).MapTo<TView>();
        }

        public async Task<IEnumerable<TView>> GetViewTopAsync<TView>(int qtd)
        {
            return await GetTop(qtd).MapTo<TView>().ToListAsync();
        }

        public IQueryable<TView> FindViewTop<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return GetViewTop<TView>(qtd).Where(predicate);
        }

        public async Task<IEnumerable<TView>> FindViewTopAsync<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return await FindViewTop(predicate, qtd).ToListAsync();
        }

        public IQueryable<TView> FindViewByModelTop<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return FindTop(predicate, qtd).MapTo<TView>();
        }

        public async Task<IEnumerable<TView>> FindViewByModelTopAsync<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return await FindViewByModelTop<TView>(predicate, qtd).ToListAsync();
        }





        public IEnumerable<TEntity> GetChanges()
        {
            return
                Context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Modified) && x.Entity is TEntity)
                        .Select(x => x.Entity as TEntity).ToList();
        }


        public IEnumerable<TEntity> GetAdded()
        {
            return
                Context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Added) && x.Entity is TEntity)
                        .Select(x => x.Entity as TEntity).ToList();
        }


        public IEnumerable<TEntity> GetRemoved()
        {
            return
             Context.ChangeTracker.Entries()
                 .Where(x => (x.State == EntityState.Deleted) && x.Entity is TEntity)
                     .Select(x => x.Entity as TEntity).ToList();
        }




        public virtual TEntity GetForEdit(TKey id)
        {
            return _get(id, NavigationProperties.ToArray());
        }

        public virtual async Task<TEntity> GetForEditAsync(TKey id)
        {
            return await _getAsync(id, NavigationProperties.ToArray());
        }
    }


    public class BaseRepository<TEntity> : BaseRepository<TEntity, int>, IRepository<TEntity> where TEntity : class, IModelWithId<int>
    {

    }





}
