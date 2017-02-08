namespace Nextify.Forms.Controls
{
    partial class NextifyMenuItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NextifyMenuItemControl));
            this.cmdAbrir = new System.Windows.Forms.Button();
            this.tblSubMenus = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdAbrir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdAbrir.FlatAppearance.BorderSize = 0;
            this.cmdAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbrir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmdAbrir.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbrir.Image")));
            this.cmdAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAbrir.Location = new System.Drawing.Point(0, 0);
            this.cmdAbrir.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.Size = new System.Drawing.Size(186, 25);
            this.cmdAbrir.TabIndex = 0;
            this.cmdAbrir.Text = "Menu Teste";
            this.cmdAbrir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAbrir.UseVisualStyleBackColor = false;
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            this.cmdAbrir.Paint += new System.Windows.Forms.PaintEventHandler(this.cmdAbrir_Paint);
            this.cmdAbrir.MouseEnter += new System.EventHandler(this.CmdAbrir_MouseEnter);
            this.cmdAbrir.MouseLeave += new System.EventHandler(this.CmdAbrir_MouseLeave);
            // 
            // tblSubMenus
            // 
            this.tblSubMenus.AutoSize = true;
            this.tblSubMenus.ColumnCount = 1;
            this.tblSubMenus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSubMenus.Location = new System.Drawing.Point(0, 25);
            this.tblSubMenus.Name = "tblSubMenus";
            this.tblSubMenus.RowCount = 0;
            this.tblSubMenus.Size = new System.Drawing.Size(186, 125);
            this.tblSubMenus.TabIndex = 1;
            this.tblSubMenus.Visible = false;
            // 
            // PgmMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tblSubMenus);
            this.Controls.Add(this.cmdAbrir);
            this.Name = "PgmMenuItem";
            this.Size = new System.Drawing.Size(186, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblSubMenus;
        private System.Windows.Forms.Button cmdAbrir;
    }
}
