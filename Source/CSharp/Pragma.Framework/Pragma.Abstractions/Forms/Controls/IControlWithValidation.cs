using System.Windows.Forms;

namespace Pragma.Abstraction.Forms.Controls
{
    public interface IControlWithValidation<TControl> where TControl : Control
    {
        IControlValidator<TControl> Validator { get; set; }

    }
}
