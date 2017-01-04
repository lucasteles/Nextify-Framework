using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.App.Business
{
    public interface IFeriadoBusiness : IBusiness<DbFeriado>
    {

    }
    public class FeriadoBusiness : BaseBusiness<DbFeriado>, IFeriadoBusiness
    {
        ILocalizationUnitOfWork UserUnitOfWork;

        public FeriadoBusiness(ILocalizationUnitOfWork unitOfWork)
            : base(unitOfWork, null, null)
        {
            UserUnitOfWork = unitOfWork;
        }
    }
}
