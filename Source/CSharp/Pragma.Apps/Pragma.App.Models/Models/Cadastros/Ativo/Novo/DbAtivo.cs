
using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCADATIVO")]
    public class DbAtivo : BaseModel, IModelWithKey<string>
    {
        [Key, StringLength(12), Column("PK_ID", TypeName = "varchar")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; } = "";

        [Column("FK_TIPOATIVO")]
        [PgmColumn(DisplayText = "Cód Tipo Ativo")]
        public int FkTipoAtivo { get; set; }
        [ForeignKey(nameof(FkTipoAtivo))]
        public virtual DbAtivoTipo TipoAtivo { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Ativo")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("DS_APELIDO")]
        [PgmColumn(DisplayText = "Apelido")]
        public string Apelido { get; set; }

        [Column("DT_VENCIMENTO")]
        [PgmColumn(DisplayText = "Dt. Vencimento")]
        public DateTime? DtVencimento { get; set; }

        [Column("NR_CNPJ")]
        [PgmColumn(DisplayText = "CNPJ")]
        public string NrCnpj { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cod. Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Moeda { get; set; }

        [Column("FK_BANCO")]
        [PgmColumn(DisplayText = "Cod. Banco")]
        public int FkBanco { get; set; }
        [ForeignKey(nameof(FkBanco))]
        public virtual DbEmpresaInstituicao Banco { get; set; }

        [Column("FK_ADMINISTRATOR")]
        [PgmColumn(DisplayText = "Cod. Administrator")]
        public int FkAdministrator { get; set; }
        [ForeignKey(nameof(FkAdministrator))]
        public virtual DbEmpresaInstituicao Administrator { get; set; }

        [Column("FK_CUSTODIANTE")]
        [PgmColumn(DisplayText = "Cod. Custodiante")]
        public int FkCustodiante { get; set; }
        [ForeignKey(nameof(FkCustodiante))]
        public virtual DbEmpresaInstituicao Custodiante { get; set; }

        [Column("FK_EMISSOR")]
        [PgmColumn(DisplayText = "Cod. Emissor")]
        public int FkEmissor { get; set; }
        [ForeignKey(nameof(FkEmissor))]
        public virtual DbEmpresaInstituicao Emissor { get; set; }

        [Column("FK_GESTOR")]
        [PgmColumn(DisplayText = "Cod. Gestor")]
        public int FkGestor { get; set; }
        [ForeignKey(nameof(FkGestor))]
        public virtual DbEmpresaInstituicao Gestor { get; set; }

        [Column("FK_REGIAO")]
        [PgmColumn(DisplayText = "Cod. Regiao")]
        public int FkRegiao { get; set; }
        [ForeignKey(nameof(FkRegiao))]
        public virtual DbAtivoRegiao Regiao { get; set; }

        [Column("FK_SEPARACAO")]
        [PgmColumn(DisplayText = "Cod. Separacao")]
        public int FkSeparacao { get; set; }
        [ForeignKey(nameof(FkSeparacao))]
        public virtual DbAtivoSeparacao Separacao { get; set; }

        [Column("FK_CLASSE")]
        [PgmColumn(DisplayText = "Cod. Classe")]
        public int FkClasse { get; set; }
        [ForeignKey(nameof(FkClasse))]
        public virtual DbAtivoClasse Classe { get; set; }

        [Column("FK_SUBCLASSE")]
        [PgmColumn(DisplayText = "Cod. Sub.Classe")]
        public int FkSubClasse { get; set; }
        [ForeignKey(nameof(FkSubClasse))]
        public virtual DbAtivoSubClasse SubClasse { get; set; }

        [Column("FK_CONJUNTO")]
        [PgmColumn(DisplayText = "Cod. Conjunto")]
        public string FkConjunto { get; set; }
        [ForeignKey(nameof(FkConjunto))]
        public virtual DbAtivoConjunto Conjunto { get; set; }

        [Column("TG_NAOCALCRENTAB")]
        [PgmColumn(DisplayText = "Não Calc.Rentab")]
        public bool TgNaoCalcRentab { get; set; }

        [Column("TG_CAIXA")]
        [PgmColumn(DisplayText = "Caixa")]
        public bool TgCaixa { get; set; }

        [Column("TG_GERARCOTACAO")]
        [PgmColumn(DisplayText = "Gerar Cotação")]
        public bool TgGerarCotacao { get; set; }

        [Column("FK_INDICEBASE")]
        [PgmColumn(DisplayText = "Indice Base")]
        public string FkIndiceBase { get; set; }
        [ForeignKey(nameof(FkIndiceBase))]
        public virtual DbIndice IndiceBase { get; set; }

        [Column("VL_PORINDICEBASE")]
        [PgmColumn(DisplayText = "% Indice Base")]
        public decimal VlPorIndiceBase { get; set; }

        [Column("VL_FATORBRUTO")]
        [PgmColumn(DisplayText = "Fator Bruto")]
        public decimal VlFatorBruto { get; set; }

        [Column("CD_ISIN")]
        [PgmColumn(DisplayText = "Isin")]
        public string CdIsin { get; set; }

        [Column("CD_ANBID")]
        [PgmColumn(DisplayText = "Anbid")]
        public string CdAnbid { get; set; }

        [Column("CD_CETIP")]
        [PgmColumn(DisplayText = "Cetip")]
        public string CdCetip { get; set; }

        [Column("CD_BLOOMBERG")]
        [PgmColumn(DisplayText = "Bloomberg")]
        public string CdBloomberg { get; set; }

        [Column("TP_CODBLOOMBERG")]
        [PgmColumn(DisplayText = "Tipo Cod. Bloomberg")]
        public decimal TpBloomberg { get; set; }

        [Column("NR_RESGATE")]
        [PgmColumn(DisplayText = "Nr. Dias Resgate")]
        public decimal NrResgate { get; set; }

        [Column("VL_PORLIQUIDADORESGATE")]
        [PgmColumn(DisplayText = "% Liquidação Resgate")]
        public decimal VlPorLiquidadoResgate { get; set; }

        [Column("DH_LIMITEMOVTO")]
        [PgmColumn(DisplayText = "Hora Limite Movto")]
        public DateTime? HoraLimiteMovto { get; set; }

        [Column("DH_LIMITEOFICIAL")]
        [PgmColumn(DisplayText = "Hora Limite Oficial")]
        public DateTime? HoraLimiteOficial { get; set; }

        [Column("DS_MSGALERTA")]
        [PgmColumn(DisplayText = "Msg Alerta")]
        public string MsgAlerta { get; set; }

    }
}
