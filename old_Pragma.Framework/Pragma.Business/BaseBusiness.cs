
using FluentValidation;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Business
{

    public class BaseBusiness<TEntity, TKey> : IBusiness<TEntity, TKey> where TEntity : class, IModelWithId<TKey> where TKey : struct
    {
        protected readonly IUnityOfWork _unityOfWork;
        protected readonly IValidator<TEntity> _validator;
        protected readonly IValidator<TEntity> _deleteValidator;
        protected readonly IRepository<TEntity, TKey> _entityRepository;

        protected IList<IDisposable> ItensToDispose = new List<IDisposable>();

        public BaseBusiness(IUnityOfWork unityOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator)
        {
            Check.IfNull(() => unityOfWork);

            _unityOfWork = unityOfWork;
            _validator = validator;
            _deleteValidator = deleteValidator;
            _entityRepository = unityOfWork.TryGetRepositoryOfType<TEntity, TKey>();
            Check.IfNull(() => _entityRepository);

        }


        protected virtual IOperationResult _add(params TEntity[] entity)
        {
            var error = ValidEntity(_validator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            foreach (var item in entity)
                _entityRepository.Add(item);



            _unityOfWork.Complete(entity);

            return Ok();
        }

        public virtual IOperationResult Add(params TEntity[] entity)
        {
            return _add(entity);
        }


        protected async virtual Task<IOperationResult> _addAsync(params TEntity[] entity)
        {

            var error = await ValidEntityAsync(_validator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            foreach (var item in entity)
                _entityRepository.Add(item);



            await _unityOfWork.CompleteAsync(entity);

            return Ok();

        }

        public async virtual Task<IOperationResult> AddAsync(params TEntity[] entity)
        {
            return await _addAsync(entity);

        }


        protected virtual IOperationResult _update(params TEntity[] entity)
        {
            var error = ValidEntity(_validator, entity.ToArray());
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);


            _unityOfWork.CompleteAsync(entity);
            return Ok();
        }

        public IOperationResult Update(params TEntity[] entity)
        {
            return _update(entity);

        }

        protected async Task<IOperationResult> _updateAsync(params TEntity[] entity)
        {

            var error = await ValidEntityAsync(_validator, entity.ToArray());
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);



            await _unityOfWork.CompleteAsync(entity);

            return Ok();
        }

        public async Task<IOperationResult> UpdateAsync(params TEntity[] entity)
        {

            return await _updateAsync(entity);
        }




        public virtual IOperationResult Remove(params TEntity[] entity)
        {
            var error = ValidEntity(_deleteValidator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);


            foreach (IModelWithId<TKey> item in entity)
                _entityRepository.Remove(Get(item.Id));


            _unityOfWork.Complete();

            return Ok();

        }

        public virtual async Task<IOperationResult> RemoveAsync(params TEntity[] entity)
        {
            var error = await ValidEntityAsync(_deleteValidator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);


            foreach (IModelWithId<TKey> item in entity)
                _entityRepository.Remove(Get(item.Id));


            await _unityOfWork.CompleteAsync();

            return Ok();
        }


        public virtual int Count()
        {
            return _entityRepository.Count();
        }

        public virtual async Task<int> CountAsync()
        {
            return await _entityRepository.CountAsync();
        }


        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.Count(predicate);

        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.CountAsync(predicate);
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.Find(predicate);
        }




        public virtual TEntity Get(TKey id)
        {
            return _entityRepository.Get(id);
        }



        public virtual IQueryable<TEntity> Get()
        {
            return _entityRepository.Get();
        }



        public TEntity GetForEdit(TKey id)
        {
            return _entityRepository.GetForEdit(id);
        }

        public async Task<TEntity> GetForEditAsync(TKey id)
        {
            return await _entityRepository.GetForEditAsync(id);
        }


        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.SingleOrDefault(predicate);
        }


        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.SingleOrDefaultAsync(predicate);
        }

        protected virtual IList<IOperationResult> ValidEntity(IValidator<TEntity> validator, params TEntity[] entities)
        {
            if (validator == null)
                return new List<IOperationResult>() { Ok() };

            var errors = new List<IOperationResult>();
            foreach (var item in entities)
            {
                var valid = validator.Validate(item);
                errors.Add(valid.ToOperationResult());

            }
            return errors;
        }


        protected async virtual Task<IList<IOperationResult>> ValidEntityAsync(IValidator<TEntity> validator, params TEntity[] entities)
        {
            if (validator == null)
                return new List<IOperationResult>() { Ok() };

            var errors = new List<IOperationResult>();
            foreach (var item in entities)
            {
                var valid = await validator.ValidateAsync(item);
                errors.Add(valid.ToOperationResult());
            }
            return errors;
        }



        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _entityRepository.GetAsync();
        }


        public async Task<TEntity> GetAsync(TKey id)
        {
            return await _entityRepository.GetAsync(id);
        }


        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.FindAsync(predicate);
        }



        public IQueryable<TView> GetView<TView>()
        {
            return _entityRepository.GetView<TView>();
        }

        public async Task<IEnumerable<TView>> GetViewAsync<TView>()
        {
            return await _entityRepository.GetViewAsync<TView>();
        }


        public IQueryable<TView> FindView<TView>(Expression<Func<TView, bool>> predicate)
        {
            return _entityRepository.FindView(predicate);
        }

        public async Task<IEnumerable<TView>> FindViewAsync<TView>(Expression<Func<TView, bool>> predicate)
        {
            return await _entityRepository.FindViewAsync(predicate);
        }

        public IQueryable<TView> FindViewByModel<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.FindViewByModel<TView>(predicate);
        }

        public async Task<IEnumerable<TView>> FindViewByModelAsync<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return await FindViewByModelAsync<TView>(predicate);
        }


        public bool IsModified(TEntity entity)
        {
            return _entityRepository.IsModified(entity);
        }

        public bool IsNew(TEntity entity)
        {
            return _entityRepository.IsNew(entity);
        }

        protected IOperationResult Ok()
        {
            return new OperationResult() { Success = true, ErrorList = new List<IErrorMessage>() };
        }

        public async Task<IEnumerable<TEntity>> GetTopAsync(int qtdTop)
        {
            return await _entityRepository.GetTopAsync(qtdTop);
        }

        public IQueryable<TEntity> GetTop(int qtdTop)
        {
            return _entityRepository.GetTop(qtdTop);
        }

        public IQueryable<TEntity> FindTop(Expression<Func<TEntity, bool>> predicate, int qtdTop)
        {
            return _entityRepository.FindTop(predicate, qtdTop);
        }

        public async Task<IEnumerable<TEntity>> FindTopAsync(Expression<Func<TEntity, bool>> predicate, int qtdTop)
        {
            return await _entityRepository.FindTopAsync(predicate, qtdTop);
        }

        public IQueryable<TView> GetViewTop<TView>(int Qtd)
        {
            return _entityRepository.GetViewTop<TView>(Qtd);
        }

        public async Task<IEnumerable<TView>> GetViewTopAsync<TView>(int qtd)
        {
            return await _entityRepository.GetViewTopAsync<TView>(qtd);
        }

        public IQueryable<TView> FindViewTop<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return _entityRepository.FindViewTop<TView>(predicate, qtd);
        }

        public async Task<IEnumerable<TView>> FindViewTopAsync<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return await _entityRepository.FindViewTopAsync<TView>(predicate, qtd);
        }

        public IQueryable<TView> FindViewByModelTop<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return _entityRepository.FindViewByModelTop<TView>(predicate, qtd);
        }

        public async Task<IEnumerable<TView>> FindViewByModelTopAsync<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return await _entityRepository.FindViewByModelTopAsync<TView>(predicate, qtd);
        }


        protected virtual void RegisterDispose(IDisposable dispose)
        {
            ItensToDispose.Add(dispose);
        }

        public virtual void Dispose()
        {
            _unityOfWork?.Dispose();

            foreach (var item in ItensToDispose)
                item.Dispose();

        }
    }

    public class BaseBusiness<TEntity> : BaseBusiness<TEntity, int>, IBusiness<TEntity> where TEntity : class, IModelWithId<int>
    {
        public BaseBusiness(IUnityOfWork unityOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator)
           : base(unityOfWork, validator, deleteValidator)
        {

        }
    }
}
