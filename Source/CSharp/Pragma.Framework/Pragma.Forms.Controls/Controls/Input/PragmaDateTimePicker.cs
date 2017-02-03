using Pragma.Core;

using ModelViewBinder;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pragma.Abstraction.Forms.Controls;

namespace Pragma.Forms.Controls
{
    public partial class PragmaDateTimePicker : DateTimePicker, IControl, IControlWithValidation<PragmaDateTimePicker>
    {
        private bool _required { get; set; }
        public bool Required { get { return _required; } set { _required = value; } }

        public IControlValidator<PragmaDateTimePicker> Validator { get; set; }

        object IControlWithValue.Value
        {
            get
            {
                return GetValue();
            }

            set
            {
                SetValue(value);
            }
        }
        public PragmaDateTimePicker()
        {
            InitializeComponent();

            Validator = new ControlValidator<PragmaDateTimePicker>(null);
        }

        public object GetValue()
        {
            // se for a data sem o time, ignora o tempo
            if (Checked)
            {
                if (Format == DateTimePickerFormat.Short)
                    return Value.Date;
                return Value;
            }
            else
                return null;
        }
        /// <summary>
        /// Retorna a Data selecionada no controle.
        /// </summary>
        /// <returns>A Data selecionada no controle.</returns>
        public DateTime GetDateValue()
        {
            return Checked ? Value.Date : default(DateTime);
        }

        public void SetValue(object tValue)
        {
            if (tValue != null)
            {
                if (((DateTime)tValue).Year != 1)
                {
                    Value = (DateTime)tValue;
                    Text = tValue.ToString();
                    Checked = true;
                }
            }
            PgmDateTimePicker_ValueChanged(null, null);
        }

        public bool IsEmpty()
        {
            return false;
        }

        private void PgmDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Font = Checked ? new Font(Font, FontStyle.Regular) : new Font(Font, FontStyle.Strikeout);

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
            Validator.ShowTootipMessage(message, this, severity, title);
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            Validator.ShowTootipMessage(message, this, severity, title, time);
        }
    }
}
