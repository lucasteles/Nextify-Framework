namespace Nextify.Forms.Controls
{
    partial class NextifyDateTimePicker
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
            this.SuspendLayout();
            // 
            // NextifyDateTimePicker
            // 
            this.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShowCheckBox = true;
            this.Size = new System.Drawing.Size(180, 25);
            this.ValueChanged += new System.EventHandler(this.PgmDateTimePicker_ValueChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
