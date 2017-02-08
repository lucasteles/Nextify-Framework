using FluentValidation;
using FluentValidation.Internal;
using Nextify.Abstraction.Forms.Controls;
using System;
using System.Linq.Expressions;

namespace Nextify.Validations
{
    public class BaseValidator<T> : AbstractValidator<T>, IBaseValidator<T>
    {
        public new IRuleBuilderInitial<T, TProperty> RuleFor<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var rule = BasePropertyRule<T>.Create(expression, () => CascadeMode);
            AddRule(rule);
            var ruleBuilder = new RuleBuilder<T, TProperty>(rule);
            return ruleBuilder;
        }
    }
}
