using Pragma.App.Forms.Sys;
using Pragma.Core.Icons;
using Pragma.Forms.Controls;
using Pragma.Forms.Controls.Forms;
using Pragma.Forms.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pragma.App.Forms
{
    public partial class Main : FormBase
    {
        
        public Main()
        {
            var Login = DI.Resolve<frmLogin>();
            Login.ShowDialog();



            InitializeComponent();
        }

        private void MDIParent_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) Close();
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            
            var menus = new List<PragmaMenuItem>
            {
                new PragmaMenuItem() {Name="Cursos", Icon = Weather.lightning_bolt, ButtonAction = ()=>DI.ShowForm<CoursesConsult>()},
                new PragmaMenuItem() {Name="Authors", Icon = Weather.rain},
                new PragmaMenuItem() {Name="Tags", Icon = Weather.sun }
            };

            pgmMenu1.SetMenus(menus);
        }
    }
}
