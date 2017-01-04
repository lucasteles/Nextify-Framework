using Pragma.Core;
using Pragma.Extensions;
using Pragma.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public class ControlValidator<TControl> : IControlValidator<TControl>, IDisposable where TControl : Control
    {
        public static int TootipTime { get; set; } = 2000;

        public ControlValidator(BaseValidator<TControl> validator)
        {
            Validator = validator;
            Ballontip = new BalloonTip();

            if (Validator == null)
                ValidState = new OperationResult { Success = true };
        }
        public void ClearMessage(Control control)
        {
            Ballontip.Close();
        }
        public BaseValidator<TControl> Validator { get; set; }
        public IOperationResult ValidState { get; set; }
        public BalloonTip Ballontip { get; set; }
        private static BalloonIcon GetToolTipIcon(FailureSeverity failure)
        {
            var iconDictionary = new Dictionary<FailureSeverity, BalloonIcon>
            {
                [FailureSeverity.Error] = BalloonIcon.ERROR,
                [FailureSeverity.Info] = BalloonIcon.INFO,
                [FailureSeverity.Warning] = BalloonIcon.WARNING
            };

            return iconDictionary[failure];
        }
        private static string GetToolTipTitle(BalloonIcon ballonIcon)
        {
            var iconDictionary = new Dictionary<BalloonIcon, string>
            {
                [BalloonIcon.ERROR] = Messages.Error,
                [BalloonIcon.INFO] = Messages.Info,
                [BalloonIcon.WARNING] = Messages.Attention
            };

            return iconDictionary[ballonIcon];
        }
        public virtual async Task<bool> ValidateAsync(TControl control, Control tootipControl = null)
        {
            var valid = await Validator.ValidateAsync(control);
            var result = valid.ToOperationResult();
            ValidState = result;

            if (result.ErrorList.HasElements())
            {
                var messages = string.Join("\n", result.ErrorList.Select(e => e.Message));

                ShowTootipMessage(messages, control, result.ErrorList.OrderByDescending(e => e.Severity).FirstOrDefault().Severity);
            }
            control.SetBgColor();
            return result.Success;
        }
        public bool Validate(TControl control, Control tootipControl = null)
        {
            var valid = Validator.Validate(control);
            var result = valid.ToOperationResult();
            ValidState = result;

            if (result.ErrorList.HasElements())
            {
                var messages = string.Join("\n", result.ErrorList.Select(e => e.Message));

                ShowTootipMessage(messages, tootipControl ?? control, result.ErrorList.OrderByDescending(e => e.Severity).FirstOrDefault().Severity);
            }

            control.SetBgColor();
            return result.Success;
        }
        public virtual void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title = "")
        {
            ShowTootipMessage(messages, control, icon, title, TootipTime);
        }
        public virtual void ShowTootipMessage(string messages, Control control, FailureSeverity icon, string title, int time)
        {
            var ballonIcon = GetToolTipIcon(icon);

            if (string.IsNullOrEmpty(title))
            {
                title = GetToolTipTitle(ballonIcon);
            }

            Ballontip.Show(title, messages, control, ballonIcon, time, false);
        }
        public void Dispose()
        {
            Ballontip.Dispose();
        }
    }
}
