namespace Nextify.App.Forms
{
    partial class TagCourseEdit
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
            this.f4Tag = new Nextify.Forms.Controls.NextifyF4TextBox();
            this.nextifyLabel1 = new Nextify.Forms.Controls.NextifyLabel();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.nextifyLabel1);
            this.MainPanel.Controls.Add(this.f4Tag);
            this.MainPanel.Controls.Add(this.txtName);
            this.MainPanel.Size = new System.Drawing.Size(422, 179);
            this.MainPanel.Controls.SetChildIndex(this.txtName, 0);
            this.MainPanel.Controls.SetChildIndex(this.f4Tag, 0);
            this.MainPanel.Controls.SetChildIndex(this.nextifyLabel1, 0);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(392, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(422, 26);
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
            this.txtName.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(183, 72);
            this.txtName.Mask = "";
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
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.TabIndex = 80;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.Value = "";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // f4Tag
            // 
            this.f4Tag.BlankIfZero = true;
            this.f4Tag.Location = new System.Drawing.Point(52, 72);
            this.f4Tag.Name = "f4Tag";
            this.f4Tag.Required = false;
            this.f4Tag.Size = new System.Drawing.Size(125, 25);
            this.f4Tag.TabIndex = 81;
            this.f4Tag.UseSelectable = true;
            this.f4Tag.Valid = false;
            this.f4Tag.Value = null;
            this.f4Tag.ValueText = "";
            // 
            // nextifyLabel1
            // 
            this.nextifyLabel1.AutoSize = true;
            this.nextifyLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nextifyLabel1.Location = new System.Drawing.Point(12, 72);
            this.nextifyLabel1.Name = "nextifyLabel1";
            this.nextifyLabel1.Size = new System.Drawing.Size(31, 19);
            this.nextifyLabel1.TabIndex = 82;
            this.nextifyLabel1.Text = "Tag";
            // 
            // TagCourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 249);
            this.Name = "TagCourseEdit";
            this.Text = "Tag";
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
        private Nextify.Forms.Controls.NextifyLabel nextifyLabel1;
        private Nextify.Forms.Controls.NextifyF4TextBox f4Tag;
    }
}