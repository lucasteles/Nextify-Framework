using Pragma.Abstraction.Forms.Controls;
using Pragma.Core;
using System;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls
{
    public partial class PragmaF4TextBox : PragmaUserControl, IControl
    {
        public event EventHandler OnCallWindow;
        public event EventHandler OnSetValue;
        public event EventHandler OnValidate;
        public event EventHandler ValueChanged;

        public bool Valid { get; set; }
        private object _value { get; set; }
        public object Value { get { return _value; } set { _value = value; OnSetValue?.Invoke(value, EventArgs.Empty); } }
        public object ValueText { get { return txtF4.Value; } set { txtF4.Value = value; } }
        public bool BlankIfZero { get { return txtF4.BlankIfZero; } set { txtF4.BlankIfZero = value; } }

        public bool Required
        {
            get
            {
                return txtF4.Required;
            }

            set
            {
                txtF4.Required = value;
            }
        }
        public PragmaF4TextBox()
        {
            InitializeComponent();
        }
        private void cmdFind_Click(object sender, System.EventArgs e)
        {
            DoF4();
        }
        private void txtF4_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // 115 É O F4
            if (e.KeyValue == 115)
                DoF4();
        }
        private void DoF4()
        {
            OnCallWindow?.Invoke(this, EventArgs.Empty);
        }
        public new void Focus()
        {
            txtF4.Focus();
            txtF4.SelectionStart = 0;
            txtF4.SelectionLength = txtF4.Text.Length;
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title = "")
        {
            if (severity == FailureSeverity.Warning || severity == FailureSeverity.Error)
                txtF4.BackColor = PragmaColor.VermelhoError;

            txtF4.ShowTootipMessage(message, severity, title, -1);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            txtF4.ShowTootipMessage(message, severity, title);
        }
        public void DoChange()
        {
            if (Valid)
                txtF4.SetBgColor();
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public bool IsEmpty()
        {
            return txtF4.IsEmpty();
        }
        public async Task<bool> ValidateAsync()
        {
            OnValidate?.Invoke(this, EventArgs.Empty);
            return (await txtF4.ValidateAsync()) && Valid;
        }
        public bool IsValid()
        {
            OnValidate?.Invoke(this, EventArgs.Empty);
            return txtF4.IsValid() && Valid;
        }
    }
}
