using Pragma.Abstraction.Forms.Controls;
using Pragma.Core;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public partial class PragmaFindColor : PragmaUserControl, IControl
    {
        public PragmaFindColor()
        {
            if (DesignMode)
                return;

            InitializeComponent();
        }

        public event EventHandler ValueChanged;

        public bool Required { get; set; }
        public object Value { get { return picColor.BackColor.ToArgb(); } set { picColor.BackColor = Color.FromArgb(Convert.ToInt32(value)); ValueChanged?.Invoke(this, EventArgs.Empty); } }
        public bool IsEmpty()
        {
            return false;
        }

        public bool IsValid()
        {
            return true;
        }

        public Task<bool> ValidateAsync()
        {
            return Task.FromResult(true);
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title)
        {
            throw new NotImplementedException();
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            throw new NotImplementedException();
        }

        private void cmdFindColor_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.Color = picColor.BackColor;
                // Show the color dialog.
                var result = dialog.ShowDialog();
                // See if user pressed ok.
                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    picColor.BackColor = dialog.Color;
                }
            }
        }
    }
}
