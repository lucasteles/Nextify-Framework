﻿using FluentValidation;
using Nextify.Abstraction;
using Nextify.Abstraction.Business;
using Nextify.Abstraction.DAO;
using Nextify.Core;
using Nextify.DAO.Abstraction;
using Nextify.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nextify.Business.Abstraction

{
    public abstract class AbstractBusiness<TEntity> : Business, ISimpleBusiness<TEntity> where TEntity : class
    {
        protected IValidator<TEntity> _deleteValidator;
        protected ISimpleRepository<TEntity> _entityRepository;
        protected IUnitOfWork _UnitOfWork;
        protected IValidator<TEntity> _validator;
        protected IList<IDisposable> ItensToDispose = new List<IDisposable>();

        private bool _forceUpdate;
        public bool ForceUpdate {
            get { return _forceUpdate; }
            set {
                _forceUpdate = value;

                if (_entityRepository != null)
                    _entityRepository.ForceUpdate = _forceUpdate;
            }
        }

        protected AbstractBusiness(IUnitOfWork UnitOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator)
        {
            Check.IfNull(() => UnitOfWork);

            _UnitOfWork = UnitOfWork;
            _validator = validator;
            _deleteValidator = deleteValidator;
            _entityRepository = UnitOfWork.TryGetRepositoryOfType<TEntity>();
            _entityRepository.ForceUpdate = ForceUpdate;
            Check.IfNull(() => _entityRepository);

        }

        public bool SaveChildren { get; set; } = true;


        public virtual IOperationResult Add(params TEntity[] entity)
        {
            return _add(entity);
        }
        public async virtual Task<IOperationResult> AddAsync(params TEntity[] entity)
        {
            return await _addAsync(entity);

        }
        public virtual int Count()
        {
            return _entityRepository.Count();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.Count(predicate);

        }

        public virtual async Task<int> CountAsync()
        {
            return await _entityRepository.CountAsync();
        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.CountAsync(predicate);
        }

        public virtual void Dispose()
        {
            _UnitOfWork?.Dispose();

            foreach (var item in ItensToDispose)
                item.Dispose();

        }
        public virtual async Task<IEnumerable<TEntity>> FindAllPropertiesAsync(int qtd, Expression<Func<TEntity, bool>> predicate, params string[] value)
        {
            return await _entityRepository.FindAllPropertiesAsync(
                            top: qtd,
                            where: predicate,
                            value: value
                    );
        }
        public virtual async Task<IEnumerable<TView>> FindViewAllPropertiesAsync<TView>(int qtd, Expression<Func<TView, bool>> predicate, params string[] value)
        {
            return await _entityRepository.FindViewAllPropertiesAsync(
                          top: qtd,
                          where: predicate,
                          value: value
                  );
        }

        public virtual IEnumerable<TView> Get<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return _entityRepository.Get<TView>(predicate, qtd).ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.Get(predicate).ToList();
        }

        public virtual IEnumerable<TEntity> Get()
        {

            return _entityRepository.Get().ToList();
        }

        public virtual IEnumerable<TView> Get<TView>()
        {
            return _entityRepository.Get<TView>().ToList();
        }

        public virtual IEnumerable<TView> Get<TView>(Expression<Func<TView, bool>> predicate)
        {
            return _entityRepository.Get(predicate).ToList();
        }

        public virtual IEnumerable<TView> Get<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.Get<TView>(predicate).ToList();
        }

        public virtual IEnumerable<TEntity> Get(int top)
        {
            return _entityRepository.Get(top).ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, int top)
        {
            return _entityRepository.Get(predicate, top).ToList();
        }

        public virtual IEnumerable<TView> Get<TView>(int top)
        {
            return _entityRepository.Get<TView>(top).ToList();
        }

        public virtual IEnumerable<TView> Get<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return _entityRepository.Get<TView>(predicate, qtd).ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _entityRepository.GetAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.GetAsync(predicate);
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>()
        {
            return await _entityRepository.GetAsync<TView>();
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> predicate)
        {
            return await _entityRepository.GetAsync(predicate);
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAsync<TView>(predicate);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(int top)
        {
            return await _entityRepository.GetAsync(top);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, int top)
        {
            return await _entityRepository.GetAsync(predicate, top);
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>(int qtd)
        {
            return await _entityRepository.GetAsync<TView>(qtd);
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TView, bool>> predicate, int qtd)
        {
            return await _entityRepository.GetAsync<TView>(predicate, qtd);
        }

        public virtual async Task<IEnumerable<TView>> GetAsync<TView>(Expression<Func<TEntity, bool>> predicate, int qtd)
        {
            return await _entityRepository.GetAsync<TView>(predicate, qtd);
        }
        public virtual IOperationResult Inative(params TEntity[] entity)
        {

            foreach (var item in entity)
                if (item is IBase)
                    ((IBase)item).Inative = !((IBase)item).Inative;
                else
                    throw new Exception("Model cant be casted to IBase");

            _UnitOfWork.Complete(entity);
            return Ok();
        }

        public virtual async Task<IOperationResult> InativeAsync(params TEntity[] entity)
        {
            foreach (var item in entity)
                if (item is IBase)
                    ((IBase)item).Inative = !((IBase)item).Inative;
                else
                    throw new Exception("Model cant be casted to IBase");

            await _UnitOfWork.CompleteAsync(entity);

            return Ok();
        }

        public virtual bool IsModified(TEntity entity)
        {
            return _entityRepository.IsModified(entity);
        }

        public virtual bool IsNew(TEntity entity)
        {
            return _entityRepository.IsNew(entity);
        }
        public virtual IOperationResult Remove(params TEntity[] entity)
        {

            var result = ValidDelete(entity);
            if (!result.Success)
                return result;

            foreach (var item in entity)
                _entityRepository.Remove(item);

            _UnitOfWork.Complete();

            return Ok();

        }

        public virtual async Task<IOperationResult> RemoveAsync(params TEntity[] entity)
        {

            var result = await ValidDeleteAsync(entity);
            if (!result.Success)
                return result;

            foreach (var item in entity)
                _entityRepository.Remove(item);

            await _UnitOfWork.CompleteAsync();

            return Ok();
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entityRepository.SingleOrDefault(predicate);
        }

        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entityRepository.SingleOrDefaultAsync(predicate);
        }

        public virtual IOperationResult Update(params TEntity[] entity)
        {
            return _update(entity);

        }

        public virtual async Task<IOperationResult> UpdateAsync(params TEntity[] entity)
        {

            return await _updateAsync(entity);
        }

        public virtual IOperationResult Valid(params TEntity[] entity)
        {
            var error = _validEntity(_validator, entity.ToArray());
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            return Ok();
        }
        public virtual async Task<IOperationResult> ValidAsync(params TEntity[] entity)
        {
            var error = await _validEntityAsync(_validator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            return Ok();
        }

        public virtual IOperationResult ValidDelete(params TEntity[] entity)
        {
            var error = _validEntity(_deleteValidator, entity.ToArray());
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            return Ok();
        }
        public virtual async Task<IOperationResult> ValidDeleteAsync(params TEntity[] entity)
        {
            var error = await _validEntityAsync(_deleteValidator, entity);
            if (error.Any(e => !e.Success))
                return error.FirstOrDefault(e => !e.Success);

            return Ok();
        }


    
        protected virtual IOperationResult _add(params TEntity[] entity)
        {
            var result = Valid(entity);
            if (!result.Success)
                return result;
            foreach (var item in entity)
                _entityRepository.Add(item);

            Save(entity);

            return Ok();
        }

        protected async virtual Task<IOperationResult> _addAsync(params TEntity[] entity)
        {
            var result = await ValidAsync(entity);
            if (!result.Success)
                return result;
            foreach (var item in entity)
                _entityRepository.Add(item);

            await SaveAsync(entity);

            return Ok();

        }

        protected virtual IOperationResult _update(params TEntity[] entity)
        {

            var result = Valid(entity);
            if (!result.Success)
                return result;

            Save(entity);
            return Ok();
        }

        protected virtual async Task<IOperationResult> _updateAsync(params TEntity[] entity)
        {

            var result = await ValidAsync(entity);
            if (!result.Success)
                return result;

            await SaveAsync(entity);

            return Ok();
        }

        protected virtual IList<IOperationResult> _validEntity(IValidator<TEntity> validator, params TEntity[] entities)
        {
            if (validator == null)
                return new List<IOperationResult> { Ok() };

            var errors = new List<IOperationResult>();
            foreach (var item in entities)
            {
                var valid = validator.Validate(item);
                errors.Add(valid.ToOperationResult());

            }
            return errors;
        }

        protected async virtual Task<IList<IOperationResult>> _validEntityAsync(IValidator<TEntity> validator, params TEntity[] entities)
        {
            if (validator == null)
                return new List<IOperationResult> { Ok() };

            var errors = new List<IOperationResult>();
            foreach (var item in entities)
            {
                var valid = await validator.ValidateAsync(item);
                errors.Add(valid.ToOperationResult());
            }
            return errors;
        }

        protected virtual void RegisterDispose(IDisposable dispose)
        {
            ItensToDispose.Add(dispose);
        }

        protected virtual void Save(params TEntity[] entity)
        {

            if (SaveChildren)
                _UnitOfWork.Complete();
            else
                _UnitOfWork.Complete(entity);
        }

        protected virtual async Task SaveAsync(params TEntity[] entity)
        {

            if (SaveChildren)
                await _UnitOfWork.CompleteAsync();
            else
                await _UnitOfWork.CompleteAsync(entity);

        }
    }
}
