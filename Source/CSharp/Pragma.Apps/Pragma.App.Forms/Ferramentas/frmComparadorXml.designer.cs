using System.Windows.Forms;

namespace Pragma.Forms
{
    partial class frmComparadorXml
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
            this.Grid = new Pragma.Forms.Controls.PragmaDataGrid();
            this.pgmLabel1 = new Pragma.Forms.Controls.PragmaLabel();
            this.pgmPainel1 = new System.Windows.Forms.Panel();
            this.pgmLabel3 = new Pragma.Forms.Controls.PragmaLabel();
            this.pgmLabel2 = new Pragma.Forms.Controls.PragmaLabel();
            this.txtDuplicado = new Pragma.Forms.Controls.PragmaFindPath();
            this.cmdComparar = new Pragma.Forms.Controls.PragmaButton();
            this.txtOld = new Pragma.Forms.Controls.PragmaFindPath();
            this.txtRaiz = new Pragma.Forms.Controls.PragmaFindPath();
            this.pragmaLabel1 = new Pragma.Forms.Controls.PragmaLabel();
            this.MainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.pgmPainel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Size = new System.Drawing.Size(538, 420);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(467, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(538, 26);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(33, 0);
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.IsAutoSizeColumns = false;
            this.Grid.IsSortable = true;
            this.Grid.IsTextFilterVisible = true;
            this.Grid.Location = new System.Drawing.Point(10, 182);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(538, 298);
            this.Grid.TabIndex = 3;
            this.Grid.UseCustomFilter = false;
            this.Grid.UseOddRowColor = true;
            this.Grid.UseSelectable = true;
            // 
            // pgmLabel1
            // 
            this.pgmLabel1.AutoSize = true;
            this.pgmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pgmLabel1.Location = new System.Drawing.Point(23, 114);
            this.pgmLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.pgmLabel1.Name = "pgmLabel1";
            this.pgmLabel1.Size = new System.Drawing.Size(52, 19);
            this.pgmLabel1.TabIndex = 53;
            this.pgmLabel1.Text = "Destino";
            // 
            // pgmPainel1
            // 
            this.pgmPainel1.Controls.Add(this.pragmaLabel1);
            this.pgmPainel1.Controls.Add(this.pgmLabel3);
            this.pgmPainel1.Controls.Add(this.pgmLabel2);
            this.pgmPainel1.Controls.Add(this.txtDuplicado);
            this.pgmPainel1.Controls.Add(this.cmdComparar);
            this.pgmPainel1.Controls.Add(this.txtOld);
            this.pgmPainel1.Controls.Add(this.txtRaiz);
            this.pgmPainel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgmPainel1.Location = new System.Drawing.Point(10, 60);
            this.pgmPainel1.Name = "pgmPainel1";
            this.pgmPainel1.Size = new System.Drawing.Size(538, 122);
            this.pgmPainel1.TabIndex = 58;
            // 
            // pgmLabel3
            // 
            this.pgmLabel3.AutoSize = true;
            this.pgmLabel3.BackColor = System.Drawing.Color.Transparent;
            this.pgmLabel3.Location = new System.Drawing.Point(54, 33);
            this.pgmLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.pgmLabel3.Name = "pgmLabel3";
            this.pgmLabel3.Size = new System.Drawing.Size(31, 19);
            this.pgmLabel3.TabIndex = 61;
            this.pgmLabel3.Text = "Old";
            // 
            // pgmLabel2
            // 
            this.pgmLabel2.AutoSize = true;
            this.pgmLabel2.BackColor = System.Drawing.Color.Transparent;
            this.pgmLabel2.Location = new System.Drawing.Point(30, 6);
            this.pgmLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.pgmLabel2.Name = "pgmLabel2";
            this.pgmLabel2.Size = new System.Drawing.Size(55, 19);
            this.pgmLabel2.TabIndex = 60;
            this.pgmLabel2.Text = "Origem";
            // 
            // txtDuplicado
            // 
            this.txtDuplicado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuplicado.Extensions = "All Files|*.*";
            this.txtDuplicado.Location = new System.Drawing.Point(91, 60);
            this.txtDuplicado.Name = "txtDuplicado";
            this.txtDuplicado.Required = true;
            this.txtDuplicado.SearchType = Pragma.Forms.Controls.BrowserType.Directories;
            this.txtDuplicado.Size = new System.Drawing.Size(432, 25);
            this.txtDuplicado.TabIndex = 59;
            this.txtDuplicado.UseSelectable = true;
            this.txtDuplicado.Value = "";
            // 
            // cmdComparar
            // 
            this.cmdComparar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdComparar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdComparar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdComparar.Location = new System.Drawing.Point(448, 91);
            this.cmdComparar.Name = "cmdComparar";
            this.cmdComparar.Size = new System.Drawing.Size(75, 23);
            this.cmdComparar.TabIndex = 58;
            this.cmdComparar.Text = "Comparar";
            this.cmdComparar.UseSelectable = true;
            this.cmdComparar.Click += new System.EventHandler(this.cmdComparar_ClickAsync);
            // 
            // txtOld
            // 
            this.txtOld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOld.Extensions = "All Files|*.*";
            this.txtOld.Location = new System.Drawing.Point(91, 33);
            this.txtOld.Name = "txtOld";
            this.txtOld.Required = true;
            this.txtOld.SearchType = Pragma.Forms.Controls.BrowserType.Directories;
            this.txtOld.Size = new System.Drawing.Size(432, 25);
            this.txtOld.TabIndex = 57;
            this.txtOld.UseSelectable = true;
            this.txtOld.Value = "";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaiz.Extensions = "All Files|*.*";
            this.txtRaiz.Location = new System.Drawing.Point(91, 6);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Required = true;
            this.txtRaiz.SearchType = Pragma.Forms.Controls.BrowserType.Directories;
            this.txtRaiz.Size = new System.Drawing.Size(432, 25);
            this.txtRaiz.TabIndex = 56;
            this.txtRaiz.UseSelectable = true;
            this.txtRaiz.Value = "";
            // 
            // pragmaLabel1
            // 
            this.pragmaLabel1.AutoSize = true;
            this.pragmaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pragmaLabel1.Location = new System.Drawing.Point(12, 60);
            this.pragmaLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.pragmaLabel1.Name = "pragmaLabel1";
            this.pragmaLabel1.Size = new System.Drawing.Size(73, 19);
            this.pragmaLabel1.TabIndex = 62;
            this.pragmaLabel1.Text = "Duplicados";
            // 
            // frmComparadorXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 490);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.pgmPainel1);
            this.Name = "frmComparadorXml";
            this.Text = "Comparador de XML";
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.Controls.SetChildIndex(this.pgmPainel1, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            this.MainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.pgmPainel1.ResumeLayout(false);
            this.pgmPainel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Pragma.Forms.Controls.PragmaDataGrid Grid;
        private Pragma.Forms.Controls.PragmaLabel pgmLabel1;
        private System.Windows.Forms.Panel pgmPainel1;
        private Pragma.Forms.Controls.PragmaLabel pgmLabel3;
        private Pragma.Forms.Controls.PragmaLabel pgmLabel2;
        private Pragma.Forms.Controls.PragmaFindPath txtDuplicado;
        private Pragma.Forms.Controls.PragmaButton cmdComparar;
        private Pragma.Forms.Controls.PragmaFindPath txtOld;
        private Pragma.Forms.Controls.PragmaFindPath txtRaiz;
        private Controls.PragmaLabel pragmaLabel1;
    }
}