namespace Nextify.App.Forms.Sys
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.NextifyLabel1 = new Nextify.Forms.Controls.NextifyLabel();
            this.NextifyLabel2 = new Nextify.Forms.Controls.NextifyLabel();
            this.cmdOk = new Nextify.Forms.Controls.NextifyButton();
            this.cmdCancelar = new Nextify.Forms.Controls.NextifyButton();
            this.txtLogin = new Nextify.Forms.Controls.NextifyTextBox();
            this.txtSenha = new Nextify.Forms.Controls.NextifyTextBox();
            this.cmbConnection = new Nextify.Forms.Controls.NextifyComboBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pcbLogo);
            this.MainPanel.Controls.Add(this.NextifyLabel2);
            this.MainPanel.Controls.Add(this.NextifyLabel1);
            this.MainPanel.Controls.Add(this.cmbConnection);
            this.MainPanel.Controls.Add(this.txtSenha);
            this.MainPanel.Controls.Add(this.txtLogin);
            this.MainPanel.Controls.Add(this.cmdCancelar);
            this.MainPanel.Controls.Add(this.cmdOk);
            this.MainPanel.Size = new System.Drawing.Size(483, 148);
            this.MainPanel.Controls.SetChildIndex(this.cmdOk, 0);
            this.MainPanel.Controls.SetChildIndex(this.cmdCancelar, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtLogin, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtSenha, 0);
            this.MainPanel.Controls.SetChildIndex(this.cmbConnection, 0);
            this.MainPanel.Controls.SetChildIndex(this.NextifyLabel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.NextifyLabel2, 0);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.pcbLogo, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(412, 3);
            this.buttonsPanel.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(0, 5);
            this.TopPanel.Padding = new System.Windows.Forms.Padding(350, 3, 5, 5);
            this.TopPanel.Size = new System.Drawing.Size(483, 29);
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
            this.cmdHelp.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(371, 3);
            // 
            // SpinnerLoad
            // 
            this.SpinnerLoad.Location = new System.Drawing.Point(350, 3);
            // 
            // NextifyLabel1
            // 
            this.NextifyLabel1.AutoSize = true;
            this.NextifyLabel1.BackColor = System.Drawing.Color.Transparent;
            this.NextifyLabel1.Location = new System.Drawing.Point(266, 38);
            this.NextifyLabel1.Name = "NextifyLabel1";
            this.NextifyLabel1.Size = new System.Drawing.Size(56, 19);
            this.NextifyLabel1.TabIndex = 79;
            this.NextifyLabel1.Text = "Usuário:";
            // 
            // NextifyLabel2
            // 
            this.NextifyLabel2.AutoSize = true;
            this.NextifyLabel2.BackColor = System.Drawing.Color.Transparent;
            this.NextifyLabel2.Location = new System.Drawing.Point(275, 71);
            this.NextifyLabel2.Name = "NextifyLabel2";
            this.NextifyLabel2.Size = new System.Drawing.Size(47, 19);
            this.NextifyLabel2.TabIndex = 80;
            this.NextifyLabel2.Text = "Senha:";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(275, 116);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(88, 27);
            this.cmdOk.TabIndex = 81;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_ClickAsync);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(386, 116);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(88, 27);
            this.cmdCancelar.TabIndex = 82;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseSelectable = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtLogin.BlankIfZero = true;
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(328, 38);
            this.txtLogin.Mask = "";
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.QtdDecimais = 2;
            this.txtLogin.RemoveMaskOnGetValue = true;
            this.txtLogin.Required = true;
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(146, 25);
            this.txtLogin.TabIndex = 83;
            this.txtLogin.UseCustomBackColor = true;
            this.txtLogin.UseCustomForeColor = true;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.Value = "";
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtSenha.BlankIfZero = true;
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(328, 71);
            this.txtSenha.Mask = "";
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.QtdDecimais = 2;
            this.txtSenha.RemoveMaskOnGetValue = true;
            this.txtSenha.Required = true;
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(146, 25);
            this.txtSenha.TabIndex = 84;
            this.txtSenha.UseCustomBackColor = true;
            this.txtSenha.UseCustomForeColor = true;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.Value = "";
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbConnection
            // 
            this.cmbConnection.BackColor = System.Drawing.Color.White;
            this.cmbConnection.FormattingEnabled = true;
            this.cmbConnection.ItemHeight = 23;
            this.cmbConnection.Location = new System.Drawing.Point(10, 116);
            this.cmbConnection.Name = "cmbConnection";
            this.cmbConnection.Required = false;
            this.cmbConnection.Size = new System.Drawing.Size(226, 29);
            this.cmbConnection.TabIndex = 65;
            this.cmbConnection.UseSelectable = true;
            this.cmbConnection.Validator = null;
            this.cmbConnection.Value = "";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Nextify.App.Forms.ImageResource.courses;
            this.pcbLogo.Location = new System.Drawing.Point(2, 21);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(249, 97);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 85;
            this.pcbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(503, 218);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Text = "Login";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nextify.Forms.Controls.NextifyButton cmdCancelar;
        private Nextify.Forms.Controls.NextifyButton cmdOk;
        private Nextify.Forms.Controls.NextifyLabel NextifyLabel2;
        private Nextify.Forms.Controls.NextifyLabel NextifyLabel1;
        private Nextify.Forms.Controls.NextifyTextBox txtLogin;
        private Nextify.Forms.Controls.NextifyTextBox txtSenha;
        private Nextify.Forms.Controls.NextifyComboBox cmbConnection;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}