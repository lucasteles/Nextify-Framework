using Nextify.App.Forms.Sys;
using Nextify.Core.Icons;
using Nextify.Forms.Controls;
using Nextify.Forms.Controls.Forms;
using Nextify.Forms.Models;
using System.Collections.Generic;
using System.Linq;

namespace Nextify.App.Forms
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
            
            var menus = new List<NextifyMenuItem>
            {
                new NextifyMenuItem() {Name="Cursos", Icon = Weather.lightning_bolt,
                                        ButtonAction = ()=>DI.ShowForm<CoursesConsult>()},
                new NextifyMenuItem() {Name="Authors", Icon = Weather.rain,
                                        ButtonAction = ()=>DI.ShowForm<AuthorConsult>()},
                new NextifyMenuItem() {Name="Tags", Icon = Weather.sun }
            };

            pgmMenu1.SetMenus(menus);
        }
    }
}
