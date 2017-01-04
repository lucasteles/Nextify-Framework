using System.Windows.Forms;

namespace Pragma.Forms.Controls.Abstraction
{
    public interface IControlWithValidation<TControl> where TControl : Control
    {
        IControlValidator<TControl> Validator { get; set; }

    }
}
