using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    partial class PragmaDataGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilter = new Pragma.Forms.Controls.PragmaTextBox();
            this.lblNrRegistros = new MetroFramework.Controls.MetroLink();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.BlankIfZero = true;
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Mask = "";
            this.txtFilter.MaximumSize = new System.Drawing.Size(0, 25);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.MinimumSize = new System.Drawing.Size(0, 25);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.QtdDecimais = 2;
            this.txtFilter.RemoveMaskOnGetValue = true;
            this.txtFilter.Required = false;
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(300, 25);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.UseCustomBackColor = true;
            this.txtFilter.UseCustomForeColor = true;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.Value = "";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
            // 
            // lblNrRegistros
            // 
            this.lblNrRegistros.AutoSize = true;
            this.lblNrRegistros.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNrRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNrRegistros.Location = new System.Drawing.Point(300, 0);
            this.lblNrRegistros.MaximumSize = new System.Drawing.Size(100, 25);
            this.lblNrRegistros.MinimumSize = new System.Drawing.Size(100, 25);
            this.lblNrRegistros.Name = "lblNrRegistros";
            this.lblNrRegistros.Size = new System.Drawing.Size(100, 25);
            this.lblNrRegistros.TabIndex = 1;
            this.lblNrRegistros.Text = "Registros:";
            this.lblNrRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNrRegistros.UseSelectable = true;
            // 
            // grdView
            // 
            this.grdView.AllowUserToAddRows = false;
            this.grdView.BackgroundColor = System.Drawing.Color.White;
            this.grdView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdView.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.Location = new System.Drawing.Point(0, 25);
            this.grdView.Name = "grdView";
            this.grdView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdView.RowHeadersVisible = false;
            this.grdView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdView.Size = new System.Drawing.Size(400, 275);
            this.grdView.TabIndex = 2;
            this.grdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.grdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.grdView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDown);
            this.grdView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellMouseEnter);
            this.grdView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellMouseLeave);
            this.grdView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Grid_CellPainting);
            this.grdView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_KeyPress);
            this.grdView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseClick);
            this.grdView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseUp);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.txtFilter);
            this.pnlSuperior.Controls.Add(this.lblNrRegistros);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(400, 25);
            this.pnlSuperior.TabIndex = 3;
            // 
            // PragmaDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdView);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "PragmaDataGrid";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperior;
        protected MetroFramework.Controls.MetroLink lblNrRegistros;
        protected PragmaTextBox txtFilter;
        protected DataGridView grdView;
    }
}
