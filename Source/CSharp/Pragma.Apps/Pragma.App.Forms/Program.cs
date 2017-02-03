using Pragma.App.Forms.Sys;
using Pragma.App.Forms.Tools;
using Pragma.Forms;
using System;
using System.Windows.Forms;

namespace Pragma.App.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Startup.Start();
            var form = DI.Resolve<frmPrincipal>();
            Application.Run(form);
        }
    }
}
