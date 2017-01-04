namespace Pragma.App.Forms.Tests
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.pragmaTextBox1 = new Pragma.Forms.Controls.PragmaTextBox();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pragmaTextBox1);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.pragmaTextBox1, 0);
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // pragmaTextBox1
            // 
            this.pragmaTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.pragmaTextBox1.BlankIfZero = true;
            // 
            // 
            // 
            this.pragmaTextBox1.CustomButton.Image = null;
            this.pragmaTextBox1.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.pragmaTextBox1.CustomButton.Name = "";
            this.pragmaTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pragmaTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pragmaTextBox1.CustomButton.TabIndex = 1;
            this.pragmaTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pragmaTextBox1.CustomButton.UseSelectable = true;
            this.pragmaTextBox1.CustomButton.Visible = false;
            this.pragmaTextBox1.ForeColor = System.Drawing.Color.Black;
            this.pragmaTextBox1.Lines = new string[0];
            this.pragmaTextBox1.Location = new System.Drawing.Point(212, 101);
            this.pragmaTextBox1.Mask = "";
            this.pragmaTextBox1.MaxLength = 32767;
            this.pragmaTextBox1.Name = "pragmaTextBox1";
            this.pragmaTextBox1.PasswordChar = '\0';
            this.pragmaTextBox1.QtdDecimais = 2;
            this.pragmaTextBox1.RemoveMaskOnGetValue = true;
            this.pragmaTextBox1.Required = true;
            this.pragmaTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pragmaTextBox1.SelectedText = "";
            this.pragmaTextBox1.SelectionLength = 0;
            this.pragmaTextBox1.SelectionStart = 0;
            this.pragmaTextBox1.ShortcutsEnabled = true;
            this.pragmaTextBox1.Size = new System.Drawing.Size(205, 23);
            this.pragmaTextBox1.TabIndex = 79;
            this.pragmaTextBox1.UseCustomBackColor = true;
            this.pragmaTextBox1.UseCustomForeColor = true;
            this.pragmaTextBox1.UseSelectable = true;
            this.pragmaTextBox1.Value = "";
            this.pragmaTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pragmaTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 398);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            this.MainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pragma.Forms.Controls.PragmaTextBox pragmaTextBox1;
    }
}