namespace Pragma.App.Forms
{
    partial class TestForm
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
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.IsTextFilterVisible = true;
            this.Grid.Location = new System.Drawing.Point(0, 31);
            this.Grid.Size = new System.Drawing.Size(580, 257);
            // 
            // MainPanel
            // 
            this.MainPanel.Size = new System.Drawing.Size(580, 288);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Size = new System.Drawing.Size(66, 26);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(580, 26);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // SpinnerLoad
            // 
            this.SpinnerLoad.Size = new System.Drawing.Size(21, 26);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.MainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}