using Pragma.App.Business;
using Pragma.App.Forms.Controllers.Combos;
using Pragma.Forms.Controls.Forms;
using System;
using System.Threading.Tasks;

namespace Pragma.App.Forms.Sys
{
    public partial class frmLogin : FormBase
    {
        AppConfiguration config { get; set; }
        IUsuarioLoginBusiness UsuarioLoginBusiness { get; set; }
        IConnectionComboController ConnectionComboController { get; set; }
        public bool OK { get; set; } = false;

        public frmLogin(
            IUsuarioLoginBusiness usuarioLoginBusiness,
            IConnectionComboController connectionComboController
        )
        {
            InitializeComponent();
            config = new AppConfiguration();
            UsuarioLoginBusiness = usuarioLoginBusiness;
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
            await ConnectionComboController.UseAsync(cmbConnection, o => o.ValueMember, o => o.DisplayMember);
        }

        private async void cmdOk_ClickAsync(object sender, EventArgs e)
        {
            await RunWithLoadAsync(DoLoginAsync, "Logando...", cmdOk, cmdCancelar, cmbConnection);
        }
        private async Task DoLoginAsync()
        {
            var loginTry = await UsuarioLoginBusiness.LoginAsync(txtLogin.Text, txtSenha.Text);

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
