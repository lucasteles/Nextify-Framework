using Pragma.Core;
using Pragma.Extensions;
using Pragma.Forms.Controls.Abstraction;

using Pragma.Validations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public class ControlValidator<TControl> : IControlValidator<TControl> where TControl : Control
    {
        public ControlValidator(BaseValidator<TControl> validator)
        {
            Validator = validator;

            ToolTip.UseFading = true;

            if (validator == null)
                ValidState = new OperationResult() { Success = true };


        }

        public BaseValidator<TControl> Validator { get; set; }
        public IOperationResult ValidState { get; set; }
        public ToolTip ToolTip { get; set; } = new ToolTip();

        private ToolTipIcon GetToolTipIcon(FailureSeverity failure)
        {
            var iconDictionary = new Dictionary<FailureSeverity, ToolTipIcon>()
            {
                [FailureSeverity.Error] = ToolTipIcon.Error,
                [FailureSeverity.Info] = ToolTipIcon.Info,
                [FailureSeverity.Warning] = ToolTipIcon.Warning
            };

            return iconDictionary[failure];
        }

        public virtual async Task<bool> Validate(TControl control)
        {
            var valid = await Validator.ValidateAsync(control);
            var result = valid.ToOperationResult();
            ValidState = result;


            if (result.ErrorList.HasElements())
            {
                var messages = string.Join("\n", result.ErrorList.Select(e => e.Message));

                ShowTootipMessage(messages, control, result.ErrorList.OrderByDescending(e => e.Severity).FirstOrDefault().Severity);
            }

            SetBgColor(control);
            return result.Success;

        }


        public virtual void ShowTootipMessage(string messages, TControl control, FailureSeverity icon, string title = "")
        {
            ToolTip.ToolTipIcon = GetToolTipIcon(icon);
            ToolTip.Show(messages, control, 2000);
            ToolTip.Show(messages, control, 2000);
        }



        public void SetBgColor(object control)
        {
            if (!(typeof(IControl).IsAssignableFrom(control.GetType()) && typeof(Control).IsAssignableFrom(control.GetType())))
                return;

            var pgmControl = (IControl)control;
            var baseControl = (Control)control;
            if (!baseControl.Enabled)
                baseControl.BackColor = PragmaColor.CinzaDisabled;
            else if (!pgmControl.IsValid())
                baseControl.BackColor = PragmaColor.VermelhoError;
            else if (pgmControl.Required)
                baseControl.BackColor = PragmaColor.AmareloAlert;
            else
                baseControl.BackColor = PragmaColor.Branco;
        }
    }
}
