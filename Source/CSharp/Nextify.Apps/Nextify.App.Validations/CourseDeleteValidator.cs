using FluentValidation;
using Nextify.App.Models;
using Nextify.Core;
using Nextify.Validations;

namespace Nextify.App.Validations
{
    public interface ICourseDeleteValidator : IValidator<Course>
    {

    }


    public class CourseDeleteValidator : BaseValidator<Course>, ICourseDeleteValidator
    {

        public CourseDeleteValidator()
        {
            RuleFor(e => e.Level)
                .LessThan(10)
                .SetSeverity(FailureSeverity.Warning)
                .WithMessage("Nao pode excluir cursos com nivel maior que 9");

        }

    }
}
