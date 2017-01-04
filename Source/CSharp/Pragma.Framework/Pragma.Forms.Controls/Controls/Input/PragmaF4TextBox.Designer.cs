namespace Pragma.Forms.Controls
{
    partial class PragmaF4TextBox
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
            this.components = new System.ComponentModel.Container();
            this.txtF4 = new Pragma.Forms.Controls.PragmaTextBox();
            this.cmdFind = new Pragma.Forms.Controls.PragmaButton();
            this.SuspendLayout();
            // 
            // txtF4
            // 
            this.txtF4.BackColor = System.Drawing.Color.White;
            this.txtF4.BlankIfZero = true;
            // 
            // 
            // 
            this.txtF4.CustomButton.Image = null;
            this.txtF4.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtF4.CustomButton.Name = "";
            this.txtF4.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtF4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtF4.CustomButton.TabIndex = 1;
            this.txtF4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtF4.CustomButton.UseSelectable = true;
            this.txtF4.CustomButton.Visible = false;
            this.txtF4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtF4.Lines = new string[0];
            this.txtF4.Location = new System.Drawing.Point(0, 0);
            this.txtF4.Mask = "";
            this.txtF4.MaxLength = 32767;
            this.txtF4.Name = "txtF4";
            this.txtF4.PasswordChar = '\0';
            this.txtF4.QtdDecimais = 2;
            this.txtF4.RemoveMaskOnGetValue = true;
            this.txtF4.Required = false;
            this.txtF4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtF4.SelectedText = "";
            this.txtF4.SelectionLength = 0;
            this.txtF4.SelectionStart = 0;
            this.txtF4.Size = new System.Drawing.Size(105, 25);
            this.txtF4.TabIndex = 1;
            this.txtF4.UseCustomBackColor = true;
            this.txtF4.UseCustomForeColor = true;
            this.txtF4.UseSelectable = true;
            this.txtF4.Value = "";
            this.txtF4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtF4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtF4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtF4_KeyUp);
            // 
            // cmdFind
            // 
            this.cmdFind.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.search;
            this.cmdFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdFind.Location = new System.Drawing.Point(105, 0);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(20, 25);
            this.cmdFind.TabIndex = 0;
            this.cmdFind.UseSelectable = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // PragmaF4TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtF4);
            this.Controls.Add(this.cmdFind);
            this.Name = "PragmaF4TextBox";
            this.Size = new System.Drawing.Size(125, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private PragmaButton cmdFind;
        private PragmaTextBox txtF4;
    }
}
