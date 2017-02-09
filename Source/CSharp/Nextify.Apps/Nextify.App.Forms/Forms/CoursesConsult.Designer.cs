namespace Nextify.App.Forms
{
    partial class CoursesConsult
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
            this.Grid.Location = new System.Drawing.Point(0, 30);
            this.Grid.Size = new System.Drawing.Size(749, 315);
            // 
            // MainPanel
            // 
            this.MainPanel.Size = new System.Drawing.Size(749, 345);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(678, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(749, 25);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(37, 0);
            // 
            // SpinnerLoad
            // 
            this.SpinnerLoad.Size = new System.Drawing.Size(25, 25);
            // 
            // CoursesConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 415);
            this.Name = "CoursesConsult";
            this.Text = "Consulta de cursos";
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