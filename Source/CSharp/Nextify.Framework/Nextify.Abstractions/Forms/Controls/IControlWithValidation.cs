using System.Windows.Forms;

namespace Nextify.Abstraction.Forms.Controls
{
    public interface IControlWithValidation<TControl> where TControl : Control
    {
        IControlValidator<TControl> Validator { get; set; }

    }
}
