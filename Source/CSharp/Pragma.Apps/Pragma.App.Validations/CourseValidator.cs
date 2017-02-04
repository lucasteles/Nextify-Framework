﻿using FluentValidation;
using Pragma.App.Models;
using Pragma.Core;
using Pragma.Extensions;
using Pragma.Validations;

namespace Pragma.App.Validations
{
    public class CourseValidator : BaseValidator<Course>
    {

        public CourseValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .SetSeverity(FailureSeverity.Warning)
                .WithMessage(c => $"Campo { c.GetDisplayName(r => r.Name) } invalido");

            RuleFor(e => e.Name)
                .Length(0, 20)
                .SetSeverity(FailureSeverity.Warning)
                .WithMessage("Nome nao pode ter mais que 20 caracteres");

            RuleFor(e => e.Name)
                .Must(e => e != null && !e.ToUpper().Contains("PHP"))
                .SetSeverity(FailureSeverity.Warning)
                .WithMessage("Campo nome nao pode conter PHP");



        }

    }
}
