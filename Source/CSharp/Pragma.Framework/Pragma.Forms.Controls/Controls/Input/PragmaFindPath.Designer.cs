namespace Pragma.Forms.Controls
{
    partial class PragmaFindPath
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFind = new Pragma.Forms.Controls.PragmaTextBox();
            this.cmdFind = new Pragma.Forms.Controls.PragmaButton();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BackColor = System.Drawing.Color.White;
            this.txtFind.BlankIfZero = true;
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(0, 0);
            this.txtFind.Mask = "";
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.QtdDecimais = 2;
            this.txtFind.RemoveMaskOnGetValue = true;
            this.txtFind.Required = false;
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(260, 25);
            this.txtFind.TabIndex = 0;
            this.txtFind.UseCustomBackColor = true;
            this.txtFind.UseCustomForeColor = true;
            this.txtFind.UseSelectable = true;
            this.txtFind.Value = "";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.Validating += new System.ComponentModel.CancelEventHandler(this.txtFind_ValidatingAsync);
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFind.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdFind.Location = new System.Drawing.Point(260, 0);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(40, 25);
            this.cmdFind.TabIndex = 1;
            this.cmdFind.Text = "...";
            this.cmdFind.UseSelectable = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // PragmaFindPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.txtFind);
            this.Name = "PragmaFindPath";
            this.Size = new System.Drawing.Size(300, 25);
            this.ResumeLayout(false);

        }

        #endregion
        private PragmaButton cmdFind;
        public PragmaTextBox txtFind;
    }
}
