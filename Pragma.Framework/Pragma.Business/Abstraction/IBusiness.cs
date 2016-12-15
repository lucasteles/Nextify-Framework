
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Business.Abstraction
{

    /// <summary>
    /// Abstração para a implementação dos métodos padrões do framework.
    /// </summary>
    /// <typeparam name="TEntity">Model (espelho da entidade da base de dados) para tipagem da abstração.</typeparam>
    public interface IBusiness<TEntity, TKey> : IDisposable where TEntity : class, IModelWithId<TKey> where TKey : struct
    {



        /// <summary>
        /// método destinado a encontrar todos os registros de uma tabela vinculada a uma Model.
        /// </summary>
        /// <returns>Implementação de IList com os registros encontrados.</returns>
        IQueryable<TEntity> Get();
        Task<IEnumerable<TEntity>> GetAsync();

        TEntity Get(TKey id);

        Task<TEntity> GetAsync(TKey id);


        TEntity GetForEdit(TKey id);

        Task<TEntity> GetForEditAsync(TKey id);



        IQueryable<TView> GetView<TView>();
        Task<IEnumerable<TView>> GetViewAsync<TView>();

        IQueryable<TView> FindView<TView>(Expression<Func<TView, bool>> predicate);
        Task<IEnumerable<TView>> FindViewAsync<TView>(Expression<Func<TView, bool>> predicate);

        IQueryable<TView> FindViewByModel<TView>(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TView>> FindViewByModelAsync<TView>(Expression<Func<TEntity, bool>> predicate);


        /// <summary>
        /// método  destinado a encontrar um unico registro de uma tabela vinculada a uma model. 
        /// </summary>
        /// <param name="predicate">Delegate contendo parâmetros para composição de WHERE</param>
        /// <returns>Objeto de classe modelo preenchido com registro encontrado</returns>
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);


        /// <summary>
        /// método de IBaseDAO destinado a encontrar um unico registro de uma tabela vinculada a uma model. 
        /// </summary>
        /// <param name="predicate">Delegate contendo parâmetros para composição de WHERE</param>
        /// <returns>Objeto de classe modelo preenchido com registro encontrado</returns>
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// método destinado a atualizar uma coleção de registros.
        /// </summary>
        /// <param name="entity">Coleção de registros a inserir na base</param>
        IOperationResult Add(params TEntity[] entity);

        Task<IOperationResult> AddAsync(params TEntity[] entity);


        bool IsModified(TEntity entity);

        bool IsNew(TEntity entity);

        IOperationResult Update(params TEntity[] entity);

        Task<IOperationResult> UpdateAsync(params TEntity[] entity);

        /// <summary>
        /// método destinado a excluir  uma coleção de registros.
        /// </summary>
        /// <param name="entity">Coleção de registros a deletar da base</param>
        IOperationResult Remove(params TEntity[] entity);

        Task<IOperationResult> RemoveAsync(params TEntity[] entity);

        /// <summary>
        /// Retorna a contagem de elementos
        /// </summary>
        int Count();
        Task<int> CountAsync();



        int Count(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);


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

    public interface IBusiness<TEntity> : IBusiness<TEntity, int> where TEntity : class, IModelWithId<int>
    {

    }
}