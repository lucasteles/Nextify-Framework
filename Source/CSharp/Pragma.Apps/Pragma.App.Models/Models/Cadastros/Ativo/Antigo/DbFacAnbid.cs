using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUFACANBID")]
    public class DbFacAnbid : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        public string Id { get; set; }

        [Column("DS_CLUBE")]
        public string DsClube { get; set; }

        [Column("NR_CNPJ")]
        public decimal? NrCnpj { get; set; }

        [Column("CD_ANBID")]
        public string CdAnbid { get; set; }

        [Column("CD_CETIP")]
        public string CdCetip { get; set; }

        [Column("NR_APLICCONV")]
        public int? NrAplicConv { get; set; }

        [Column("NR_RESGCONV")]
        public int? NrResgConv { get; set; }

        [Column("NR_LIQRESGATE")]
        public int? NrLiqResgate { get; set; }

        [Column("NR_CARENCIA")]
        public byte? NrCarencia { get; set; }

        [Column("NR_ANIVERSARIO")]
        public byte? NrAniversario { get; set; }

        [Column("FK_EMISSOR")]
        public string FkEmissor { get; set; }

        [Column("DS_EMAILGESTOR")]
        public string DsEmailGestor { get; set; }

        [Column("CD_ISIN")]
        public string CdIsin { get; set; }

        [Column("CD_BANCO_OLD")]
        public decimal? CdBancoOld { get; set; }

        [Column("CD_AGENCIA_OLD")]
        public decimal? CdAgenciaOld { get; set; }

        [Column("CD_CCORRENTE_OLD")]
        public string CdCCorrenteOld { get; set; }

        [Column("tg_Diasconv")]
        public string TgDiasConv { get; set; }

        [Column("DS_OBS")]
        public string DsObs { get; set; }

        [Column("VL_TXPER")]
        public decimal? VlTxPer { get; set; }

        [Column("VL_TXADM")]
        public decimal? VlTxAdm { get; set; }

        [Column("TG_ESTRANGEIRO")]
        public byte? TgEstrangeiro { get; set; }

        [Column("TG_DADOOFICIAL")]
        public byte? TgDadoOficial { get; set; }

        [Column("NR_RESGCONVDIG")]
        public int? NrResgConvDig { get; set; }

        [Column("NR_LIQRESGATEDIG")]
        public int? NrLiqResgateDig { get; set; }

        [Column("TG_DIASCONVDIG")]
        public string TgDiasConvDig { get; set; }

        [Column("FK_INDTXPER")]
        public string FkIndTxPer { get; set; }

        [Column("VL_INDTXPER")]
        public decimal? VlIndTxPer { get; set; }

        [Column("DS_OBSADM")]
        public string DsObsAdm { get; set; }

        [Column("DS_HORAFINAL")]
        public string DsHoraFinal { get; set; }

        [Column("FK_GESTOR")]
        public int? FkGestor { get; set; }

        [Column("CD_BANCO")]
        public decimal? CdBanco { get; set; }

        [Column("CD_AGENCIA")]
        public decimal? CdAgencia { get; set; }

        [Column("CD_CCORRENTE")]
        public string CdCcorrente { get; set; }

        [Column("CD_CCORRENTEDV")]
        public string CdCcorrenteDv { get; set; }

        [Column("TG_DIASCONVAPLIC")]
        public string TgDiasConvAplic { get; set; }

        [Column("TG_DIASCONVRESG")]
        public string TgDiasConvResg { get; set; }

        [Column("TG_DIASLIQAPLIC")]
        public string TgDiasLiqAplic { get; set; }
        [Column("DS_EMAILPASSIVO")]
        public string DsEmailpassivo { get; set; }

    }
}
