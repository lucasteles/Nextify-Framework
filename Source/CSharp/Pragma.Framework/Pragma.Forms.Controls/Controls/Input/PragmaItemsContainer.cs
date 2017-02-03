﻿using Pragma.Core;
using Pragma.Forms.Controls.Abstraction;
using System;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls
{
    public partial class PragmaItemsContainer : PragmaDataGrid, IControl
    {

        public event EventHandler OnSetValue;
        public event EventHandler OnGetValue;

        public PragmaItemsContainer() : base()
        {

        }
        public bool Required { get; set; }

        public object _value;

        public object Value { get { OnGetValue?.Invoke(this, EventArgs.Empty); return _value; } set { OnSetValue?.Invoke(value, EventArgs.Empty); _value = value; } }
        public event EventHandler ValueChanged;

        public bool IsEmpty()
        {
            return Value == null;
        }

        public bool IsValid()
        {
            return true;
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title)
        {

        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {

        }

        public async Task<bool> ValidateAsync()
        {
            ValueChanged.Invoke(this, EventArgs.Empty);
            return await Task.FromResult(true);
        }
    }
}