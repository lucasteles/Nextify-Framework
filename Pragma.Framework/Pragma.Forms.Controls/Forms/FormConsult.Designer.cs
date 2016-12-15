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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdDelete = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdAdd = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdEditar = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdExcel = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmtFilterInative = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdFilter = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.cmdRefresh = new Pragma.Forms.Controls.Controls.PragmaButton(this.components);
            this.Grid = new Pragma.Forms.Controls.Controls.PragmaDataGrid();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Grid);
            this.MainPanel.Size = new System.Drawing.Size(718, 358);
            this.MainPanel.Controls.SetChildIndex(this.TopPanel, 0);
            this.MainPanel.Controls.SetChildIndex(this.Grid, 0);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(872, 1);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.flowLayoutPanel1);
            this.TopPanel.Location = new System.Drawing.Point(0, 5);
            this.TopPanel.Size = new System.Drawing.Size(718, 26);
            this.TopPanel.Controls.SetChildIndex(this.buttonsPanel, 0);
            this.TopPanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.cmdDelete);
            this.flowLayoutPanel1.Controls.Add(this.cmdAdd);
            this.flowLayoutPanel1.Controls.Add(this.cmdEditar);
            this.flowLayoutPanel1.Controls.Add(this.cmdExcel);
            this.flowLayoutPanel1.Controls.Add(this.cmtFilterInative);
            this.flowLayoutPanel1.Controls.Add(this.cmdFilter);
            this.flowLayoutPanel1.Controls.Add(this.cmdRefresh);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(410, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 25);
            this.flowLayoutPanel1.TabIndex = 74;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.trash;
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDelete.Location = new System.Drawing.Point(208, 2);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(28, 21);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.UseSelectable = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = true;
            this.cmdAdd.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.add_list;
            this.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAdd.Location = new System.Drawing.Point(182, 2);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(22, 22);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.UseSelectable = true;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoSize = true;
            this.cmdEditar.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.edit;
            this.cmdEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEditar.Location = new System.Drawing.Point(156, 2);
            this.cmdEditar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(22, 22);
            this.cmdEditar.TabIndex = 0;
            this.cmdEditar.UseSelectable = true;
            // 
            // cmdExcel
            // 
            this.cmdExcel.AutoSize = true;
            this.cmdExcel.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.excel;
            this.cmdExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExcel.Location = new System.Drawing.Point(130, 2);
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
            this.cmtFilterInative.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.glasses;
            this.cmtFilterInative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmtFilterInative.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmtFilterInative.Location = new System.Drawing.Point(104, 2);
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
            this.cmdFilter.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.empty_filter;
            this.cmdFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFilter.Location = new System.Drawing.Point(78, 2);
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
            this.cmdRefresh.BackgroundImage = global::Pragma.Forms.Controls.BaseIcons.refresh;
            this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRefresh.Location = new System.Drawing.Point(52, 2);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(22, 22);
            this.cmdRefresh.TabIndex = 2;
            this.cmdRefresh.UseSelectable = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // Grid
            // 
            this.Grid.DataSource = null;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.IsAutoSizeColumns = true;
            this.Grid.IsSortable = false;
            this.Grid.Location = new System.Drawing.Point(0, 31);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(718, 327);
            this.Grid.TabIndex = 79;
            this.Grid.TextFilter = true;
            this.Grid.TextFilterArray = null;
            this.Grid.TextFilterField = null;
            this.Grid.UseSelectable = true;
            this.Grid.GridCellDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CustomDoubleClick);
            // 
            // FormConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 426);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "FormConsult";
            this.Text = "FormConsult";
            this.Load += new System.EventHandler(this.FormConsult_Load);
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.PragmaButton cmdEditar;
        private Controls.PragmaButton cmdAdd;
        private Controls.PragmaButton cmdDelete;
        private Controls.PragmaButton cmdRefresh;
        private Controls.PragmaButton cmdExcel;
        private Controls.PragmaButton cmtFilterInative;
        private Controls.PragmaButton cmdFilter;
        private Controls.PragmaDataGrid Grid;
    }
}