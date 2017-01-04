using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCARTCONSCOTA")]
    public class DbPublicadoCotas : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_CARTCONS")]
        public int FkCartcons { get; set; }
        [ForeignKey(nameof(FkCartcons))]
        public virtual DbPublicadoIndice CartConsIndice { get; set; }

        [Column("FK_SETOR")]
        public int? FkSetor { get; set; }
        [ForeignKey(nameof(FkSetor))]
        public virtual DbAtivoClasse Setor { get; set; }

        [Column("TG_ATIVOESTRANG")]
        public int TgAtivoEstrang { get; set; }

        [Column("TG_DESCONSIDERAR")]
        public int TgDesconsiderar { get; set; }

        [Column("VL_COTACAO")]
        public decimal VlCotacao { get; set; }

        [Column("VL_PATRIMONIO")]
        public decimal VlPatrimonio { get; set; }

        [Column("VL_PATRORIGINAL")]
        public decimal VlPatrOriginal { get; set; }

        [Column("VL_PATRCALC")]
        public decimal VlPatrCalculo { get; set; }

        [Column("VL_PATRCALCANT")]
        public decimal? VlPatrCalculoAnt { get; set; }

        [Column("VL_MOVIMENTOANT")]
        public decimal VlMovimento { get; set; }

        [Column("VL_PRINCIPAL")]
        public decimal VlPrincipal { get; set; }

        [Column("VL_PRINCIPALANT")]
        public decimal? VlPrincipalAnt { get; set; }

        [Column("VL_MOVPRINCIPAL")]
        public decimal VlMovPrincipal { get; set; }

        [Column("DT_COTACAO")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime DtCotacao { get; set; }

        [Column("TG_LOCAL")]
        public byte TgLocal { get; set; }

        [Column("DS_NIVEL")]
        public string Nivel { get; set; }
        public int NrOrdemNivel = 0;

        [Column("DS_EXTRA")]
        public string TipoCota { get; set; }

        [Column("DT_INICIO")]
        public DateTime DtInicio { get; set; }

        [Column("TG_ATIVOBASE")]
        public decimal? AtivoBase { get; set; }

        [StringLength(12), Column("FK_ATIVO", TypeName = "varchar")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("DS_VENCIMENTO")]
        [PgmColumn(DisplayText = "Vencimento/Cód")]
        public string Vencimento { get; set; }

        [Column("CD_OPCAO")]
        public string CdOpcao { get; set; }

        [Column("VL_PORALOC8")]
        public decimal VlAlocacao { get; set; }

        [Column("TG_MOEDA")]
        public byte TgMoeda { get; set; }

        [Column("CD_INTERNOGESTOR")]
        public string InternoGestor { get; set; }

        [Column("FK_CLASSE")]
        public int FkClasse { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cód. Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Moeda { get; set; }

        [Column("FK_CONJUNTO")]
        public string FkConjunto { get; set; }

        [Column("VL_IMPOSTO")]
        public decimal VlImposto { get; set; }

        [Column("QT_COTA")]
        public decimal QtCotaAtivo { get; set; }

        [Column("VL_COTA")]
        public decimal VlCotaAtivo { get; set; }

        [Column("VL_IOF")]
        public decimal VlIOF { get; set; }

        [Column("VL_IRRF")]
        public decimal VlIRRF { get; set; }

        [Column("TG_FUNDOESTRANG")]
        public int FundoEstrang { get; set; }

        [Column("TG_NIVEL")]
        public decimal NivelAberturaAtivo { get; set; }

        public string GetNameNivel()
        {
            var NameNivel = "";

            switch (Nivel)
            {
                case "CONSOLIDADO":
                    if (TgLocal == 3)
                        NameNivel = "Consolidado";
                    NrOrdemNivel = 0;
                    break;

                case "DESCONSIDERARCONS":
                    if (TgDesconsiderar == 0)
                        NameNivel = "Considerados";
                    else
                        NameNivel = "Outros Ativos";

                    NrOrdemNivel = 2;
                    break;
                case "SETORCONS":
                    if (Setor != null)
                        NameNivel = Setor.DsClasse.Trim();
                    NrOrdemNivel = 4;
                    break;
                case "LOCAL":
                    if (TgLocal == 1)
                        NameNivel = "Local Cons";
                    else
                        NameNivel = "Internacional Cons";
                    NrOrdemNivel = 1;
                    break;
                case "DESCONSIDERAR":
                    if (TgDesconsiderar == 0)
                        NameNivel = "";
                    else
                        NameNivel = "Outros ";

                    if (TgLocal == 1)
                        NameNivel = "Local";
                    else
                        NameNivel = "Internacional";

                    NrOrdemNivel = 3;
                    break;
                case "SETOR":
                    if (Setor != null)
                        NameNivel = Setor.DsClasse.Trim();
                    NrOrdemNivel = 6;
                    break;
                case "ATIVO":
                    if (Ativo != null)
                        NameNivel = Ativo.Nome.Trim();
                    NrOrdemNivel = 9;
                    break;
            }

            return NameNivel;
        }
    }
}
