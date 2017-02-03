
using FluentValidation;
using Pragma.Abstraction.Business;
using Pragma.Abstraction.DAO;
using Pragma.Business.Abstraction;
using Pragma.DAO.Abstraction;

namespace Pragma.Business
{

    public class SimpleBusiness<TEntity> : AbstractBusiness<TEntity>, ISimpleBusiness<TEntity> where TEntity : class
    {

        public SimpleBusiness(IUnitOfWork UnitOfWork, IValidator<TEntity> validator, IValidator<TEntity> deleteValidator) : base(UnitOfWork, validator, deleteValidator)
        {
        }

    }

}
