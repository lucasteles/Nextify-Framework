
using FluentValidation;
using Nextify.Abstraction.Business;
using Nextify.Abstraction.DAO;
using Nextify.Business.Abstraction;
using Nextify.DAO.Abstraction;

namespace Nextify.Business
{

    public class SimpleBusiness<TEntity> : AbstractBusiness<TEntity>, ISimpleBusiness<TEntity> where TEntity : class
    {

        public SimpleBusiness(IUnitOfWork UnitOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator) : base(UnitOfWork, validator, deleteValidator)
        {
        }

    }

}
