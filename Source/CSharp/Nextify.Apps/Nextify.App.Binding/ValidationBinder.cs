
using FluentValidation;
using Nextify.Abstraction.IOC;
using Nextify.App.Models;
using Nextify.App.Validations;

namespace Nextify.App.Binding
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
