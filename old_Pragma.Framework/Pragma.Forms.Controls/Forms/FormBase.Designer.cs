namespace Pragma.Forms.Controls.Forms
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
            this.cmdHelp = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ToolConfig = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolRights = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoading = new Pragma.Forms.Controls.Controls.PragmaLabel();
            this.SpinnerLoad = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.StatusBar.SuspendLayout();
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
            this.MainPanel.Size = new System.Drawing.Size(496, 290);
            this.MainPanel.TabIndex = 64;
            // 
            // TopProgressbar
            // 
            this.TopProgressbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopProgressbar.Location = new System.Drawing.Point(0, 27);
            this.TopProgressbar.Name = "TopProgressbar";
            this.TopProgressbar.Size = new System.Drawing.Size(496, 4);
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
            this.line.Size = new System.Drawing.Size(496, 1);
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
            this.TopPanel.Size = new System.Drawing.Size(496, 26);
            this.TopPanel.TabIndex = 72;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.Controls.Add(this.cmdHelp);
            this.buttonsPanel.Controls.Add(this.StatusBar);
            this.buttonsPanel.Location = new System.Drawing.Point(425, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(66, 25);
            this.buttonsPanel.TabIndex = 72;
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.help;
            this.cmdHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdHelp.Location = new System.Drawing.Point(2, 2);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(22, 22);
            this.cmdHelp.TabIndex = 85;
            this.cmdHelp.UseSelectable = true;
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = false;
            this.StatusBar.BackColor = System.Drawing.Color.White;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolConfig});
            this.StatusBar.Location = new System.Drawing.Point(29, 0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(0);
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar.Size = new System.Drawing.Size(37, 25);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 84;
            this.StatusBar.Text = "StatusBar";
            // 
            // ToolConfig
            // 
            this.ToolConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolRights});
            this.ToolConfig.Image = ((System.Drawing.Image)(resources.GetObject("ToolConfig.Image")));
            this.ToolConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolConfig.Margin = new System.Windows.Forms.Padding(0);
            this.ToolConfig.Name = "ToolConfig";
            this.ToolConfig.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ToolConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolConfig.Size = new System.Drawing.Size(37, 20);
            this.ToolConfig.Text = "toolStripSplitButton1";
            // 
            // ToolRights
            // 
            this.ToolRights.Image = ((System.Drawing.Image)(resources.GetObject("ToolRights.Image")));
            this.ToolRights.Name = "ToolRights";
            this.ToolRights.Size = new System.Drawing.Size(114, 22);
            this.ToolRights.Text = "Direitos";
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
            this.ClientSize = new System.Drawing.Size(516, 358);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormBase";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 8);
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "BaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBase_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager MetroStyleManager;
        protected System.Windows.Forms.Panel MainPanel;
        private Controls.PragmaLabel lblLoading;
        private MetroFramework.Controls.MetroProgressSpinner SpinnerLoad;
        protected System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Label line;
        private MetroFramework.Controls.MetroProgressBar TopProgressbar;
        private Controls.PragmaButton cmdHelp;
        protected System.Windows.Forms.StatusStrip StatusBar;
        protected System.Windows.Forms.ToolStripSplitButton ToolConfig;
        protected System.Windows.Forms.ToolStripMenuItem ToolRights;
        public System.Windows.Forms.Panel TopPanel;
    }
}