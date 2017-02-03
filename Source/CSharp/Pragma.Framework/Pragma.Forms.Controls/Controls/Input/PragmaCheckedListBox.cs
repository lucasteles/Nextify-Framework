using Pragma.Abstraction.Forms.Controls;
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public partial class PragmaCheckedListBox : CheckedListBox, IControl
    {
        public PragmaCheckedListBox()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                Validator = new ControlValidator<PragmaCheckedListBox>(null);
            }
        }

        public IControlValidator<PragmaCheckedListBox> Validator { get; set; }

        public char DelimiterChar { get; set; } = ';';

        private bool _required;

        public event EventHandler ValueChanged;

        public bool Required { get { return _required; } set { _required = value; } }

        public object Value { get { return GetValue(); } set { SetValue(value); } }

        public bool IsEmpty()
        {
            return false;
        }

        public bool IsValid()
        {
            this.SetBgColor();
            return true;
        }

        public async Task<bool> ValidateAsync()
        {

            return await Task.FromResult(true);
        }

        public void ShowTootipMessage(string message, FailureSeverity severity, string title)
        {
            Validator.ShowTootipMessage(message, this, severity, title);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            Validator.ShowTootipMessage(message, this, severity, title, time);
        }
        public object GetValue()
        {
            return string.Join(DelimiterChar.ToString(), CheckedItems.Cast<string>().ToList());
        }
        public void SetValue(object value)
        {
            if (DesignMode)
                return;

            if (value == null)
                return;
            if (((string)value) == "")
                return;

            var list = ((string)value).Split(DelimiterChar);

            foreach (var item in list)
                SetItemChecked(Items.IndexOf(item), true);
        }

        public void CheckAll(bool tCheck)
        {
            var list = Items.Cast<string>().ToList();
            foreach (var item in list)
                SetItemChecked(Items.IndexOf(item), tCheck);
        }

        public void AddItems(IEnumerable<object> items, bool checkState = true)
        {
            foreach (var obj in items)
                AddItem(obj, checkState);
        }

        public void AddItem(object obj, bool checkState = true)
        {
            Items.Add(obj, checkState);
        }

        public IEnumerable<T> GetCheckedList<T>()
        {
            foreach (var item in CheckedItems)
                yield return (T)item;
        }

        private void PragmaCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ValueChanged?.Invoke(sender, e);
        }
    }
}
