using System;

namespace Pragma.App.Service.FilePublicacao
{
    public class FiltroInvestimento
    {
        public int Id { get; set; }
        public string Investimento { get; set; }
        public DateTime DtDe { get; set; }
        public DateTime DtAte { get; set; }
        public string DataBase { get; set; }
    }
}