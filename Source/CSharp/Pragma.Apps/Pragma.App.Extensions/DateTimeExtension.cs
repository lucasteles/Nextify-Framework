using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.IOC;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pragma.App.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Guarda a lista de feriados para futuras consultas
        /// </summary>
        private static List<DbFeriado> HolyDays = new List<DbFeriado>();
        /// <summary>
        /// Verifica se a Data é útil
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tDate">Data que será verificada</param>
        /// <returns>Retorna True Se for útil e false para não útil</returns>
        public static bool VDiaUtil(this DateTime tDate)
        {
            return tDate.VDiaUtil("BRA");
        }
        /// <summary>
        /// Verifica se a Data é útil
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tDate">Data que será verificada</param>
        /// <param name="Pais">Código do pais</param>
        /// <returns>Retorna True Se for útil e false para não útil</returns>
        public static bool VDiaUtil(this DateTime tDate, string Pais)
        {
            var lUtil = false;

            // ignora finais de semana
            if (!(tDate.DayOfWeek == DayOfWeek.Saturday || tDate.DayOfWeek == DayOfWeek.Sunday))
            {
                // Na primeira chamada carrega todos os ferias e guarda para futuras consultas
                if (HolyDays.Count == 0)
                {
                    var business = ContainerFactory.Container.Resolve<IFeriadoBusiness>();

                    var list = business.Get();
                    HolyDays = list.ToList();
                }
                // busca o feriado só com o dia e o mês
                var oFer = HolyDays.Where(
                        f =>
                            f.DtFeriado.Day == tDate.Day
                        &&
                            f.DtFeriado.Month == tDate.Month
                        &&
                            (f.DtFeriado.Year == tDate.Year || f.Fixo == 2)
                        &&
                            f.FkPais == Pais
                        ).ToList();
                // se encontrar algum registro, então é feriado
                lUtil = oFer.Count == 0;
            }
            return lUtil;
        }
        /// <summary>
        /// Avança ou retorna n dias uteis apartir de uma data,
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tDays">Número de dias para avançar ou retornar</param>
        /// <param name="tDate">Data de referencia</param>
        /// <returns>Retorna a data encontrada</returns>
        public static DateTime ProxUtil(this DateTime? tDate, int tDays)
        {
            if (tDate == null)
                return DateTime.MinValue;

            var Date = (DateTime)tDate;

            return Date.ProxUtil(tDays, "BRA");
        }
        /// <summary>
        /// Avança ou retorna n dias uteis apartir de uma data,
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tDays">Número de dias para avançar ou retornar</param>
        /// <param name="tDate">todo: describe tDate parameter on ProxUtil</param>
        /// <returns>Retorna a data encontrada</returns>
        public static DateTime ProxUtil(this DateTime tDate, int tDays)
        {
            return tDate.ProxUtil(tDays, "BRA");
        }
        /// <summary>
        /// Avança ou retorna n dias uteis apartir de uma data,
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tDays">Número de dias para avançar ou retornar</param>
        /// <param name="Pais">Código do pais</param>
        /// <param name="tDate">todo: describe tDate parameter on ProxUtil</param>
        /// <returns>Retorna a data encontrada</returns>
        public static DateTime ProxUtil(this DateTime tDate, int tDays, string Pais)
        {
            var dUtil = tDate;
            var nCount = tDays;
            var nStep = tDays >= 0 ? 1 : -1; // verifica se precisa avançar ou retornar

            // Enquanto não zerar o numero de dias
            while (!(nCount == 0))
            {
                dUtil = dUtil.AddDays(nStep);
                // para cada dia util encontrado, subtrair um do contador
                if (dUtil.VDiaUtil(Pais))
                    nCount -= nStep;
            }
            return dUtil;
        }
        /// <summary>
        /// Retorna ou avança um numero de meses e calcula o ultimo dia util desse mes.
        /// </summary>
        /// <param name="tDate">Data atual</param>
        /// <param name="tMonth">Numero de meses</param>
        /// <returns>Data do ultimo dia util do mes encontrado</returns>
        public static DateTime ProxMesUtil(this DateTime tDate, int tMonth)
        {
            var Date = tDate.AddMonths(tMonth + 1);
            return new DateTime(Date.Year, Date.Month, 1).ProxUtil(-1); ;
        }
        /// <summary>
        /// Retorna ou avança um numero de meses e calcula o ultimo dia util desse mes.
        /// </summary>
        /// <param name="tDate">Data atual</param>
        /// <param name="tMonth">Numero de meses</param>
        /// <returns>Data do ultimo dia util do mes encontrado</returns>
        public static DateTime ProxMesUtil(this DateTime? tDate, int tMonth)
        {
            var Date = (DateTime)tDate;
            Date = Date.AddMonths(tMonth + 1);
            return new DateTime(Date.Year, Date.Month, 1).ProxUtil(-1); ;
        }
        /// <summary>
        /// Retorna ou avança um numero de anos e calcula o ultimo dia util desse ano.
        /// </summary>
        /// <param name="tDate">Data atual</param>
        /// <param name="tYear">Numero de Anos</param>
        /// <returns>Data do ultimo dia util do ano encontrado</returns>
        public static DateTime ProxAnoUtil(this DateTime tDate, int tYear)
        {
            var Date = tDate.AddYears(tYear + 1);
            return new DateTime(Date.Year, 1, 1).ProxUtil(-1); ;
        }
        /// <summary>
        /// Retorna ou avança um numero de anos e calcula o ultimo dia util desse ano.
        /// </summary>
        /// <param name="tDate">Data atual</param>
        /// <param name="tYear">Numero de Anos</param>
        /// <returns>Data do ultimo dia util do ano encontrado</returns>
        public static DateTime ProxAnoUtil(this DateTime? tDate, int tYear)
        {
            var Date = (DateTime)tDate;
            Date = Date.AddYears(tYear + 1);
            return new DateTime(Date.Year, 1, 1).ProxUtil(-1); ;
        }
        /// <summary>
        /// Conta quantos dias uteis existem até uma data,
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tAte">Data futura para fazer a contagem</param>
        /// <param name="tDate">Data de referencia</param>
        /// <returns>Retorna o numero de dias do periodo</returns>
        public static int ContaUteis(this DateTime tDate, DateTime tAte)
        {
            return tDate.ContaUteis(tAte, "BRA");
        }
        /// <summary>
        /// Conta quantos dias uteis existem até uma data,
        /// País padrão (BRA)
        /// </summary>
        /// <param name="tAte">Data futura para fazer a contagem</param>
        /// <param name="tDate">Data de referencia</param>
        /// <param name="tPais">Pais da deve considerar os feriados</param>
        /// <returns>Retorna o numero de dias do periodo</returns>
        public static int ContaUteis(this DateTime tDate, DateTime tAte, string tPais)
        {
            var nUteis = 0;
            var dData = tDate;
            // A data "Ate" não pode ser menor que a atual
            if (dData < tAte)
                // enquando não for igual
                while (dData != tAte)
                {
                    // adiciona um dia e verifica se é util
                    dData = dData.AddDays(1);
                    if (dData.VDiaUtil(tPais))
                        nUteis++;
                }
            return nUteis;
        }
    }
}
