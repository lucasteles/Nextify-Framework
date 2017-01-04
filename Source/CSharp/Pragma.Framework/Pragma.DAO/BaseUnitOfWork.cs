using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Pragma.DAO
{
    public abstract class BaseUnitOfWork : IUnitOfWork, IDisposable
    {
        public BaseContext _context { get; }

        private bool disposed;

        private IDictionary<object, EntityState> DetachedItems;

        protected BaseUnitOfWork(IContext context)
        {
            _context = context as BaseContext;

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

            GC.SuppressFinalize(this);
        }

        public IRepository<T, TKey> TryGetRepositoryOfType<T, TKey>() where T : class, IModelWithKey<TKey>
        {
            var props = GetType().GetProperties();
            foreach (var item in props)
                if (item.PropertyType.IsGenericTypeAssignableFrom<IRepository<T, TKey>>())
                {
                    return item.GetValue(this) as IRepository<T, TKey>;
                }

            return null;
        }

        public ISimpleRepository<T> TryGetRepositoryOfType<T>() where T : class
        {

            var props = GetType().GetProperties();
            foreach (var item in props)
                if (item.PropertyType.IsGenericTypeAssignableFrom<ISimpleRepository<T>>())
                    return item.GetValue(this) as ISimpleRepository<T>;

            return null;

        }

        private void Detach(params object[] entities)
        {

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

        public IEnumerable<IOperationResult> GetValidationErrors()
        {
            return GetContext().GetValidationErrors();
        }

        public IContext GetContext()
        {
            return _context;
        }

        public void SetObjectState(object item, ModelState state)
        {
            _context.Entry(item).State = (EntityState)state;
        }
    }
}