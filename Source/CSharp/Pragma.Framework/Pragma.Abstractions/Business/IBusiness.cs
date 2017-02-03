
using  Pragma.Abstraction;
using System.Threading.Tasks;

namespace Pragma.Abstraction.Business
{

    /// <summary>
    /// Abstração para a implementação dos métodos padrões do framework.
    /// </summary>
    /// <typeparam name="TEntity">Model (espelho da entidade da base de dados) para tipagem da abstração.</typeparam>
    public interface IBusiness<TEntity, TKey> : ISimpleBusiness<TEntity> where TEntity : class, IModelWithKey<TKey>
    {
        TEntity GetById(TKey id);

        Task<TEntity> GetAsync(TKey id);

        TEntity GetForEdit(TKey id);

        Task<TEntity> GetForEditAsync(TKey id);

    }

    public interface IBusiness<TEntity> : IBusiness<TEntity, int> where TEntity : class, IModelWithKey<int>
    {

    }
}