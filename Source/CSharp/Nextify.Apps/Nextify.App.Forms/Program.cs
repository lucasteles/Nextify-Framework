using Nextify.App.Forms.Sys;
using Nextify.App.Forms.Tools;
using Nextify.Forms;
using System;
using System.Windows.Forms;

namespace Nextify.App.Forms
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
            var form = DI.Resolve<Main>();
            Application.Run(form);
        }
    }
}
