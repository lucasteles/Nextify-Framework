using FluentValidation;
using Nextify.Abstraction.Business;
using Nextify.App.DAO;
using Nextify.App.Models;
using Nextify.App.Validations;
using Nextify.Business;
using Nextify.Business.Abstraction;

namespace Nextify.App.Business
{
    public interface ICoursesBusiness : IBusiness<Course>
    {

    }

    public class CoursesBusiness : BaseBusiness<Course>, ICoursesBusiness
    {

        public CoursesBusiness(
                ICourseUnityOfWork unityOfWork,
                IValidator<Course> validator,
                ICourseDeleteValidator deleteValidator
            )
          : base(unityOfWork, validator, deleteValidator)
        {


        }
        

    }


}
