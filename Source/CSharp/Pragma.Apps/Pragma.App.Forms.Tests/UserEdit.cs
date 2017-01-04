using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls.Forms;
using System.Threading.Tasks;

namespace Pragma.App.Forms.Tests
{
    public partial class UserEdit : FormEdit

    {

        readonly IEditController<DbUsuarioLogin> Controller;
        IUsuarioLoginBusiness Business;
        public UserEdit(IEditController<DbUsuarioLogin> controller, IUsuarioLoginBusiness business)
        {
            Controller = controller;
            Business = business;
            InitializeComponent();
        }
        public async override Task FormLoadAsync()
        {
            var bind = await Controller.UseAsync(this, Business);
            bind.Register(e => e.Nome, pragmaTextBox1);

        }
    }
}
