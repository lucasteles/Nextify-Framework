namespace Pragma.Forms.Controls.Forms
{
    partial class FormEdit
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblId = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdCancelar = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdOk = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.metroPanel1);
            this.MainPanel.Size = new System.Drawing.Size(605, 330);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.metroPanel1, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(538, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(0, 5);
            this.TopPanel.Size = new System.Drawing.Size(605, 26);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(277, 22);
            this.flowLayoutPanel2.TabIndex = 82;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.flowLayoutPanel3);
            this.metroPanel1.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 288);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(605, 42);
            this.metroPanel1.TabIndex = 78;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblId);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(203, 42);
            this.flowLayoutPanel3.TabIndex = 86;
            // 
            // lblId
            // 
            this.lblId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblId.ForeColor = System.Drawing.Color.Blue;
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblId.Location = new System.Drawing.Point(3, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 45);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: (Novo)";
            this.lblId.UseSelectable = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmdCancelar);
            this.flowLayoutPanel1.Controls.Add(this.cmdOk);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(238, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 42);
            this.flowLayoutPanel1.TabIndex = 84;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(259, 6);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(99, 31);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseSelectable = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdOk.Location = new System.Drawing.Point(154, 6);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(99, 31);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Salvar";
            this.cmdOk.UseSelectable = true;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(625, 398);
            this.Name = "FormEdit";
            this.Text = "FormEdit";

            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

        private MetroFramework.Controls.MetroPanel metroPanel1;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.PragmaButton cmdCancelar;
        public Controls.PragmaButton cmdOk;
        public MetroFramework.Controls.MetroLink lblId;
    }
}