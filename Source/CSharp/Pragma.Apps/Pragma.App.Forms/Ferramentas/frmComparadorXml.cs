using PGM.Xml.Tools.Anbima4;
using Pragma.App.Forms.Controllers.Grids;
using Pragma.Core;
using Pragma.Forms.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Pragma.Forms
{
    public partial class frmComparadorXml : FormBase
    {
        string Caminho { get; set; } = @"P:\12. sistema\12.5. IMPORTACAO\ITAU_DOWN_ATIVO\";
        ComparadorAnbima4 Comparador { get; set; } = new ComparadorAnbima4();
        readonly IXMLFilesGridController Controller;
        public frmComparadorXml(IXMLFilesGridController controller)
        {
            InitializeComponent();
            Controller = controller;

            txtRaiz.SetValue(Caminho);
            txtOld.SetValue(Caminho + @"\OLD");
            txtDuplicado.SetValue(Caminho + @"\DUPLICADOS");
        }
        public async override Task FormLoadAsync()
        {
            Controller.SetComparador(Comparador);
            await Controller.UseAsync(Grid);
        }
        private async void cmdComparar_ClickAsync(object sender, EventArgs e)
        {
            var ok = await ValidateAsync();
            if (!ok)
                return;

            Comparador.PathRaiz = txtRaiz.GetDirectory();
            Comparador.PathOld = txtOld.GetDirectory();
            Comparador.PathDest = txtDuplicado.GetDirectory();

            await RunWithLoadAsync(CompararAsync, "Comparando...", cmdComparar);
        }
        public async Task CompararAsync()
        {
            Comparador.Comparacao();
            await Controller.RefreshAsync();
            ShowMessage("Comparação concluída!");
        }
    }
}
