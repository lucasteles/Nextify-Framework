namespace Pragma.Forms.Controls
{
    partial class PragmaUploadFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PragmaUploadFile));
            this.cmdDownloadFile = new Pragma.Forms.Controls.PragmaButton();
            this.cmdRemoveFile = new Pragma.Forms.Controls.PragmaButton();
            this.txtPathFile = new Pragma.Forms.Controls.PragmaFindPath();
            this.SuspendLayout();
            // 
            // cmdDownloadFile
            // 
            this.cmdDownloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDownloadFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDownloadFile.BackgroundImage")));
            this.cmdDownloadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDownloadFile.Enabled = false;
            this.cmdDownloadFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdDownloadFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdDownloadFile.Location = new System.Drawing.Point(250, 0);
            this.cmdDownloadFile.Name = "cmdDownloadFile";
            this.cmdDownloadFile.Size = new System.Drawing.Size(25, 25);
            this.cmdDownloadFile.TabIndex = 1;
            this.cmdDownloadFile.UseSelectable = true;
            this.cmdDownloadFile.Click += new System.EventHandler(this.cmdDownloadFile_Click);
            // 
            // cmdRemoveFile
            // 
            this.cmdRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRemoveFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRemoveFile.BackgroundImage")));
            this.cmdRemoveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRemoveFile.Enabled = false;
            this.cmdRemoveFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdRemoveFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.cmdRemoveFile.Location = new System.Drawing.Point(275, 0);
            this.cmdRemoveFile.Name = "cmdRemoveFile";
            this.cmdRemoveFile.Size = new System.Drawing.Size(25, 25);
            this.cmdRemoveFile.TabIndex = 2;
            this.cmdRemoveFile.UseSelectable = true;
            this.cmdRemoveFile.Click += new System.EventHandler(this.cmdRemoveFile_Click);
            // 
            // txtPathFile
            // 
            this.txtPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFile.Extensions = "All Files|*.*";
            this.txtPathFile.Location = new System.Drawing.Point(0, 0);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Required = false;
            this.txtPathFile.SearchType = Pragma.Forms.Controls.BrowserType.OpenFiles;
            this.txtPathFile.Size = new System.Drawing.Size(250, 25);
            this.txtPathFile.TabIndex = 0;
            this.txtPathFile.UseSelectable = true;
            this.txtPathFile.Value = "";
            // 
            // PragmaUploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdDownloadFile);
            this.Controls.Add(this.cmdRemoveFile);
            this.Controls.Add(this.txtPathFile);
            this.Name = "PragmaUploadFile";
            this.Size = new System.Drawing.Size(300, 25);
            this.ResumeLayout(false);

        }
        #endregion

        private PragmaFindPath txtPathFile;
        private PragmaButton cmdRemoveFile;
        private PragmaButton cmdDownloadFile;
    }
}
