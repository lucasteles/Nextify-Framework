
using Pragma.Core;
using System;
using System.Threading.Tasks;

namespace Pragma.DAO.Abstraction

{
    public interface IUnityOfWork : IDisposable
    {


        IRepository<T, TKey> TryGetRepositoryOfType<T, TKey>() where T : class, IModelWithId<TKey> where TKey : struct;

        int Complete();

        Task<int> CompleteAsync();



        int Complete(params object[] entity);

        Task<int> CompleteAsync(params object[] entity);




    }
}