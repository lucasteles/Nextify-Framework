using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Pragma.DAO
{
    public abstract class UnityOfWork : IUnityOfWork, IDisposable
    {
        protected readonly BaseContext _context;
        private bool disposed = false;


        private IDictionary<object, EntityState> DetachedItems;

        public UnityOfWork(BaseContext context)
        {
            _context = context;



        }

        ~UnityOfWork()
        {
            Dispose();
        }




        protected void Set<T>(T input, Expression<Func<T>> outExpr) where T : class, IRepository
        {

            var expr = (MemberExpression)outExpr.Body;
            var prop = (PropertyInfo)expr.Member;
            prop.SetValue(this, input, null);
            input.SetContext(_context);

        }



        public int Complete(params object[] entities)
        {
            Detach(entities);
            var result = Complete();
            Retach();

            return result;
        }


        public async Task<int> CompleteAsync(params object[] entities)
        {
            Detach(entities);
            var result = await CompleteAsync();
            Retach();

            return result;
        }

        public int Complete()
        {

            return _context.SaveChanges();
        }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }



        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                _context.Dispose();

            }

        }

        public IRepository<T, TKey> TryGetRepositoryOfType<T, TKey>() where T : class, IModelWithId<TKey> where TKey : struct
        {
            var props = GetType().GetProperties();
            IRepository<T, TKey> result = null;

            foreach (var item in props)
                if (item.PropertyType.MyIsAssignableFrom<IRepository<T, TKey>>())
                {
                    return item.GetValue(this) as IRepository<T, TKey>;
                }


            return result;
        }




        private void Detach(params object[] entities)
        {

            var xxx = _context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Modified || x.State == EntityState.Added));


            if (entities == null || entities.Count() == 0)
                return;

            var changes = _context.ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Modified || x.State == EntityState.Added)
                            && !entities.Contains(x.Entity)
                        )
                        .ToDictionary(e => e.Entity, e => e.State);





            DetachedItems = changes;
            foreach (var item in changes)
                _context.Entry(item.Key).State = EntityState.Detached;

        }


        private void Retach()
        {

            if (DetachedItems == null)
                return;

            foreach (var item in DetachedItems)
                _context.Entry(item.Key).State = item.Value;

            DetachedItems = null;

        }

    }
}