namespace Pragma.Forms.Controls
{
    partial class PragmaFindColor
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
            this.picColor = new System.Windows.Forms.PictureBox();
            this.cmdFindColor = new Pragma.Forms.Controls.PragmaButton();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picColor
            // 
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(0, 0);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(38, 25);
            this.picColor.TabIndex = 0;
            this.picColor.TabStop = false;
            // 
            // cmdFindColor
            // 
            this.cmdFindColor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdFindColor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdFindColor.Location = new System.Drawing.Point(39, 0);
            this.cmdFindColor.Name = "cmdFindColor";
            this.cmdFindColor.Size = new System.Drawing.Size(30, 25);
            this.cmdFindColor.TabIndex = 1;
            this.cmdFindColor.Text = "<";
            this.cmdFindColor.UseSelectable = true;
            this.cmdFindColor.Click += new System.EventHandler(this.cmdFindColor_Click);
            // 
            // PragmaFindColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdFindColor);
            this.Controls.Add(this.picColor);
            this.Name = "PragmaFindColor";
            this.Size = new System.Drawing.Size(68, 25);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picColor;
        private PragmaButton cmdFindColor;
    }
}
