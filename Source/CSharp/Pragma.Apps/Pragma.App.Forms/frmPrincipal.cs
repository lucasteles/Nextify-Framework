using Pragma.App.Business.Sys;
using Pragma.Forms.Controls.Forms;
using System.Linq;

namespace Pragma.App.Forms
{
    public partial class frmPrincipal : FormBase
    {

        private readonly IMenuPrincipalBusiness MenuBusiness;
        public bool OK => true;//Login.OK;
        public frmPrincipal(IMenuPrincipalBusiness menuBusiness)
        {
            MenuBusiness = menuBusiness;

            //Login = DI.Resolve<frmLogin>();
            //Login.ShowDialog();

            InitializeComponent();
        }

        private void MDIParent_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) Close();
        }

        private async void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            var dummyList = await MenuBusiness.GetAllMenus();
            //var b = dummyList.ToList();
            //var menuList = (IEnumerable)await MenuBusiness.GetAllMenus();

            //var menuList = ParseMenu(dummyList);

            pgmMenu1.SetMenus(dummyList.ToList());
        }
    }
}
