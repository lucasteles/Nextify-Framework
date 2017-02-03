using Pragma.Core;
using Pragma.Core.Icons;
using Pragma.Files;
using Pragma.Forms.Controls.Abstraction;
using Pragma.Forms.Controls.Validations;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public partial class PragmaUploadFile : PragmaUserControl, IControl, IControlWithValidation<PragmaUploadFile>
    {
        IFileHelper ControlFile { get; set; } = new FileHelper();
        public IControlValidator<PragmaUploadFile> Validator { get; set; }

        /// <summary>
        /// Propriedade indica quais extensões da busca de arquivos
        /// </summary>
        [Description("Propriedade indica quais extensões da busca de arquivos")]
        public string Extensions { get { return txtPathFile.Extensions; } set { txtPathFile.Extensions = value; } }

        public object Value { get { return GetValue(); } set { SetValue(value); } }

        public event EventHandler ValueChanged;

        public bool Required
        {
            get { return txtPathFile.Required; }
            set { txtPathFile.Required = value; }
        }
        public PragmaUploadFile()
        {
            InitializeComponent();
            Validator = new ControlValidator<PragmaUploadFile>(new PragmaUploadFileValidation());

            txtPathFile.ValueChanged += txtPathFile_PgmValidAsync;
        }
        public object GetValue()
        {
            return ControlFile.GetBytes();
        }
        public void SetValue(object value)
        {
            if (value != null)
            {
                var content = (byte[])value;

                if (content.Length > 0)
                {
                    ControlFile.SetContent(content);
                    cmdDownloadFile.Enabled = true;
                    cmdDownloadFile.BackgroundImage = BaseIcons.download;
                    cmdRemoveFile.Enabled = true;
                    txtPathFile.Enabled = false;

                    ValueChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public void SetValuePath(object value)
        {
            ControlFile.Upload(value.ToString());
            SetValue(ControlFile.GetBytes());
        }
        public bool IsEmpty()
        {
            return ControlFile.IsEmpty();
        }
        private void cmdDownloadFile_Click(object sender, EventArgs e)
        {
            using (var Brower = new SaveFileDialog
            {
                Filter = Extensions
            })
            {
                Brower.ShowDialog();

                if (Brower.FileName != "")
                {
                    ControlFile.Download(Brower.FileName);
                }
            }
        }
        private void cmdRemoveFile_Click(object sender, EventArgs e)
        {
            ControlFile.Clear();
            cmdDownloadFile.Enabled = false;
            cmdDownloadFile.BackgroundImage = BaseIcons.upload;
            cmdRemoveFile.Enabled = false;
            txtPathFile.Enabled = true;
            txtPathFile.SetValue("");
        }
        private async void txtPathFile_PgmValidAsync(object sender, EventArgs e)
        {
            var valid = await txtPathFile.ValidateAsync();

            if (valid)
                SetValuePath(txtPathFile.GetValue());
        }

        public async Task<bool> ValidateAsync()
        {
            if (Validator == null)
                return true;

            return (await Validator.ValidateAsync(this)) && (await txtPathFile.ValidateAsync());
        }
        public bool IsValid()
        {
            return (Validator?.ValidState?.Success ?? true) && txtPathFile.IsValid();
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
