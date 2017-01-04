
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pragma.DAO.Abstraction

{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<T, TKey> TryGetRepositoryOfType<T, TKey>() where T : class, IModelWithKey<TKey>;

        ISimpleRepository<T> TryGetRepositoryOfType<T>() where T : class;

        IContext GetContext();

        IEnumerable<IOperationResult> GetValidationErrors();

        int Complete();

        Task<int> CompleteAsync();

        int Complete(params object[] entity);

        Task<int> CompleteAsync(params object[] entity);

        void SetObjectState(object item, ModelState state);

    }
}