using FluentValidation;
using Pragma.Abstraction;
using Pragma.Core;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Abstraction.Forms.Controls
{
    public interface IBallontip
    {
        void Close();
        void Dispose();
        void Show(string title, string text, Control control, BalloonIcon icon = BalloonIcon.NONE, double timeOut = 0, bool focus = false, short x = 0, short y = 0);
    }

    public interface IBaseValidator<T> :  IValidator<T>
    {

    }


    public interface IControlValidator<TControl> where TControl : Control
    {
        IBallontip Ballontip { get; set; }
        IBaseValidator<TControl> Validator { get; set; }
        IOperationResult ValidState { get; set; }
        void ClearMessage(Control control);
        Task<bool> ValidateAsync(TControl control, Control tootipControl = null);
        bool Validate(TControl control, Control tootipControl = null);
        void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title);
        void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title, int time);
    }
}