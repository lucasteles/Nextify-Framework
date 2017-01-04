using MetroFramework.Controls;
using Pragma.Forms.Controls.Abstraction;
using System;
using System.Collections.Generic;
using Pragma.Core;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Pragma.Forms.Controls
{
    public partial class PragmaComboBox : MetroComboBox, IControl, IControlWithValidation<PragmaComboBox>
    {
        public PragmaComboBox()
        {
            InitializeComponent();
        }

        #region Propriedades
        public void BindList<TView>(IList<TView> list)
        {
            DataSource = list;
        }

        object _Value;
        public object Value
        {
            get
            {
                if (DesignMode)
                    return "";

                ValueGet?.Invoke(_Value, null);
                ValueChanged?.Invoke(_Value, EventArgs.Empty);
                return _Value;
            }
            set
            {
                if (DesignMode)
                    return;

                ValueSet?.Invoke(value, null);
                ValueChanged?.Invoke(_Value, EventArgs.Empty);
                _Value = value;
            }
        }

        private bool _required;
        public bool Required { get { return _required; } set { _required = value; this.SetBgColor(); } }
        #endregion

        #region Metodos
        public IControlValidator<PragmaComboBox> Validator { get; set; }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title = "")
        {
            Validator.ShowTootipMessage(message, this, severity, title);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            Validator.ShowTootipMessage(message, this, severity, title, time);
        }
        public bool IsEmpty()
        {
            return Text == "";
        }
        public async Task<bool> ValidateAsync()
        {
            if (Validator == null)
                return true;

            return await Validator.ValidateAsync(this);
        }
        public bool IsValid()
        {
            return Validator?.ValidState?.Success ?? true;
        }
        #endregion

        #region Eventos
        public event EventHandler ValueGet;
        public event EventHandler ValueChanged;
        public event EventHandler ValueSet;
        public virtual void DoValueSet(object sender, EventArgs e) { ValueSet?.Invoke(sender, e); }
        public virtual void DoValueGet(object sender, EventArgs e) { ValueGet?.Invoke(sender, e); }
        #endregion
    }
}
