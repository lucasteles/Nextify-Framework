namespace Pragma.Forms.Controls
{
    partial class PragmaMenuControl
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
            this.tblSubMenus = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tblSubMenus.AutoSize = true;
            this.tblSubMenus.ColumnCount = 1;
            this.tblSubMenus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubMenus.Location = new System.Drawing.Point(0, 30);
            this.tblSubMenus.Name = "tblSubMenus";
            this.tblSubMenus.RowCount = 0;
            this.tblSubMenus.Size = new System.Drawing.Size(150, 120);
            this.tblSubMenus.TabIndex = 1;
            this.tblSubMenus.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // PgmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblSubMenus);
            this.Name = "PgmMenu";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSubMenus;
    }
}
