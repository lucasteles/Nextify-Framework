using FluentValidation;
using Pragma.Abstraction.Business;
using Pragma.App.DAO;
using Pragma.App.Models;
using Pragma.App.Validations;
using Pragma.Business;
using Pragma.Business.Abstraction;

namespace Pragma.App.Business
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
