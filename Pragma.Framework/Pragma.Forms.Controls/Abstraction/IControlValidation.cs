using Pragma.Core;
using Pragma.Validations;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public interface IControlValidator<TControl> where TControl : Control
    {
        ToolTip ToolTip { get; set; }
        BaseValidator<TControl> Validator { get; set; }
        IOperationResult ValidState { get; set; }

        void SetBgColor(object control);
        Task<bool> Validate(TControl control);
        void ShowTootipMessage(string messages, TControl control, FailureSeverity icon, string title = "");
    }
}