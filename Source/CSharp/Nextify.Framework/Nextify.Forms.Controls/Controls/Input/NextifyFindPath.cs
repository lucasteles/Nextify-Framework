using Nextify.Abstraction.Forms.Controls;
using Nextify.Core;

using Nextify.Forms.Controls.Validations;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
{
    public enum BrowserType
    {
        Directories,
        OpenFiles,
        SaveFiles
    }
    public partial class NextifyFindPath : NextifyUserControl, IControl, IControlWithValidation<NextifyFindPath>
    {
        /// <summary>
        /// Propriedade indica quais extensões da busca de arquivos
        /// </summary>
        [Description("Propriedade indica quais extensões da busca de arquivos")]
        public string Extensions { get; set; }
        /// <summary>
        /// Propriedade se a busca é por diretórios ou arquivos
        /// </summary>
        [Description("Propriedade se a busca é por diretórios ou arquivos")]
        public BrowserType SearchType { get; set; }

        public bool Required
        {
            get { return txtFind.Required; }
            set { txtFind.Required = value; }
        }
        public object Value { get { return GetValue(); } set { SetValue(value); } }
        public IControlValidator<NextifyFindPath> Validator { get; set; }

        public NextifyFindPath()
        {
            SearchType = BrowserType.Directories;
            Extensions = "All Files|*.*";
            Validator = new ControlValidator<NextifyFindPath>(new NextifyFindPathValidation());
            InitializeComponent();
        }

        public event EventHandler ValueChanged;

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (SearchType == BrowserType.Directories)
                FindDirectory();
            else
                FindFile();

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Metodos

        private void FindFile()
        {
            FileDialog Browser;
            //Get Browser type
            using (
            //Get Browser type
            Browser = SearchType == BrowserType.OpenFiles ? (FileDialog)new OpenFileDialog() : new SaveFileDialog())
            {

                //Extensões do browser
                Browser.Filter = Extensions;
                //Apresentar
                Browser.ShowDialog();

                //Set valor do textbox
                if (Browser.FileName != "")
                    SetValue(Browser.FileName);
            }
        }
        /// <summary>
        /// Abre a tela de busca de Diretórios.
        /// </summary>
        private void FindDirectory()
        {
            using (var Browser = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            })
            {
                Browser.ShowDialog();

                if (Browser.SelectedPath != "")
                {
                    var Dir = new DirectoryInfo(Browser.SelectedPath);
                    SetValue(Browser.SelectedPath);
                }
            }
        }
        /// <summary>
        /// Retorna o Arquivo selecionado.
        /// </summary>
        /// <returns>O Arquivo selecionado.</returns>
        public FileInfo GetFile()
        {
            return new FileInfo(txtFind.Text);
        }
        /// <summary>
        /// Retorna o Diretório selecionado.
        /// </summary>
        /// <returns>O Diretório selecionado.</returns>
        public DirectoryInfo GetDirectory()
        {
            return new DirectoryInfo(txtFind.Text);
        }

        public void SetValue(object tText)
        {
            txtFind.Value = tText;
        }

        public object GetValue()
        {
            return txtFind.Value;
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title)
        {
            txtFind.ShowTootipMessage(message, severity, title);
        }
        public void ShowTootipMessage(string message, FailureSeverity severity, string title, int time)
        {
            txtFind.ShowTootipMessage(message, severity, title, time);
        }
        public bool IsEmpty()
        {
            return txtFind.IsEmpty();
        }
        public async Task<bool> ValidateAsync()
        {
            if (Validator == null)
                return true;

            return await txtFind.ValidateAsync() && await Validator.ValidateAsync(this, txtFind);
        }
        public bool IsValid()
        {
            return (Validator?.ValidState?.Success ?? true) && txtFind.IsValid();
        }
        #endregion

        private async void txtFind_ValidatingAsync(object sender, CancelEventArgs e)
        {
            await ValidateAsync();
        }
    }
}
