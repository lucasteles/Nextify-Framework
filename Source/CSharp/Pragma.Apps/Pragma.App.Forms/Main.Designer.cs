namespace Pragma.App.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopProgressbar = new MetroFramework.Controls.MetroProgressBar();
            this.pgmMenu1 = new Pragma.Forms.Controls.PragmaMenuControl();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pgmMenu1);
            this.MainPanel.Size = new System.Drawing.Size(942, 505);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.pgmMenu1, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(912, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(0, 5);
            this.TopPanel.Size = new System.Drawing.Size(942, 26);
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // TopProgressbar
            // 
            this.TopProgressbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopProgressbar.Location = new System.Drawing.Point(0, 27);
            this.TopProgressbar.Name = "TopProgressbar";
            this.TopProgressbar.Size = new System.Drawing.Size(620, 4);
            this.TopProgressbar.TabIndex = 77;
            this.TopProgressbar.Visible = false;
            // 
            // pgmMenu1
            // 
            this.pgmMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgmMenu1.IconBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pgmMenu1.Location = new System.Drawing.Point(0, 31);
            this.pgmMenu1.Name = "pgmMenu1";
            this.pgmMenu1.Size = new System.Drawing.Size(238, 474);
            this.pgmMenu1.TabIndex = 78;
            this.pgmMenu1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(962, 575);
            this.Name = "Main";
            this.Text = "Sistema Cursos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MDIParent_KeyPress);
            this.MainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pragma.Forms.Controls.PragmaMenuControl pgmMenu1;
        private MetroFramework.Controls.MetroProgressBar TopProgressbar;
    }
}