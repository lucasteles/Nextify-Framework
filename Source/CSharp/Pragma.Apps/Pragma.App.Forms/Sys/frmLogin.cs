using Pragma.App.Business;
using Pragma.App.Forms.Controllers.Combos;
using Pragma.Core;
using Pragma.Forms.Controls.Forms;
using System;
using System.Threading.Tasks;

namespace Pragma.App.Forms.Sys
{
    public partial class frmLogin : FormBase
    {
        AppConfiguration config { get; set; }
        
        IConnectionComboController ConnectionComboController { get; set; }
        public bool OK { get; set; } = false;

        public frmLogin(
            IConnectionComboController connectionComboController
        )
        {
            InitializeComponent();
            config = new AppConfiguration();
            ConnectionComboController = connectionComboController;
            
            txtLogin.Text = Environment.UserName.ToUpper();

            // sempre inicia focado na senha
            PasswordFocus();

            this.Select();
            this.Focus();

        }
        private void PasswordFocus()
        {
            txtSenha.Select();
            txtSenha.Focus();
        }

        public async override Task FormLoadAsync()
        {
            await ConnectionComboController.UseAsync(cmbConnection, o => o.Name, o => o.Name);
        }

        private async void cmdOk_ClickAsync(object sender, EventArgs e)
        {
            await RunWithLoadAsync(DoLoginAsync, "Logando...", cmdOk, cmdCancelar, cmbConnection);
        }
        private async Task DoLoginAsync()
        {
            await Task.Delay(1000);
            var loginTry = OperationResult.Ok();

            if (!ShowMessage(loginTry))
            {
                PasswordFocus();
                return;
            }

            OK = true;
            config.SetConnection(cmbConnection.Value.ToString().Trim());
            Close();
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {

            Close();
        }
    }
}
