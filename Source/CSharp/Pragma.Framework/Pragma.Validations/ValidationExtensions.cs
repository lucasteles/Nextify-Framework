
using FluentValidation;
using FluentValidation.Resources;
using Pragma.Core;
using System;
using System.Linq;

namespace Pragma.Validations
{
    public static class ValidationExtensions
    {
        public static IOperationResult ToOperationResult(this FluentValidation.Results.ValidationResult resut)
        {
            return new OperationResult()
            {
                Success = resut.IsValid || resut.Errors.All(e => ((BaseValidationFailure)e).Severity == FailureSeverity.Info),
                ErrorList = resut.Errors.Select(e => (IErrorMessage)new ErrorMessage()
                {
                    Code = e.ErrorCode,
                    Message = e.ErrorMessage,
                    Property = e.PropertyName,
                    Value = e.AttemptedValue,
                    Severity = ((BaseValidationFailure)e).Severity

                }).ToList()
            };

        }

        public static IRuleBuilderOptions<T, TProperty> WithMessage<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, params Func<T, object>[] funcs)
        {
            return rule.Configure(config =>
            {
                config.CurrentValidator.ErrorMessageSource = new StaticStringSource(string.Join("", funcs.Select((_, i) => $"{{{i}}}").ToArray()));

                funcs
                    .Select(func => new Func<object, object, object>((instance, value) => func((T)instance))).ToList()
                    .ForEach(config.CurrentValidator.CustomMessageFormatArguments.Add);
            });
        }

        /// <summary>
        /// Atribui uma severidade à regra
        /// </summary>
        /// <typeparam name="T">Tipo sendo validado.</typeparam>
        /// <typeparam name="TProperty">Propriedade sendo validada.</typeparam>
        /// <param name="rule">Regra atual.</param>
        /// <param name="severity">Severidade da regra.</param>
        /// <returns>A regra editada.</returns>
        public static IRuleBuilderOptions<T, TProperty> SetSeverity<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, FailureSeverity severity)
        {
            return rule.Configure(config =>
            {
                ((BasePropertyRule<T>)config).Severity = severity;
            });
        }

    }
}

