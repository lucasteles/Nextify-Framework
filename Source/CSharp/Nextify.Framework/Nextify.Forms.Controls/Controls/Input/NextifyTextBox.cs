using MetroFramework.Controls;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Core;
using Nextify.Forms.Controls.Validations;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
{
    public partial class NextifyTextBox : MetroTextBox, IControl, IControlWithValidation<NextifyTextBox>
    {
        public NextifyTextBox()
        {
            InitializeComponent();
            
            Configure();
        }

        #region Configuracao
        private static bool IsDecimalNumber(Type type) => type == typeof(decimal) || type == typeof(double) || type == typeof(float);
        private static bool IsInt(Type type) => type == typeof(int) || type == typeof(long);
        private static bool IsNumber(Type type) => IsInt(type) || IsDecimalNumber(type);
        private void Configure()
        {
            if (!DesignMode)
                Validator = new ControlValidator<NextifyTextBox>(new NextifyTextBoxValidation());

            this.SetBgColor();
        }
        #endregion

        #region Propriedades
        public IControlValidator<NextifyTextBox> Validator { get; set; }

        [Description("Numero de casas decimais.")]
        public int QtdDecimais { get; set; } = 2;
        [Description("Mascara de formatação.")]
        public string Mask { get; set; } = string.Empty;
        [Description("True para remover a mascara do value.")]
        public bool RemoveMaskOnGetValue { get; set; } = true;
        [Description("Quando numero, exibe a textbox vazia se o value for zero.")]
        public bool BlankIfZero { get; set; } = true;

        [Description("Indica que o campo é obrigatorio.")]
        private bool _required;
        public bool Required { get { return _required; } set { _required = value; this.SetBgColor(); } }

        public event EventHandler ValueChanged;
        protected object _Value;
        protected Type _ValueType;
        public object Value
        {
            get { return GetValue(); }
            set { SetValue(value); }
        }
        #endregion

        #region Metodos
        private object GetValue()
        {
            if (_Value == null || DesignMode)
            {
                _Value = string.Empty;
                _ValueType = typeof(string);
            }

            if (IsInt(_ValueType))
            {
                int value;
                _Value = int.TryParse(Text, out value) ? value : 0;

                if (value == 0)
                    Text = string.Empty;
            }

            if (IsDecimalNumber(_ValueType))
            {
                var text = new string(Text.Where(c => char.IsDigit(c) || c == ',' || c == '-').ToArray());
                var converter = TypeDescriptor.GetConverter( _ValueType );
                
                _Value = converter.ConvertFrom(text);
            }

            if (_Value.GetType() == typeof(DateTime))
            {
                var aux = new DateTime();
                if (DateTime.TryParse(Text, out aux))
                    _Value = aux;
            }
            if (_Value.GetType() == typeof(string))
            {
                if (!string.IsNullOrEmpty(Mask) && RemoveMaskOnGetValue)
                {
                    return new string(Text.Where(c => char.IsDigit(c)).ToArray());
                }
                else
                    _Value = Text;
            }
            return _Value;
        }
        private void SetValue(object value)
        {
            if (DesignMode)
                return;

            if (value != null)
            {
                if (IsInt(value.GetType()))
                    _Value = value;

                if (value?.ToString() == "0" && BlankIfZero && IsNumber(value.GetType()))
                    Text = string.Empty;
                else if (!Text.Equals(value.ToString()))
                {
                    Text = Mask == string.Empty ? value.ToString() : MaskValue(value);
                }

                if (IsDecimalNumber(value.GetType()) && Text.Contains(","))
                {
                    var splitText = Text.Split(',');

                    if (splitText[1].Length > QtdDecimais && QtdDecimais > 0)
                        Text = $"{splitText[0]},{splitText[1].Substring(0, QtdDecimais)}";

                    FormatNumber();
                }
            }

            if (_ValueType == typeof(DateTime))
                throw new Exception("You cant use this control for datetime!");

            _ValueType = value?.GetType();
            _Value = value;
        }
        private string MaskValue(object objvalue)
        {
            var value = objvalue.ToString();
            if (!string.IsNullOrEmpty(Mask))
            {
                using (var mtb = new MaskedTextBox())
                {
                    mtb.Text = value;
                    return mtb.Text;
                }
            }
            return value;
        }
        public bool IsEmpty()
        {
            if (IsInt(_ValueType))
                return ((int)_Value) == 0;

            if (IsDecimalNumber(_ValueType))
                return ((double)_Value) == 0d;

            if (_ValueType == typeof(string))
                return ((string)_Value) == string.Empty;

            return false;
        }
        private void AdjustCursorPosition()
        {
            var txtLength = Text.TrimEnd(' ').Length;
            if (SelectionStart > txtLength)
            {
                SelectionStart = txtLength;
                SelectionLength = 0;
            }
            else
                SelectionLength = SelectionLength + SelectionStart > txtLength ? txtLength - SelectionStart : SelectionLength;
        }
        public void FormatNumber()
        {
            var currentPos = SelectionStart;
            SelectionLength = 0;

            var qtdPoints = Text.Count(x => x == '.');
            var qtdNewDots = 0;
            var newText = string.Empty;

            var isNegative = Text.Contains("-");

            var decimalPart = string.Empty;
            string baseText;

            if (Text.Contains(","))
            {
                decimalPart = Text.Split(',')[1];
                baseText = Text.Split(',')[0];
            }
            else
                baseText = Text;

            if (isNegative)
                baseText = baseText.Replace("-", string.Empty);

            baseText = new string(baseText.Replace(".", "").Reverse().ToArray());
            var builder = new System.Text.StringBuilder();
            builder.Append(newText);

            for (int i = 0; i < baseText.Length; i++)
            {
                if (i % 3 == 0 && i > 0)
                {
                    builder.Append(".");
                    qtdNewDots++;

                }
                builder.Append(baseText[i]);
            }
            newText = builder.ToString();

            newText = new string(newText.Reverse().ToArray());

            if (Text.Contains(","))
                newText += "," + decimalPart;

            Text = (isNegative ? "-" : string.Empty) + newText;

            var pos = currentPos + qtdNewDots - qtdPoints;
            if (pos > 0)
                SelectionStart = currentPos + qtdNewDots - qtdPoints;
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
        public void TypeValidation()
        {
            if (_Value == null)
                return;

            if (_Value.GetType() == typeof(int) || _Value.GetType() == typeof(long))
            {
                long num;
                long.TryParse(Text, out num);

                if (num == 0)
                    Text = "";
            }

            if (_Value.GetType() == typeof(decimal) || _Value.GetType() == typeof(double) || _Value.GetType() == typeof(float))
            {
                decimal num;
                decimal.TryParse(Text, out num);



                Text = num == 0 ? "" : num.ToString("#,0." + (new string('0', QtdDecimais)) + "#;-#,0." + (new string('0', QtdDecimais)) + "#").Trim();

                if (Text.Contains(","))
                {
                    var qtdEfetiveDecimals = Text.Substring(Text.IndexOf(",") + 1).Length;
                    if (qtdEfetiveDecimals > QtdDecimais && QtdDecimais > 0)
                        Text = Text.Substring(0, Text.Length - (qtdEfetiveDecimals - QtdDecimais));
                }
            }
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
        private void __Enter(object sender, EventArgs e)
        {
            SelectionStart = 0;
            SelectionLength = Text.Trim().Length;
            Validator.ClearMessage(this);
        }
        private void __Leave(object sender, EventArgs e)
        {
            if (IsDecimalNumber(_ValueType))
            {
                if (QtdDecimais == 0)
                {
                    Text = Text.Replace(",", string.Empty);
                    return;
                }
                if (!Text.Contains(","))
                    Text = $"{Text},{new string('0', QtdDecimais)}";
                else if (Text.Split(',')[1].Length < QtdDecimais)
                    Text += new string('0', QtdDecimais - Text.Split(',')[1].Length);
            }

        }
        private void __EnabledChanged(object sender, EventArgs e)
        {
            this.SetBgColor();
        }
        private void __MouseDown(object sender, MouseEventArgs e)
        {
            AdjustCursorPosition();
        }
        private void __MouseClick(object sender, MouseEventArgs e)
        {
            AdjustCursorPosition();
        }
        private void __KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DesignMode)
                return;

            if (_Value == null)
            {
                _Value = string.Empty;
                _ValueType = typeof(string);
            }

            if (IsDecimalNumber(_ValueType))
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && ((int)e.KeyChar) != 8)
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',' && Text.IndexOf(',') > 0) || (e.KeyChar == '-' && Text.IndexOf('-') >= 0) || (e.KeyChar == '-' && this.SelectionStart != 0 && Text.IndexOf('-') < 0))
                    e.Handled = true;

                if (Text.Contains(",") && Text.Split(',')[1].Length >= QtdDecimais && ((int)e.KeyChar) != 8 && SelectionLength != Text.Length && SelectionStart > Text.IndexOf(","))
                {
                    var pos = SelectionStart;
                    if (pos < Text.Length)
                    {
                        Text = Text.Remove(pos, 1);
                        Text = Text.Insert(pos, e.KeyChar.ToString());
                        SelectionStart = pos == Text.Length ? pos : pos + 1;
                    }
                    e.Handled = true;
                }

                if (SelectionStart < Text.Length - 1 && Text[SelectionStart + 1] == ',' && SelectionStart > 0)
                    SelectionStart--;

            }
            else if (IsInt(_ValueType))
                if (!char.IsDigit(e.KeyChar) && ((int)e.KeyChar) != 8)
                    e.Handled = true;
        }
        private void __TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            if (Mask != string.Empty)
            {
                var currentPos = SelectionStart;
                SelectionLength = 0;
                var maskedText = MaskValue(Text);

                while (currentPos > 0 &&
                    currentPos < maskedText.Length &&
                    maskedText[currentPos] != ' ' &&
                    maskedText[currentPos] != ',' &&
                    maskedText[currentPos] != '-' &&
                    !char.IsDigit(maskedText[currentPos - 1])
                 )
                    currentPos++;

                Text = maskedText;
                SelectionStart = currentPos;
            }

            if (IsDecimalNumber(_ValueType))
                FormatNumber();

            GetValue();
            ValueChanged?.Invoke(sender, e);
        }
        #endregion
    }
}
