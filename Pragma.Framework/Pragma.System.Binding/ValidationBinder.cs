using FluentValidation;
using Pragma.App.Models;
using Pragma.App.Validations;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class ValidationBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<IValidator<Course>, CourseValidator>();
            container.Register<ICourseDeleteValidator, CourseDeleteValidator>();


        }
    }
}
