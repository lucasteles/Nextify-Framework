
using FluentValidation;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.DAO.Abstraction;
using System.Threading.Tasks;

namespace Pragma.Business
{

    public class BaseBusiness<TEntity, TKey> : AbstractBusiness<TEntity>, IBusiness<TEntity, TKey> where TEntity : class, IModelWithKey<TKey>
    {

        protected readonly new IRepository<TEntity, TKey> _entityRepository;

        public BaseBusiness(IUnitOfWork UnitOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator) : base(UnitOfWork, validator, deleteValidator)
        {

            _entityRepository = UnitOfWork.TryGetRepositoryOfType<TEntity, TKey>();
        }

        public virtual TEntity GetById(TKey id)
        {
            return _entityRepository.GetById(id);
        }

        public virtual TEntity GetForEdit(TKey id)
        {
            return _entityRepository.GetForEdit(id);
        }

        public async Task<TEntity> GetForEditAsync(TKey id)
        {
            return await _entityRepository.GetForEditAsync(id);
        }

        public async Task<TEntity> GetAsync(TKey id)
        {
            return await _entityRepository.GetByIdAsync(id);
        }

    }

    public class BaseBusiness<TEntity> : BaseBusiness<TEntity, int>, IBusiness<TEntity> where TEntity : class, IModelWithKey<int>
    {
        public BaseBusiness(IUnitOfWork UnitOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator)
           : base(UnitOfWork, validator, deleteValidator)
        {

        }
    }
}
