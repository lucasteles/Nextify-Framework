using MetroFramework.Controls;
using Pragma.Core;
using Pragma.Forms.Controls.Abstraction;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls.Controls
{
    public partial class PragmaCheckBox : MetroCheckBox, IControl, IControlWithValidation<PragmaCheckBox>
    {
        public IControlValidator<PragmaCheckBox> Validator { get; set; }


        public PragmaCheckBox()
        {
            Configure();
            InitializeComponent();
        }

        public PragmaCheckBox(IContainer container)
        {
            container.Add(this);
            Configure();

            InitializeComponent();



        }

        private void Configure()
        {
            Validator = new ControlValidator<PragmaCheckBox>(null);
        }


        private bool _required;
        public bool Required { get { return _required; } set { _required = value; Validator.SetBgColor(this); } }

        public object Value { get { return GetValue().ToString(); } set { SetValue(value); } }


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

        public async Task<bool> Validate()
        {
            return await Task.Run(() => true);
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title = "")
        {
            Validator.ShowTootipMessage(message, this, severity, title);
        }
    }
}
