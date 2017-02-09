using FluentValidation;
using Nextify.Abstraction.Business;
using Nextify.App.DAO;
using Nextify.App.Models;
using Nextify.App.Validations;
using Nextify.Business;
using Nextify.Business.Abstraction;

namespace Nextify.App.Business
{
    public interface IAuthorBusiness : IBusiness<Author>
    {

    }

    public class AuthorBusiness : BaseBusiness<Author>, IAuthorBusiness
    {

        public AuthorBusiness(
                ICourseUnityOfWork unityOfWork
            )
          : base(unityOfWork, null, null)
        {


        }
        

    }


}
