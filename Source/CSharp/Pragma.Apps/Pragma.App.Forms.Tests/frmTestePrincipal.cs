using Pragma.Core.Icons;
using Pragma.Forms;
using Pragma.Forms.Controls.Forms;
using Pragma.Forms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pragma.App.Forms.Tests
{
    public partial class frmTestePrincipal : FormBase
    {
        public frmTestePrincipal()
        {
            InitializeComponent();
            var listconexoes = new List<string>();
            listconexoes.Add("Homolog1Connection");
            listconexoes.Add("OficialConnection");
            listconexoes.Add("Homolog2Connection");
            listconexoes.Add("Homolog3Connection");

            //Menu Estático
            var menuList = new List<PragmaMenuItem>();
            menuList.Add(new PragmaMenuItem
            {
                Name = "PGM Sistema",
                Icon = Weather.rain,
                ButtonAction = () =>
                {
                    var form = IOC.ContainerFactory.Container.Resolve<frmPrincipal>();
                    if (form != null && form.OK)
                        form.Show();
                }
            });
            var ariel = new PragmaMenuItem
            {
                Name = "Ariel",
                Icon = Weather.rain,
            };
            var mendonca = new PragmaMenuItem
            {
                Name = "Mendonça",
                Icon = Weather.rain,
            };
            var diogo = new PragmaMenuItem
            {
                Name = "Diogo",
                Icon = Weather.rain,
            };
            var naka = new PragmaMenuItem
            {
                Name = "Naka",
                Icon = Weather.rain,
            };
            var fernando = new PragmaMenuItem
            {
                Name = "Fernando",
                Icon = Weather.rain,
            };
            menuList.Add(ariel);
            menuList.Add(mendonca);
            menuList.Add(diogo);
            menuList.Add(naka);
            menuList.Add(fernando);

            //ariel.MenusFilhos.Add(new MenuItem()
            //{
            //    Name = "Evernote",
            //    Icon = Weather.rain,
            //    Form = typeof(frmEvernoteConsult).FullName
            //});
            //ariel.MenusFilhos.Add(new MenuItem
            //{
            //    Name = "Teste Validação",
            //    Icon = Weather.rain,
            //    Classe = typeof(TesteValidacao).FullName
            //});
            //ariel.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Conversor XML 5.0",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(frmParserXML5).Assembly.FullName,
            //    Classe = typeof(frmParserXML5).FullName
            //});
            //ariel.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Conversão de Moeda",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 1,
            //    Namespace = typeof(TesteConvesaoMoeda).Assembly.FullName,
            //    Classe = typeof(TesteConvesaoMoeda).FullName
            //});
            //fernando.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Conferência Geral",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(frmGerenciador).Assembly.FullName,
            //    Classe = typeof(frmGerenciador).FullName
            //});
            //fernando.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Ajuste de Conferencia",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(frmConferenciaAjusteConsult).Assembly.FullName,
            //    Classe = typeof(frmConferenciaAjusteConsult).FullName
            //});
            //fernando.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Cota Oficial",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 3,
            //    Namespace = typeof(frmCotaOficialConsult).Assembly.FullName,
            //    Classe = typeof(frmCotaOficialConsult).FullName
            //});
            //fernando.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Importação de Mov. Gerencial (XLSX)",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 4,
            //    Namespace = typeof(frmImportacaoMovGerencialXLSX).Assembly.FullName,
            //    Classe = typeof(frmImportacaoMovGerencialXLSX).FullName
            //});

            //fernando.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Conciliação Gerencial",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 4,
            //    Namespace = typeof(frmGerenciais).Assembly.FullName,
            //    Classe = typeof(frmGerenciais).FullName
            //});

            //ariel.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Cad. Conferências",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 5,
            //    Namespace = typeof(frmConferenciaConsulta).Assembly.FullName,
            //    Classe = typeof(frmConferenciaConsulta).FullName
            //});

            //ariel.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Teste Boleta",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 6,
            //    Namespace = typeof(Form2).Assembly.FullName,
            //    Classe = typeof(Form2).FullName
            //});

            //ariel.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Feriados",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 7,
            //    Namespace = typeof(frmFeriadosMining).Assembly.FullName,
            //    Classe = typeof(frmFeriadosMining).FullName
            //});
            mendonca.ChildMenus.Add(new PragmaMenuItem()
            {
                Name = "Comparador XML",
                Icon = Weather.rain,
                Order = 0,
                ButtonAction = () =>
                {
                    var form = IOC.ContainerFactory.Container.Resolve<frmComparadorXml>();
                    form.Show();
                }
            });
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Movimentação Status",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(frmMovimentoStatusConsult).Assembly.FullName,
            //    Classe = typeof(frmMovimentoStatusConsult).FullName
            //});
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Movimentação",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(frmMovimentoConsult).Assembly.FullName,
            //    Classe = typeof(frmMovimentoConsult).FullName
            //});
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Teste Controls",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(FormTestControls).Assembly.FullName,
            //    Classe = typeof(FormTestControls).FullName
            //});
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "PowerPoint",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Namespace = typeof(PowerPointTeste).Assembly.FullName,
            //    Classe = typeof(PowerPointTeste).FullName
            //});
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Siscalc",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 1,
            //    Namespace = typeof(PrincipalTest).Assembly.FullName,
            //    Classe = typeof(PrincipalTest).FullName
            //});
            //mendonca.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Json",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 1,
            //    Namespace = typeof(JsonTeste).Assembly.FullName,
            //    Classe = typeof(JsonTeste).FullName
            //});

            //diogo.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Teste FormConsult",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 1,
            //    Namespace = typeof(FormConsultTeste).Assembly.FullName,
            //    Classe = typeof(FormConsultTeste).FullName
            //});

            //naka.MenusFilhos.Add(new DbMenu
            //{
            //    Name = "Teste",
            //    Icon = "tornado",
            //    ClasseDoIcon = "PGM.Common.Icons.Weather",
            //    Ordem = 1,
            //    Namespace = typeof(nakaform).Assembly.FullName,
            //    Classe = typeof(nakaform).FullName
            //});

            pgmMenu1.SetMenus(menuList);
        }

        //private void AddSubMenus(IMenuItem menuPai, List<MenuItem> menus)
        //{
        //    foreach (var menu in menus.OrderBy(i => i.Ordem))
        //    {
        //        var menuItem = new PragmaMenuItemControl(menu, this);

        //        menuPai.AddItem(menuItem);
        //        AddSubMenus(menuItem, (List<MenuItem>)menu.MenusFilhos);

        //        //Menu Estático
        //        if (menu.Classe == typeof(frmLogin).FullName) menuItem.ButtonAction = () => cmdPGMSistema_Click(null, null);
        //    }
        //}

        //private void cmdPGMSistema_Click(object sender, EventArgs e)
        //{
        //    var form = DI.Resolve<frmLogin>();
        //    form.Show(this);
        //}

        private void MDIParent_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) Close();
        }

        private void OpenForm(Type type)
        {
            var form = (Form)IOC.ContainerFactory.Container.Resolve(type);
            if (form != null)
                form.Show();
        }
    }
}
