namespace Nextify.Forms.Controls
{
    partial class NextifyTextBox
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
            this.SuspendLayout();
            // 
            // NextifyTextBox
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.@__MouseClick);
            this.EnabledChanged += new System.EventHandler(this.@__EnabledChanged);
            this.Enter += new System.EventHandler(this.@__Enter);
            this.Leave += new System.EventHandler(this.@__Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.@__MouseDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.@__KeyPress);
            this.TextChanged += new System.EventHandler(this.@__TextChanged);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.ForeColor = System.Drawing.Color.Black;

            this.ResumeLayout(false);

        }

        #endregion
    }
}
