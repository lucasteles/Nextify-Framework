namespace Nextify.App.Forms
{
    partial class CoursesEdit
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
            this.txtName = new Nextify.Forms.Controls.NextifyTextBox();
            this.txtPrice = new Nextify.Forms.Controls.NextifyTextBox();
            this.txtLevel = new Nextify.Forms.Controls.NextifyTextBox();
            this.NextifyLabel1 = new Nextify.Forms.Controls.NextifyLabel();
            this.NextifyLabel2 = new Nextify.Forms.Controls.NextifyLabel();
            this.NextifyLabel3 = new Nextify.Forms.Controls.NextifyLabel();
            this.f4Author = new Nextify.Forms.Controls.NextifyF4TextBox();
            this.nextifyLabel4 = new Nextify.Forms.Controls.NextifyLabel();
            this.txtAuthorName = new Nextify.Forms.Controls.NextifyTextBox();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.txtAuthorName);
            this.MainPanel.Controls.Add(this.nextifyLabel4);
            this.MainPanel.Controls.Add(this.f4Author);
            this.MainPanel.Controls.Add(this.NextifyLabel3);
            this.MainPanel.Controls.Add(this.NextifyLabel2);
            this.MainPanel.Controls.Add(this.NextifyLabel1);
            this.MainPanel.Controls.Add(this.txtLevel);
            this.MainPanel.Controls.Add(this.txtPrice);
            this.MainPanel.Controls.Add(this.txtName);
            this.MainPanel.Size = new System.Drawing.Size(472, 278);
            this.MainPanel.Controls.SetChildIndex(this.txtName, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtPrice, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtLevel, 0);
            this.MainPanel.Controls.SetChildIndex(this.NextifyLabel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.NextifyLabel2, 0);
            this.MainPanel.Controls.SetChildIndex(this.NextifyLabel3, 0);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.f4Author, 0);
            this.MainPanel.Controls.SetChildIndex(this.nextifyLabel4, 0);
            this.MainPanel.Controls.SetChildIndex(this.txtAuthorName, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(442, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(472, 26);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BlankIfZero = true;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(183, 48);
            this.txtName.Mask = null;
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.QtdDecimais = 2;
            this.txtName.RemoveMaskOnGetValue = true;
            this.txtName.Required = false;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.Value = "";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BlankIfZero = true;
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(183, 89);
            this.txtPrice.Mask = null;
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.QtdDecimais = 2;
            this.txtPrice.RemoveMaskOnGetValue = true;
            this.txtPrice.Required = false;
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(177, 23);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.UseCustomBackColor = true;
            this.txtPrice.UseCustomForeColor = true;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.Value = "";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.White;
            this.txtLevel.BlankIfZero = true;
            // 
            // 
            // 
            this.txtLevel.CustomButton.Image = null;
            this.txtLevel.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtLevel.CustomButton.Name = "";
            this.txtLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLevel.CustomButton.TabIndex = 1;
            this.txtLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLevel.CustomButton.UseSelectable = true;
            this.txtLevel.CustomButton.Visible = false;
            this.txtLevel.ForeColor = System.Drawing.Color.Black;
            this.txtLevel.Lines = new string[0];
            this.txtLevel.Location = new System.Drawing.Point(183, 131);
            this.txtLevel.Mask = null;
            this.txtLevel.MaxLength = 32767;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.PasswordChar = '\0';
            this.txtLevel.QtdDecimais = 2;
            this.txtLevel.RemoveMaskOnGetValue = true;
            this.txtLevel.Required = false;
            this.txtLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLevel.SelectedText = "";
            this.txtLevel.SelectionLength = 0;
            this.txtLevel.SelectionStart = 0;
            this.txtLevel.ShortcutsEnabled = true;
            this.txtLevel.Size = new System.Drawing.Size(177, 23);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.UseCustomBackColor = true;
            this.txtLevel.UseCustomForeColor = true;
            this.txtLevel.UseSelectable = true;
            this.txtLevel.Value = "";
            this.txtLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NextifyLabel1
            // 
            this.NextifyLabel1.AutoSize = true;
            this.NextifyLabel1.BackColor = System.Drawing.Color.Transparent;
            this.NextifyLabel1.Location = new System.Drawing.Point(60, 48);
            this.NextifyLabel1.Name = "NextifyLabel1";
            this.NextifyLabel1.Size = new System.Drawing.Size(46, 19);
            this.NextifyLabel1.TabIndex = 82;
            this.NextifyLabel1.Text = "Nome";
            // 
            // NextifyLabel2
            // 
            this.NextifyLabel2.AutoSize = true;
            this.NextifyLabel2.BackColor = System.Drawing.Color.Transparent;
            this.NextifyLabel2.Location = new System.Drawing.Point(60, 89);
            this.NextifyLabel2.Name = "NextifyLabel2";
            this.NextifyLabel2.Size = new System.Drawing.Size(43, 19);
            this.NextifyLabel2.TabIndex = 83;
            this.NextifyLabel2.Text = "Preço";
            // 
            // NextifyLabel3
            // 
            this.NextifyLabel3.AutoSize = true;
            this.NextifyLabel3.BackColor = System.Drawing.Color.Transparent;
            this.NextifyLabel3.Location = new System.Drawing.Point(60, 131);
            this.NextifyLabel3.Name = "NextifyLabel3";
            this.NextifyLabel3.Size = new System.Drawing.Size(38, 19);
            this.NextifyLabel3.TabIndex = 84;
            this.NextifyLabel3.Text = "Nivel";
            // 
            // f4Author
            // 
            this.f4Author.BlankIfZero = true;
            this.f4Author.Location = new System.Drawing.Point(183, 176);
            this.f4Author.Name = "f4Author";
            this.f4Author.Required = false;
            this.f4Author.Size = new System.Drawing.Size(84, 25);
            this.f4Author.TabIndex = 3;
            this.f4Author.UseSelectable = true;
            this.f4Author.Valid = false;
            this.f4Author.Value = null;
            this.f4Author.ValueText = "";
            // 
            // nextifyLabel4
            // 
            this.nextifyLabel4.AutoSize = true;
            this.nextifyLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nextifyLabel4.Location = new System.Drawing.Point(60, 176);
            this.nextifyLabel4.Name = "nextifyLabel4";
            this.nextifyLabel4.Size = new System.Drawing.Size(42, 19);
            this.nextifyLabel4.TabIndex = 86;
            this.nextifyLabel4.Text = "Autor";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BackColor = System.Drawing.Color.White;
            this.txtAuthorName.BlankIfZero = true;
            // 
            // 
            // 
            this.txtAuthorName.CustomButton.Image = null;
            this.txtAuthorName.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtAuthorName.CustomButton.Name = "";
            this.txtAuthorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuthorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthorName.CustomButton.TabIndex = 1;
            this.txtAuthorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthorName.CustomButton.UseSelectable = true;
            this.txtAuthorName.CustomButton.Visible = false;
            this.txtAuthorName.Enabled = false;
            this.txtAuthorName.ForeColor = System.Drawing.Color.Black;
            this.txtAuthorName.Lines = new string[0];
            this.txtAuthorName.Location = new System.Drawing.Point(273, 176);
            this.txtAuthorName.Mask = null;
            this.txtAuthorName.MaxLength = 32767;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.PasswordChar = '\0';
            this.txtAuthorName.QtdDecimais = 2;
            this.txtAuthorName.RemoveMaskOnGetValue = true;
            this.txtAuthorName.Required = false;
            this.txtAuthorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthorName.SelectedText = "";
            this.txtAuthorName.SelectionLength = 0;
            this.txtAuthorName.SelectionStart = 0;
            this.txtAuthorName.ShortcutsEnabled = true;
            this.txtAuthorName.Size = new System.Drawing.Size(177, 23);
            this.txtAuthorName.TabIndex = 87;
            this.txtAuthorName.TabStop = false;
            this.txtAuthorName.UseCustomBackColor = true;
            this.txtAuthorName.UseCustomForeColor = true;
            this.txtAuthorName.UseSelectable = true;
            this.txtAuthorName.Value = "";
            this.txtAuthorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CoursesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 348);
            this.Name = "CoursesEdit";
            this.Text = "Edição de cursos";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Nextify.Forms.Controls.NextifyTextBox txtName;
        private Nextify.Forms.Controls.NextifyTextBox txtLevel;
        private Nextify.Forms.Controls.NextifyTextBox txtPrice;
        private Nextify.Forms.Controls.NextifyLabel NextifyLabel3;
        private Nextify.Forms.Controls.NextifyLabel NextifyLabel2;
        private Nextify.Forms.Controls.NextifyLabel NextifyLabel1;
        private Nextify.Forms.Controls.NextifyLabel nextifyLabel4;
        private Nextify.Forms.Controls.NextifyF4TextBox f4Author;
        private Nextify.Forms.Controls.NextifyTextBox txtAuthorName;
    }
}