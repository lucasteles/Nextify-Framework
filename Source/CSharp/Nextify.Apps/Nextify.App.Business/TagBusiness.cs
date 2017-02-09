using FluentValidation;
using Nextify.Abstraction.Business;
using Nextify.App.DAO;
using Nextify.App.Models;
using Nextify.App.Validations;
using Nextify.Business;
using Nextify.Business.Abstraction;

namespace Nextify.App.Business
{
    public interface ITagBusiness : IBusiness<Tag>
    {

    }

    public class TagBusiness : BaseBusiness<Tag>, ITagBusiness
    {

        public TagBusiness(
                ICourseUnityOfWork unityOfWork
            )
          : base(unityOfWork, null, null)
        {


        }
        

    }


}
