﻿using Pragma.Core;
using Pragma.Forms.Controls.Abstraction;
using ModelViewBinder;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public enum TextBoxType
    {
        String,
        Integer,
        Decimal,
        Date
    }
    public partial class PragmaNumericUpDown : NumericUpDown, IControl
    {
        /// <summary>
        /// Propriedade indica o tipo de dados que a textbox vai trabalhar
        /// </summary>
        [Description("Propriedade indica o tipo de dados que a textbox vai trabalhar")]
        public TextBoxType DataType { get; set; } = TextBoxType.Decimal;
        public PragmaNumericUpDown()
        {
            InitializeComponent();
        }

        private bool _required { get; set; }
        public bool Required { get { return _required; } set { _required = value; } }
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
        public void SetValue(object tValue)
        {
            var value = Convert.ToDecimal(tValue);
            value = Minimum > value ? Minimum : value;
            value = Maximum < value ? Maximum : value;

            Value = value;
        }

        public object GetValue()
        {

            switch (DataType)
            {
                case TextBoxType.Decimal:
                    return Value;
                case TextBoxType.Integer:
                    return Convert.ToInt32(Value);
                default:
                    return Value.ToString();
            }
        }
        public int GetValueInt()
        {
            return Convert.ToInt32(Value);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title)
        {
            throw new NotImplementedException();
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            throw new NotImplementedException();
        }
    }
}