using Pragma.App.Forms.Tools;
using System;
using System.Windows.Forms;

namespace Pragma.App.Forms.Tests
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
            var form = DI.Resolve<frmTestePrincipal>();
            Application.Run(form);
        }
    }
}
