using Nextify.Core.Icons;

namespace Nextify.Forms.Controls.Forms
{
    partial class FormBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopProgressbar = new MetroFramework.Controls.MetroProgressBar();
            this.line = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cmdHelp = new Nextify.Forms.Controls.NextifyButton();
            this.lblLoading = new Nextify.Forms.Controls.NextifyLabel();
            this.SpinnerLoad = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroStyleManager
            // 
            this.MetroStyleManager.Owner = this;
            this.MetroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TopProgressbar);
            this.MainPanel.Controls.Add(this.line);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(10, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(620, 290);
            this.MainPanel.TabIndex = 64;
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
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.line.Dock = System.Windows.Forms.DockStyle.Top;
            this.line.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.line.Location = new System.Drawing.Point(0, 26);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(620, 1);
            this.line.TabIndex = 76;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.buttonsPanel);
            this.TopPanel.Controls.Add(this.lblLoading);
            this.TopPanel.Controls.Add(this.SpinnerLoad);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(12, 0, 5, 5);
            this.TopPanel.Size = new System.Drawing.Size(620, 26);
            this.TopPanel.TabIndex = 72;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cmdHelp);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(590, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(25, 21);
            this.buttonsPanel.TabIndex = 72;
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
            this.cmdHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdHelp.Location = new System.Drawing.Point(3, 0);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(22, 22);
            this.cmdHelp.TabIndex = 85;
            this.cmdHelp.UseSelectable = true;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(56, 19);
            this.lblLoading.TabIndex = 70;
            this.lblLoading.Text = "Loading";
            // 
            // SpinnerLoad
            // 
            this.SpinnerLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpinnerLoad.Location = new System.Drawing.Point(12, 0);
            this.SpinnerLoad.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SpinnerLoad.Maximum = 100;
            this.SpinnerLoad.Name = "SpinnerLoad";
            this.SpinnerLoad.Size = new System.Drawing.Size(21, 21);
            this.SpinnerLoad.TabIndex = 69;
            this.SpinnerLoad.TabStop = false;
            this.SpinnerLoad.UseSelectable = true;
            this.SpinnerLoad.UseStyleColors = true;
            this.SpinnerLoad.Visible = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.MainPanel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormBase";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sistema Nextify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBase_FormClosed);
            this.Load += new System.EventHandler(this.FormBase_LoadAsync);
            this.Shown += new System.EventHandler(this.FormBase_ShownAsync);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormBase_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel MainPanel;
        protected System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Label line;
        private MetroFramework.Controls.MetroProgressBar TopProgressbar;
        public System.Windows.Forms.Panel TopPanel;
        protected NextifyButton cmdHelp;
        protected NextifyLabel lblLoading;
        protected MetroFramework.Controls.MetroProgressSpinner SpinnerLoad;
        public MetroFramework.Components.MetroStyleManager MetroStyleManager;
    }
}