using Nextify.Core;
using Nextify.Forms.Controls.Abstraction;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
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
                baseControl.BackColor = NextifyColor.CinzaDisabled;
            else if (!pgmControl.IsValid())
                baseControl.BackColor = NextifyColor.VermelhoError;
            else if (pgmControl.Required)
                baseControl.BackColor = NextifyColor.AmareloAlert;
            else
                baseControl.BackColor = NextifyColor.Branco;
        }

    }
}
