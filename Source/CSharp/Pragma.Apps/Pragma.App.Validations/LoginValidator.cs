using FluentValidation;
using Pragma.App.Model;

namespace Pragma.App.Validations
{
    public class LoginValidator : AbstractValidator<DbUsuarioLogin>, IValidator<DbUsuarioLogin>
    {
        public LoginValidator() : base()
        {
        }
    }
}
