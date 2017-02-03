
using Pragma.Abstraction;
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Abstraction.Business
{
    public interface ISimpleBusiness<TEntity> : IDisposable where TEntity : class
    {
        bool SaveChildren { get; set; }

        Task<IOperationResult> ValidAsync(params TEntity[] entity);
        IOperationResult Valid(params TEntity[] entity);
        Task<IOperationResult> ValidDeleteAsync(params TEntity[] entity);
        IOperationResult ValidDelete(params TEntity[] entity);

        /// <summary>
        /// método destinado a encontrar todos os registros de uma tabela vinculada a uma Model.
        /// </summary>
        /// <returns>Implementação de IList com os registros encontrados.</returns>
        IEnumerable<TEntity> Get();
        Task<IEnumerable<TEntity>> GetAsync();

        IEnumerable<TView> Get<TView>();
        Task<IEnumerable<TView>> GetAsync<TView>();

        IEnumerable<TView> Get<TView>(Expression<Func<TView, bool>> predicate);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> predicate);

        IEnumerable<TView> Get<TView>(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

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
        /// método destinado a inativar uma coleção de registros.
        /// </summary>
        /// <param name="entity">Coleção de registros a deletar da base</param>
        IOperationResult Inative(params TEntity[] entity);

        /// <summary>
        /// método destinado a inativar uma coleção de registros.
        /// </summary>
        /// <param name="entity">Coleção de registros a deletar da base</param>
        Task<IOperationResult> InativeAsync(params TEntity[] entity);

        /// <summary>
        /// Retorna a contagem de elementos
        /// </summary>
        int Count();
        Task<int> CountAsync();

        int Count(Expression<Func<TEntity, bool>> where);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> where);

        Task<IEnumerable<TEntity>> GetAsync(int top);
        IEnumerable<TEntity> Get(int top);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, int top);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, int top);

        IEnumerable<TView> Get<TView>(int top);
        Task<IEnumerable<TView>> GetAsync<TView>(int top);
        IEnumerable<TView> Get<TView>(Expression<Func<TView, bool>> where, int top);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> where, int top);
        IEnumerable<TView> Get<TView>(Expression<Func<TEntity, bool>> where, int top);
        Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> where, int top);
        Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int top, Expression<Func<TEntity, bool>> where, params string[] value);

        Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int qtd, Expression<Func<TView, bool>> where, params string[] value);

    }
}
