using Pragma.Core;
using Pragma.Validations;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public interface IControlValidator<TControl> where TControl : Control
    {
        BalloonTip Ballontip { get; set; }
        BaseValidator<TControl> Validator { get; set; }
        IOperationResult ValidState { get; set; }
        void ClearMessage(Control control);
        Task<bool> ValidateAsync(TControl control, Control tootipControl = null);
        bool Validate(TControl control, Control tootipControl = null);
        void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title);
        void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title, int time);
    }
}