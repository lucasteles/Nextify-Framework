using FakeItEasy;
using Pragma.App.Business;
using Pragma.App.DAO;
using Pragma.App.DAO.Repositories;
using Pragma.App.Model;
using Pragma.IOC;
using Pragma.Tests;
using System;
using System.Collections.Generic;
using Xunit;

namespace Pragma.App.Extensions.Tests
{
    public class DateTimeExtensionTest
    {
        public DateTimeExtensionTest()
        {
            var listferiados = new List<DbFeriado>
            {
                new DbFeriado {Id=1, Nome="Natal", DtFeriado = new DateTime(2015,12,25), Fixo = 1, FkPais = "BRA" }
            };

            var context = A.Fake<SysContext>();
            Aef.Configure(context, listferiados);

            var uow = A.Fake<IContainer>();

            var repo = new FeriadoRepository(context);
            var unit = new LocalizationUnitOfWork(context, e => repo);
            using (var feriadoBusiness = new FeriadoBusiness(unit))
            {
                A.CallTo(() =>
                    uow.Resolve<IFeriadoBusiness>())
                   .Returns(feriadoBusiness);
            }
            ContainerFactory.Container = uow;
        }
        [Fact(DisplayName = "[EXT] Deve indicar que a data é util.")]
        public void Extensions_Data_Dia_Util()
        {
            var util = new DateTime(2015, 12, 31).VDiaUtil();
            Assert.True(util, "Indicando como data não util.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar que a data não é util.")]
        public void Extensions_Data_Dia_Nao_Util()
        {
            var util = new DateTime(2015, 12, 27).VDiaUtil();
            Assert.False(util, "Indicando como data util.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar o numero 57 de dias uteis.")]
        public void Extensions_Data_Conta_Dia_Util()
        {
            var count = new DateTime(2015, 12, 27).ContaUteis(new DateTime(2016, 03, 15));
            Assert.True(count == 57, "Indicando o numero de dias uteis entre 27/12/2015 e 15/03/2016 errado.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 28/12/2015 como proximo dia util.")]
        public void Extensions_Data_Proximo_Dia_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxUtil(1);
            Assert.True(date == new DateTime(2015, 12, 28), "Indicando proxima data util errada.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 25/12/2015 como dia util anterior.")]
        public void Extensions_Data_Anterior_Dia_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxUtil(-1);
            Assert.True(date == new DateTime(2015, 12, 24), "Indicando data anterior util errada.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 31/12/2015 como proximo fechamento de mes.")]
        public void Extensions_Data_Proximo_Mes_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxMesUtil(1);
            Assert.True(date == new DateTime(2016, 01, 29), "Indicando ultimo dia util do proximo mes errado.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 30/11/2015 como fechamento de mes anterior.")]
        public void Extensions_Data_Anterior_Mes_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxMesUtil(-1);
            Assert.True(date == new DateTime(2015, 11, 30), "Indicando ultimo dia util do mes anterior errado.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 31/12/2016 como proximo fechamento de ano.")]
        public void Extensions_Data_Proximo_Ano_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxAnoUtil(1);
            Assert.True(date == new DateTime(2016, 12, 30), "Indicando ultimo dia util do proximo ano errado.");
        }
        [Fact(DisplayName = "[EXT] Deve indicar a data 31/12/2014 como fechamento de ano anterior.")]
        public void Extensions_Data_Anterior_Ano_Util()
        {
            var date = new DateTime(2015, 12, 27).ProxAnoUtil(-1);
            Assert.True(date == new DateTime(2014, 12, 31), "Indicando ultimo dia util do ano anterior errado.");
        }
    }
}
