using Pragma.Core.Icons;

namespace Pragma.Forms.Controls.Forms
{
    partial class FormConsult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsult));
            this.Grid = new Pragma.Forms.Controls.PragmaDataGrid();
            this.cmdClose = new Pragma.Forms.Controls.PragmaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdDelete = new Pragma.Forms.Controls.PragmaButton();
            this.cmdInative = new Pragma.Forms.Controls.PragmaButton();
            this.cmdEditar = new Pragma.Forms.Controls.PragmaButton();
            this.cmdAdd = new Pragma.Forms.Controls.PragmaButton();
            this.cmdExcel = new Pragma.Forms.Controls.PragmaButton();
            this.cmtFilterInative = new Pragma.Forms.Controls.PragmaButton();
            this.cmdFilter = new Pragma.Forms.Controls.PragmaButton();
            this.cmdRefresh = new Pragma.Forms.Controls.PragmaButton();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.cmdClose);
            this.MainPanel.Controls.Add(this.Grid);
            this.MainPanel.Size = new System.Drawing.Size(580, 327);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.Grid, 0);
            this.MainPanel.Controls.SetChildIndex(this.cmdClose, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(509, 0);
            this.buttonsPanel.Size = new System.Drawing.Size(66, 25);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.flowLayoutPanel1);
            this.TopPanel.Location = new System.Drawing.Point(0, 5);
            this.TopPanel.Padding = new System.Windows.Forms.Padding(12, 0, 5, 0);
            this.TopPanel.Size = new System.Drawing.Size(580, 25);
            this.TopPanel.Controls.SetChildIndex(this.SpinnerLoad, 0);
            this.TopPanel.Controls.SetChildIndex(this.lblLoading, 0);
            this.TopPanel.Controls.SetChildIndex(this.buttonsPanel, 0);
            this.TopPanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // SpinnerLoad
            // 
            this.SpinnerLoad.Size = new System.Drawing.Size(21, 25);
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.IsAutoSizeColumns = true;
            this.Grid.IsSortable = true;
            this.Grid.IsTextFilterVisible = true;
            this.Grid.Location = new System.Drawing.Point(0, 30);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(580, 297);
            this.Grid.TabIndex = 79;
            this.Grid.UseCustomFilter = false;
            this.Grid.UseOddRowColor = true;
            this.Grid.UseSelectable = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(0, 500);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(20, 22);
            this.cmdClose.TabIndex = 65;
            this.cmdClose.UseSelectable = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmdDelete);
            this.flowLayoutPanel1.Controls.Add(this.cmdInative);
            this.flowLayoutPanel1.Controls.Add(this.cmdEditar);
            this.flowLayoutPanel1.Controls.Add(this.cmdAdd);
            this.flowLayoutPanel1.Controls.Add(this.cmdExcel);
            this.flowLayoutPanel1.Controls.Add(this.cmtFilterInative);
            this.flowLayoutPanel1.Controls.Add(this.cmdFilter);
            this.flowLayoutPanel1.Controls.Add(this.cmdRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 25);
            this.flowLayoutPanel1.TabIndex = 75;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDelete.Location = new System.Drawing.Point(208, 2);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(28, 21);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.UseSelectable = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdInative
            // 
            this.cmdInative.AutoSize = true;
            this.cmdInative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdInative.BackgroundImage")));
            this.cmdInative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdInative.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdInative.Location = new System.Drawing.Point(182, 2);
            this.cmdInative.Margin = new System.Windows.Forms.Padding(2);
            this.cmdInative.Name = "cmdInative";
            this.cmdInative.Size = new System.Drawing.Size(22, 22);
            this.cmdInative.TabIndex = 7;
            this.cmdInative.UseSelectable = true;
            this.cmdInative.Click += new System.EventHandler(this.cmdInative_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoSize = true;
            this.cmdEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdEditar.BackgroundImage")));
            this.cmdEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEditar.Location = new System.Drawing.Point(156, 2);
            this.cmdEditar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(22, 22);
            this.cmdEditar.TabIndex = 0;
            this.cmdEditar.UseSelectable = true;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = true;
            this.cmdAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAdd.BackgroundImage")));
            this.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAdd.Location = new System.Drawing.Point(130, 2);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(22, 22);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.UseSelectable = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.AutoSize = true;
            this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
            this.cmdExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExcel.Location = new System.Drawing.Point(104, 2);
            this.cmdExcel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(22, 22);
            this.cmdExcel.TabIndex = 4;
            this.cmdExcel.UseSelectable = true;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmtFilterInative
            // 
            this.cmtFilterInative.AutoSize = true;
            this.cmtFilterInative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmtFilterInative.BackgroundImage")));
            this.cmtFilterInative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmtFilterInative.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmtFilterInative.Location = new System.Drawing.Point(78, 2);
            this.cmtFilterInative.Margin = new System.Windows.Forms.Padding(2);
            this.cmtFilterInative.Name = "cmtFilterInative";
            this.cmtFilterInative.Size = new System.Drawing.Size(22, 22);
            this.cmtFilterInative.TabIndex = 5;
            this.cmtFilterInative.UseSelectable = true;
            this.cmtFilterInative.Click += new System.EventHandler(this.cmtFilterInative_Click);
            // 
            // cmdFilter
            // 
            this.cmdFilter.AutoSize = true;
            this.cmdFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdFilter.BackgroundImage")));
            this.cmdFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFilter.Location = new System.Drawing.Point(52, 2);
            this.cmdFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Size = new System.Drawing.Size(22, 22);
            this.cmdFilter.TabIndex = 6;
            this.cmdFilter.UseSelectable = true;
            this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.AutoSize = true;
            this.cmdRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.BackgroundImage")));
            this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRefresh.Location = new System.Drawing.Point(26, 2);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(22, 22);
            this.cmdRefresh.TabIndex = 2;
            this.cmdRefresh.UseSelectable = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // FormConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(600, 397);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "FormConsult";
            this.Text = "FormConsult";
            this.Load += new System.EventHandler(this.FormConsult_LoadAsync);
            this.MainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PragmaButton cmdClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PragmaButton cmdDelete;
        private PragmaButton cmdInative;
        private PragmaButton cmdEditar;
        private PragmaButton cmdAdd;
        private PragmaButton cmdExcel;
        private PragmaButton cmdFilter;
        private PragmaButton cmdRefresh;
        protected PragmaDataGrid Grid;
        protected PragmaButton cmtFilterInative;
    }
}