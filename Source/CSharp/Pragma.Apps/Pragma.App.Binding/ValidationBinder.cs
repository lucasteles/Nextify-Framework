
using FluentValidation;
using Pragma.Abstraction.IOC;
using Pragma.App.Models;
using Pragma.App.Validations;

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
