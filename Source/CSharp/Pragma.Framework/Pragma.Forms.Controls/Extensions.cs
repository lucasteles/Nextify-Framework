using Pragma.Core;
using Pragma.Forms.Controls.Abstraction;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public static class Extensions
    {
        public static void SetBgColor(this Control control)
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
