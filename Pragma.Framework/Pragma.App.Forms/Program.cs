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

            var form = DI.Resolve<CoursesConsult>();

            Application.Run(form);
        }
    }
}
