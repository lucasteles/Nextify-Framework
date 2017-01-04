using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pragma.App.Model
{
#if DEBUG
    [Table("VCLUUSUCLUBE")]
#else
    [Table("TCLUCLUBE")]
#endif
    public class DbInvestimento : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public decimal Id { get; set; }

        [PgmColumn(DisplayText = "Cód")]
        public string SId { get { return Id.ToString().PadLeft(4, '0'); } }

        [Column("FK_TIPOCLUBE")]
        [PgmColumn(DisplayText = "Tipo de Investimento")]
        public decimal FkTipoInvestimento { get; set; }
        [ForeignKey(nameof(FkTipoInvestimento))]
        public virtual DbInvestimentoTipo TipoInvestimento { get; set; }

        [Column("FK_CADUNICO")]
        [PgmColumn(DisplayText = "Cód. Cadunico")]
        public int FkCadunico { get; set; }
        [ForeignKey(nameof(FkCadunico))]
        public virtual DbCadunico Cadunico { get; set; }

        [Column("DS_FANTASIA")]
        [PgmColumn(DisplayText = "Investimento")]
        [PgmF4(Show = true)]
        public string Fantasia { get; set; }

        [Column("TG_ABERTO")]
        [PgmColumn(DisplayText = "Aberto")]
        public decimal Aberto { get; set; }

        [Column("DT_ULTFECH")]
        [PgmColumn(DisplayText = "Dt.Ult.Fech.")]
        public DateTime? DtUltFech { get; set; }

        [Column("DT_D0")]
        [PgmColumn(DisplayText = "Dt.D0")]
        public DateTime? DtD0 { get; set; }

        [Column("DT_INICIO")]
        [PgmColumn(DisplayText = "Dt.Inicio")]
        public DateTime? DtInicio { get; set; }

        [Column("DT_DESDE")]
        [PgmColumn(DisplayText = "Dt.Desde")]
        public DateTime? DtDesde { get; set; }

        [Column("DT_TERMINO")]
        [PgmColumn(DisplayText = "Dt.Termino")]
        public DateTime? DtTermino { get; set; }

        [Column("DT_PUBLICADO")]
        [PgmColumn(DisplayText = "Dt.Publicado")]
        public DateTime? DtPublicado { get; set; }

        [Column("NR_CNPJ")]
        [PgmColumn(DisplayText = "Nr.CNPJ")]
        public decimal NrCnpj { get; set; }

        [Column("DS_CLUBE")]
        [PgmColumn(DisplayText = "Nome do Investimento")]
        public string Nome { get; set; }

        [Column("TG_PROCESSAMENTO")]
        [PgmColumn(DisplayText = "Processado Gestor")]
        public decimal TgProcessadoGestor { get; set; }

        [Column("TG_ESTRANGEIRO")]
        [PgmColumn(DisplayText = "Internacional")]
        public byte TgInternacional { get; set; }

        [Column("TG_GERENCIAL")]
        [PgmColumn(DisplayText = "Gerencial")]
        public int? TgGerencial { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cód. Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Moeda { get; set; }

        [Column("FK_MANDATO")]
        [PgmColumn(DisplayText = "Cód. Mandato")]
        public string FkMandato { get; set; }
        [ForeignKey(nameof(FkMandato))]
        public virtual DbMandato Mandato { get; set; }

        [Column("FK_ORIGEM")]
        [PgmColumn(DisplayText = "Cód. Origem Externa")]
        public int FkOrigem { get; set; }
        [ForeignKey(nameof(FkOrigem))]
        public virtual DbOrigemExterna OrigemExterna { get; set; }

        [Column("FK_MOEDABASKET")]
        [PgmColumn(DisplayText = "Basket")]
        public string FkBasket { get; set; }

        [Column("CD_CARTEIRAEXT")]
        [PgmColumn(DisplayText = "Cód. Carteira Ext")]
        public string CdCarteiraExt { get; set; }

        [Column("CD_CARTEIRA")]
        [PgmColumn(DisplayText = "Cód. Carteira")]
        public string CdCarteira { get; set; }

        [Column("DS_RELATSAVE")]
        [PgmColumn(DisplayText = "Diretório dos Relatórios")]
        public string DiretorioRelat { get; set; }

        [Column("FK_INSTITUICAO")]
        [PgmColumn(DisplayText = "Cód. Administrador")]
        public decimal? FkAdministrador { get; set; }

        [Column("DS_CLUBES")]
        [PgmColumn(DisplayText = "Investimentos que formam o grupo")]
        public string InvestimentosGrupo { get; set; }
        public ICollection<decimal> ListGrupos
        {
            get
            {
                var list = InvestimentosGrupo.Trim().Split(',')
                    .Where(i => i != "").Select(decimal.Parse).ToList();

                if (list.Count == 0)
                    list.Add(Id);

                return list;
            }
        }

        [Column("DS_RELATINVEST")]
        [PgmColumn(DisplayText = "Investimentos Relacionados")]
        public string InvestimentosRelacionados { get; set; }
        public ICollection<decimal> ListGruposRelacionados
        {
            get
            {
                var list = InvestimentosRelacionados.Trim().Split(',')
                    .Where(i => i != "").Select(decimal.Parse).ToList();

                if (list.Count == 0)
                    list.Add(Id);

                return list;
            }
        }

    }
}