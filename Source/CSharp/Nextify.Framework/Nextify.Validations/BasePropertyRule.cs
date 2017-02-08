using FluentValidation;
using FluentValidation.Internal;
using FluentValidation.Results;
using Nextify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Nextify.Validations
{

    public class BasePropertyRule<T> : PropertyRule, IValidationRule
    {
        public BasePropertyRule(MemberInfo member, Func<object, object> propertyFunc, LambdaExpression expression, Func<CascadeMode> cascadeModeThunk, Type typeToValidate, Type containerType) : base(member, propertyFunc, expression, cascadeModeThunk, typeToValidate, containerType)
        {
        }

        public new static BasePropertyRule<TModel> Create<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, Func<CascadeMode> cascadeModeThunk)
        {
            var member = expression.GetMember();
            // We can't use the expression tree as a key in the cache, as it doesn't implement GetHashCode/Equals in a useful way.
            // Instead we'll use the MemberInfo as the key, but this only works for member expressions.
            // If this is not a member expression (eg, a RuleFor(x => x) or a RuleFor(x => x.Foo())) then we won't cache the result. 
            // We could probably make the cache more robust in future. 

            //var compiled = member == null ? expression.Compile() : AccessorCache<T>.GetCachedAccessor(member, expression);
            var compiled = expression.Compile();
            return new BasePropertyRule<TModel>(member, compiled.CoerceToNonGeneric(), expression, cascadeModeThunk, typeof(TProperty), typeof(TModel));
        }

        IEnumerable<ValidationFailure> IValidationRule.Validate(ValidationContext context)
        {

            //Criar resultados customizados contente control destino e severidade
            var errors = base.Validate(context).Select(i => new BaseValidationFailure(i, Severity)).ToList();
            //return
            return errors;
        }

        async Task<IEnumerable<ValidationFailure>> IValidationRule.ValidateAsync(ValidationContext context, CancellationToken cancellation)
        {
            var errors = await ValidateAsync(context, cancellation);

            return errors.Select(i => new BaseValidationFailure(i, Severity)).ToList();

        }

        public FailureSeverity Severity { get; set; } = FailureSeverity.Warning;

    }
}
