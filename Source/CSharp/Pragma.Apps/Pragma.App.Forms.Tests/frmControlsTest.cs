using Pragma.App.Business;
using Pragma.App.Forms.Controllers.Combos;
using Pragma.App.Forms.Controllers.F4;
using Pragma.App.Forms.Controllers.GridItems;
using Pragma.App.Model;
using Pragma.Forms.Controls.Abstraction;
using Pragma.Forms.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pragma.App.Forms.Tests
{
    public partial class frmControlsTest : FormBase
    {
        readonly IConnectionComboController ConnectionComboController;
        readonly IUsuarioLoginF4Controller UsuarioLoginF4Controller;
        readonly IUsuarioGridItemsController UsuarioGridItemsController;

        readonly IUsuarioLoginBusiness UsuarioLoginBusiness;
        private IList<DbUsuarioLogin> Usuarios;

        public frmControlsTest(
            IConnectionComboController connectionComboController,
            IUsuarioLoginF4Controller usuarioLoginF4Controller,
            IUsuarioGridItemsController usuarioGridItemsController,
            IUsuarioLoginBusiness usuarioLoginBusiness
         )
        {
            InitializeComponent();

            ConnectionComboController = connectionComboController;
            UsuarioLoginF4Controller = usuarioLoginF4Controller;
            UsuarioGridItemsController = usuarioGridItemsController;

            UsuarioLoginBusiness = usuarioLoginBusiness;
        }
        public async override Task FormLoadAsync()
        {

            Usuarios = (await UsuarioLoginBusiness.GetAsync(e => e.Inativo == 0 && e.ListGrups.Count() > 0, 5)).ToArray();

            await ConnectionComboController.UseAsync(cboComboBusiness, o => o.ValueMember, o => o.DisplayMember);
            var binder = await UsuarioLoginF4Controller.UseAsync(txtF4);
            binder.Register(e => e.Nome, pragmaTextBox1);

            await UsuarioGridItemsController.UseAsync(pragmaGridItems1);
            UsuarioGridItemsController.SetFormEdit<UserEdit>();
            pragmaGridItems1.Value = Usuarios;

            chkListBox.AddItem("A");
            chkListBox.AddItem("B");
            chkListBox.AddItem("C");
            chkListBox.AddItem("D");
        }
        private void cmdComboBusiness_Click(object sender, EventArgs e)
        {
            ShowMessage(cboComboBusiness.Value.ToString());

            cboComboBusiness.Value = "Homolog2Connection";
            var xxx = pragmaGridItems1.Value;

        }
        private void cmdComboBox_Click(object sender, EventArgs e)
        {

            IControl d1 = txtData;
            var x = txtData.Value;
            var y = d1.Value;
        }

        private void cmdCheckListBox_Click(object sender, EventArgs e)
        {
            ShowMessage(chkListBox.Value.ToString());
            chkListBox.Value = "A;B;C";
        }
    }
}
