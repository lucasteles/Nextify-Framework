using MetroFramework.Controls;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Core;
using System;
using System.Threading.Tasks;

namespace Nextify.Forms.Controls
{
    public partial class NextifyCheckBox : MetroCheckBox, IControl, IControlWithValidation<NextifyCheckBox>
    {
        public NextifyCheckBox()
        {
            Configure();
            InitializeComponent();
        }

        #region Configuracao
        private void Configure()
        {
            if (!DesignMode)
                Validator = new ControlValidator<NextifyCheckBox>(null);

            this.SetBgColor();
        }
        #endregion

        #region Propriedades
        public event EventHandler ValueChanged;
        public IControlValidator<NextifyCheckBox> Validator { get; set; }

        private bool _required;
        public bool Required { get { return _required; } set { _required = value; this.SetBgColor(); } }
        public object Value { get { return GetValue(); } set { SetValue(value); } }
        #endregion

        #region Metodos
        private object GetValue()
        {
            return Checked;
        }
        private void SetValue(object tValue)
        {
            var value = Convert.ToByte(tValue);
            Checked = value == 1;
        }
        public bool IsEmpty()
        {
            return false;
        }
        public bool IsValid()
        {
            return true;
        }
        public async Task<bool> ValidateAsync()
        {
            return await Task.Run(() => true);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title = "")
        {
            Validator.ShowTootipMessage(message, this, severity, title);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            Validator.ShowTootipMessage(message, this, severity, title, time);
        }
        #endregion

        #region Eventos
        private void NextifyCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(sender, e);
        }
        #endregion
    }
}
