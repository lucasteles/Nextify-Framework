using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima5
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Account11
    {
        public PartyIdentification49Choice acctSvcrField;
        public AccountIdentification1 idField;
        /// <remarks/>
        public PartyIdentification49Choice AcctSvcr
        {
            get
            {
                return this.acctSvcrField;
            }
            set
            {
                this.acctSvcrField = value;
            }
        }
        /// <remarks/>
        public AccountIdentification1 Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class AccountIdentification1
    {
        public SimpleIdentificationInformation prtryField;
        /// <remarks/>
        public SimpleIdentificationInformation Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class ActiveOrHistoricCurrencyAnd13DecimalAmount
    {
        public string ccyField;
        public string valueField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class ActiveOrHistoricCurrencyAndAmount
    {
        public string ccyField;
        public string valueField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class AdditionalBalanceInformation6
    {
        public SubBalanceQuantity3Choice qtyField;
        public string subBalAddtlDtlsField;
        public SubBalanceType6Choice subBalTpField;
        /// <remarks/>
        public SubBalanceQuantity3Choice Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
        /// <remarks/>
        public string SubBalAddtlDtls
        {
            get
            {
                return this.subBalAddtlDtlsField;
            }
            set
            {
                this.subBalAddtlDtlsField = value;
            }
        }
        /// <remarks/>
        public SubBalanceType6Choice SubBalTp
        {
            get
            {
                return this.subBalTpField;
            }
            set
            {
                this.subBalTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class AddressType
    {
        public string bldgNbField;
        public string ctryField;
        public string ctrySubDvsnField;
        public string flrField;
        public string pstCdField;
        public string strtNmField;
        public string twnNmField;
        /// <remarks/>
        public string BldgNb
        {
            get
            {
                return this.bldgNbField;
            }
            set
            {
                this.bldgNbField = value;
            }
        }
        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }
        /// <remarks/>
        public string CtrySubDvsn
        {
            get
            {
                return this.ctrySubDvsnField;
            }
            set
            {
                this.ctrySubDvsnField = value;
            }
        }
        /// <remarks/>
        public string Flr
        {
            get
            {
                return this.flrField;
            }
            set
            {
                this.flrField = value;
            }
        }
        /// <remarks/>
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }
        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }
        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class AggregateBalanceInformation13
    {
        public BalanceAmounts1 acctBaseCcyAmtsField;
        public AdditionalBalanceInformation6[] addtlBalBrkdwnField;
        public DerivativeBasicAttributes1 addtlDerivAttrbtsField;
        public Balance1 aggtBalField;
        public BalanceAmounts1 altrnRptgCcyAmtsField;
        public AggregateBalancePerSafekeepingPlace12[] balAtSfkpgPlcField;
        public SubBalanceInformation6[] balBrkdwnField;
        public CorporateActionOption5Code corpActnOptnTpField;
        public bool corpActnOptnTpFieldSpecified;
        public string daysAcrdField;
        public bool daysAcrdFieldSpecified;
        public FinancialInstrumentAttributes20 finInstrmAttrbtsField;
        public SecurityIdentification14 finInstrmIdField;
        public ForeignExchangeTerms14[] fXDtlsField;
        public string hldgAddtlDtlsField;
        public BalanceAmounts1 instrmCcyAmtsField;
        public FinancialInstrument21 invstmtFndsFinInstrmAttrbtsField;
        public PriceInformation5[] pricDtlsField;
        public QuantityBreakdown4[] qtyBrkdwnField;
        public SafekeepingPlaceFormat3Choice sfkpgPlcField;
        public SupplementaryData1[] splmtryDataField;
        /// <remarks/>
        public BalanceAmounts1 AcctBaseCcyAmts
        {
            get
            {
                return this.acctBaseCcyAmtsField;
            }
            set
            {
                this.acctBaseCcyAmtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlBalBrkdwn")]
        public AdditionalBalanceInformation6[] AddtlBalBrkdwn
        {
            get
            {
                return this.addtlBalBrkdwnField;
            }
            set
            {
                this.addtlBalBrkdwnField = value;
            }
        }
        /// <remarks/>
        public DerivativeBasicAttributes1 AddtlDerivAttrbts
        {
            get
            {
                return this.addtlDerivAttrbtsField;
            }
            set
            {
                this.addtlDerivAttrbtsField = value;
            }
        }
        /// <remarks/>
        public Balance1 AggtBal
        {
            get
            {
                return this.aggtBalField;
            }
            set
            {
                this.aggtBalField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts1 AltrnRptgCcyAmts
        {
            get
            {
                return this.altrnRptgCcyAmtsField;
            }
            set
            {
                this.altrnRptgCcyAmtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalAtSfkpgPlc")]
        public AggregateBalancePerSafekeepingPlace12[] BalAtSfkpgPlc
        {
            get
            {
                return this.balAtSfkpgPlcField;
            }
            set
            {
                this.balAtSfkpgPlcField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalBrkdwn")]
        public SubBalanceInformation6[] BalBrkdwn
        {
            get
            {
                return this.balBrkdwnField;
            }
            set
            {
                this.balBrkdwnField = value;
            }
        }
        /// <remarks/>
        public CorporateActionOption5Code CorpActnOptnTp
        {
            get
            {
                return this.corpActnOptnTpField;
            }
            set
            {
                this.corpActnOptnTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CorpActnOptnTpSpecified
        {
            get
            {
                return this.corpActnOptnTpFieldSpecified;
            }
            set
            {
                this.corpActnOptnTpFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string DaysAcrd
        {
            get
            {
                return this.daysAcrdField;
            }
            set
            {
                this.daysAcrdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysAcrdSpecified
        {
            get
            {
                return this.daysAcrdFieldSpecified;
            }
            set
            {
                this.daysAcrdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public FinancialInstrumentAttributes20 FinInstrmAttrbts
        {
            get
            {
                return this.finInstrmAttrbtsField;
            }
            set
            {
                this.finInstrmAttrbtsField = value;
            }
        }
        /// <remarks/>
        public SecurityIdentification14 FinInstrmId
        {
            get
            {
                return this.finInstrmIdField;
            }
            set
            {
                this.finInstrmIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FXDtls")]
        public ForeignExchangeTerms14[] FXDtls
        {
            get
            {
                return this.fXDtlsField;
            }
            set
            {
                this.fXDtlsField = value;
            }
        }
        /// <remarks/>
        public string HldgAddtlDtls
        {
            get
            {
                return this.hldgAddtlDtlsField;
            }
            set
            {
                this.hldgAddtlDtlsField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts1 InstrmCcyAmts
        {
            get
            {
                return this.instrmCcyAmtsField;
            }
            set
            {
                this.instrmCcyAmtsField = value;
            }
        }
        /// <remarks/>
        public FinancialInstrument21 InvstmtFndsFinInstrmAttrbts
        {
            get
            {
                return this.invstmtFndsFinInstrmAttrbtsField;
            }
            set
            {
                this.invstmtFndsFinInstrmAttrbtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricDtls")]
        public PriceInformation5[] PricDtls
        {
            get
            {
                return this.pricDtlsField;
            }
            set
            {
                this.pricDtlsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QtyBrkdwn")]
        public QuantityBreakdown4[] QtyBrkdwn
        {
            get
            {
                return this.qtyBrkdwnField;
            }
            set
            {
                this.qtyBrkdwnField = value;
            }
        }
        /// <remarks/>
        public SafekeepingPlaceFormat3Choice SfkpgPlc
        {
            get
            {
                return this.sfkpgPlcField;
            }
            set
            {
                this.sfkpgPlcField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public SupplementaryData1[] SplmtryData
        {
            get
            {
                return this.splmtryDataField;
            }
            set
            {
                this.splmtryDataField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class AggregateBalancePerSafekeepingPlace12
    {
        public BalanceAmounts1 acctBaseCcyAmtsField;
        public AdditionalBalanceInformation6[] addtlBalBrkdwnField;
        public Balance1 aggtBalField;
        public BalanceAmounts1 altrnRptgCcyAmtsField;
        public SubBalanceInformation6[] balBrkdwnField;
        public string daysAcrdField;
        public bool daysAcrdFieldSpecified;
        public ForeignExchangeTerms14[] fXDtlsField;
        public string hldgAddtlDtlsField;
        public BalanceAmounts1 instrmCcyAmtsField;
        public MarketIdentification5 plcOfListgField;
        public PriceInformation5[] pricDtlsField;
        public QuantityBreakdown4[] qtyBrkdwnField;
        public SafekeepingPlaceFormat3Choice sfkpgPlcField;
        /// <remarks/>
        public BalanceAmounts1 AcctBaseCcyAmts
        {
            get
            {
                return this.acctBaseCcyAmtsField;
            }
            set
            {
                this.acctBaseCcyAmtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlBalBrkdwn")]
        public AdditionalBalanceInformation6[] AddtlBalBrkdwn
        {
            get
            {
                return this.addtlBalBrkdwnField;
            }
            set
            {
                this.addtlBalBrkdwnField = value;
            }
        }
        /// <remarks/>
        public Balance1 AggtBal
        {
            get
            {
                return this.aggtBalField;
            }
            set
            {
                this.aggtBalField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts1 AltrnRptgCcyAmts
        {
            get
            {
                return this.altrnRptgCcyAmtsField;
            }
            set
            {
                this.altrnRptgCcyAmtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalBrkdwn")]
        public SubBalanceInformation6[] BalBrkdwn
        {
            get
            {
                return this.balBrkdwnField;
            }
            set
            {
                this.balBrkdwnField = value;
            }
        }
        /// <remarks/>
        public string DaysAcrd
        {
            get
            {
                return this.daysAcrdField;
            }
            set
            {
                this.daysAcrdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysAcrdSpecified
        {
            get
            {
                return this.daysAcrdFieldSpecified;
            }
            set
            {
                this.daysAcrdFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FXDtls")]
        public ForeignExchangeTerms14[] FXDtls
        {
            get
            {
                return this.fXDtlsField;
            }
            set
            {
                this.fXDtlsField = value;
            }
        }
        /// <remarks/>
        public string HldgAddtlDtls
        {
            get
            {
                return this.hldgAddtlDtlsField;
            }
            set
            {
                this.hldgAddtlDtlsField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts1 InstrmCcyAmts
        {
            get
            {
                return this.instrmCcyAmtsField;
            }
            set
            {
                this.instrmCcyAmtsField = value;
            }
        }
        /// <remarks/>
        public MarketIdentification5 PlcOfListg
        {
            get
            {
                return this.plcOfListgField;
            }
            set
            {
                this.plcOfListgField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricDtls")]
        public PriceInformation5[] PricDtls
        {
            get
            {
                return this.pricDtlsField;
            }
            set
            {
                this.pricDtlsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QtyBrkdwn")]
        public QuantityBreakdown4[] QtyBrkdwn
        {
            get
            {
                return this.qtyBrkdwnField;
            }
            set
            {
                this.qtyBrkdwnField = value;
            }
        }
        /// <remarks/>
        public SafekeepingPlaceFormat3Choice SfkpgPlc
        {
            get
            {
                return this.sfkpgPlcField;
            }
            set
            {
                this.sfkpgPlcField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class AmountAndDirection6
    {
        public ActiveOrHistoricCurrencyAndAmount amtField;
        public bool sgnField;
        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
        /// <remarks/>
        public bool Sgn
        {
            get
            {
                return this.sgnField;
            }
            set
            {
                this.sgnField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Balance1
    {
        public BalanceQuantity4Choice qtyField;
        public ShortLong1Code shrtLngIndField;
        /// <remarks/>
        public BalanceQuantity4Choice Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
        /// <remarks/>
        public ShortLong1Code ShrtLngInd
        {
            get
            {
                return this.shrtLngIndField;
            }
            set
            {
                this.shrtLngIndField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class BalanceAmounts1
    {
        public AmountAndDirection6 acrdIntrstAmtField;
        public AmountAndDirection6 bookValField;
        public AmountAndDirection6 hldgValField;
        public AmountAndDirection6 prvsHldgValField;
        public AmountAndDirection6 urlsdGnLossField;
        /// <remarks/>
        public AmountAndDirection6 AcrdIntrstAmt
        {
            get
            {
                return this.acrdIntrstAmtField;
            }
            set
            {
                this.acrdIntrstAmtField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 BookVal
        {
            get
            {
                return this.bookValField;
            }
            set
            {
                this.bookValField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 HldgVal
        {
            get
            {
                return this.hldgValField;
            }
            set
            {
                this.hldgValField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 PrvsHldgVal
        {
            get
            {
                return this.prvsHldgValField;
            }
            set
            {
                this.prvsHldgValField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 UrlsdGnLoss
        {
            get
            {
                return this.urlsdGnLossField;
            }
            set
            {
                this.urlsdGnLossField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class BalanceAmounts2
    {
        public AmountAndDirection6 bookValField;
        public AmountAndDirection6 hldgValField;
        public AmountAndDirection6 urlsdGnLossField;
        /// <remarks/>
        public AmountAndDirection6 BookVal
        {
            get
            {
                return this.bookValField;
            }
            set
            {
                this.bookValField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 HldgVal
        {
            get
            {
                return this.hldgValField;
            }
            set
            {
                this.hldgValField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 UrlsdGnLoss
        {
            get
            {
                return this.urlsdGnLossField;
            }
            set
            {
                this.urlsdGnLossField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class BalanceQuantity4Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification22))]
        [System.Xml.Serialization.XmlElementAttribute("Qty", typeof(Quantity6Choice))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil", IsNullable = false)]
    public partial class BalForSubAcctBrData
    {
        public BrkTypeBrkId[] brkField;
        public BalForSubAcctBrDataCcyFwdOptn ccyFwdOptnField;
        public BalForSubAcctBrDataCcyOptn ccyOptnField;
        public BalForSubAcctBrDataCorp corpField;
        public BalForSubAcctBrDataDebe debeField;
        public ExpnType expnField;
        public BalForSubAcctBrDataGove goveField;
        public BalForSubAcctBrDataGuar guarField;
        public BalForSubAcctBrDataHedgTp hedgTpField;
        public PositionType longPosField;
        public BalForSubAcctBrDataPens[] pensPlanPartField;
        public BalForSubAcctBrDataRealStatePrtfl realStatePrtflField;
        public ReceInvstmtFndType receInvstmtFndField;
        public BalForSubAcctBrDataRiskLv riskLvField;
        public ShHldgIdType[] shHldgField;
        public PositionType shortPosField;
        public System.DateTime strtDtField;
        public bool strtDtFieldSpecified;
        public BalForSubAcctBrDataSwap swapField;
        public System.DateTime undrlygSctiesMtrtyDtField;
        public bool undrlygSctiesMtrtyDtFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BrkId", IsNullable = false)]
        public BrkTypeBrkId[] Brk
        {
            get
            {
                return this.brkField;
            }
            set
            {
                this.brkField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataCcyFwdOptn CcyFwdOptn
        {
            get
            {
                return this.ccyFwdOptnField;
            }
            set
            {
                this.ccyFwdOptnField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataCcyOptn CcyOptn
        {
            get
            {
                return this.ccyOptnField;
            }
            set
            {
                this.ccyOptnField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataCorp Corp
        {
            get
            {
                return this.corpField;
            }
            set
            {
                this.corpField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataDebe Debe
        {
            get
            {
                return this.debeField;
            }
            set
            {
                this.debeField = value;
            }
        }
        /// <remarks/>
        public ExpnType Expn
        {
            get
            {
                return this.expnField;
            }
            set
            {
                this.expnField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataGove Gove
        {
            get
            {
                return this.goveField;
            }
            set
            {
                this.goveField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataGuar Guar
        {
            get
            {
                return this.guarField;
            }
            set
            {
                this.guarField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataHedgTp HedgTp
        {
            get
            {
                return this.hedgTpField;
            }
            set
            {
                this.hedgTpField = value;
            }
        }
        /// <remarks/>
        public PositionType LongPos
        {
            get
            {
                return this.longPosField;
            }
            set
            {
                this.longPosField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Pens", IsNullable = false)]
        public BalForSubAcctBrDataPens[] PensPlanPart
        {
            get
            {
                return this.pensPlanPartField;
            }
            set
            {
                this.pensPlanPartField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtfl RealStatePrtfl
        {
            get
            {
                return this.realStatePrtflField;
            }
            set
            {
                this.realStatePrtflField = value;
            }
        }
        /// <remarks/>
        public ReceInvstmtFndType ReceInvstmtFnd
        {
            get
            {
                return this.receInvstmtFndField;
            }
            set
            {
                this.receInvstmtFndField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRiskLv RiskLv
        {
            get
            {
                return this.riskLvField;
            }
            set
            {
                this.riskLvField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ShHldgId", IsNullable = false)]
        public ShHldgIdType[] ShHldg
        {
            get
            {
                return this.shHldgField;
            }
            set
            {
                this.shHldgField = value;
            }
        }
        /// <remarks/>
        public PositionType ShortPos
        {
            get
            {
                return this.shortPosField;
            }
            set
            {
                this.shortPosField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StrtDt
        {
            get
            {
                return this.strtDtField;
            }
            set
            {
                this.strtDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StrtDtSpecified
        {
            get
            {
                return this.strtDtFieldSpecified;
            }
            set
            {
                this.strtDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataSwap Swap
        {
            get
            {
                return this.swapField;
            }
            set
            {
                this.swapField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime UndrlygSctiesMtrtyDt
        {
            get
            {
                return this.undrlygSctiesMtrtyDtField;
            }
            set
            {
                this.undrlygSctiesMtrtyDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UndrlygSctiesMtrtyDtSpecified
        {
            get
            {
                return this.undrlygSctiesMtrtyDtFieldSpecified;
            }
            set
            {
                this.undrlygSctiesMtrtyDtFieldSpecified = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataCcyFwdOptn
    {
        public BalForSubAcctBrDataCcyFwdOptnTP tpField;
        /// <remarks/>
        public BalForSubAcctBrDataCcyFwdOptnTP Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataCcyFwdOptnTP
    {
        public BalForSubAcctBrDataCcyFwdOptnTPCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataCcyFwdOptnTPCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataCcyOptn
    {
        public bool guarField;
        /// <remarks/>
        public bool Guar
        {
            get
            {
                return this.guarField;
            }
            set
            {
                this.guarField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataCorp
    {
        public BalForSubAcctBrDataCorpRiskLv riskLvField;
        /// <remarks/>
        public BalForSubAcctBrDataCorpRiskLv RiskLv
        {
            get
            {
                return this.riskLvField;
            }
            set
            {
                this.riskLvField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataCorpRiskLv
    {
        public BalForSubAcctBrDataCorpRiskLvCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataCorpRiskLvCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataDebe
    {
        public bool convIndField;
        public bool profSharIndField;
        public BalForSubAcctBrDataDebeRiskLv riskLvField;
        public bool speIndField;
        /// <remarks/>
        public bool ConvInd
        {
            get
            {
                return this.convIndField;
            }
            set
            {
                this.convIndField = value;
            }
        }
        /// <remarks/>
        public bool ProfSharInd
        {
            get
            {
                return this.profSharIndField;
            }
            set
            {
                this.profSharIndField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataDebeRiskLv RiskLv
        {
            get
            {
                return this.riskLvField;
            }
            set
            {
                this.riskLvField = value;
            }
        }
        /// <remarks/>
        public bool SpeInd
        {
            get
            {
                return this.speIndField;
            }
            set
            {
                this.speIndField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataDebeRiskLv
    {
        public BalForSubAcctBrDataDebeRiskLvCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataDebeRiskLvCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataGove
    {
        public BalForSubAcctBrDataGoveRiskLv riskLvField;
        /// <remarks/>
        public BalForSubAcctBrDataGoveRiskLv RiskLv
        {
            get
            {
                return this.riskLvField;
            }
            set
            {
                this.riskLvField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataGoveRiskLv
    {
        public BalForSubAcctBrDataGoveRiskLvCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataGoveRiskLvCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataGuar
    {
        public BalForSubAcctBrDataGuarCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataGuarCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataHedgTp
    {
        public BalForSubAcctBrDataHedgTpCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataHedgTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataPens
    {
        public string idField;
        public string percpartField;
        public BalForSubAcctBrDataPensPrtry prtryField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Percpart
        {
            get
            {
                return this.percpartField;
            }
            set
            {
                this.percpartField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataPensPrtry Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataPensPrtry
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtfl
    {
        public double bookValField;
        public BalForSubAcctBrDataRealStatePrtflEnterprise[] enterpriseField;
        public double fundPartPropertyField;
        public BalForSubAcctBrDataRealStatePrtflLease[] leaseField;
        public bool lgObjtIndField;
        public BalForSubAcctBrDataRealStatePrtflLgObjtRsn lgObjtRsnField;
        public NameAndAdressType nmAndAdrField;
        public BalForSubAcctBrDataRealStatePrtflPropTp propTpField;
        public BalForSubAcctBrDataRealStatePrtflRatBookVal ratBookValField;
        public System.DateTime rpOptnDtField;
        public bool rpOptnDtFieldSpecified;
        public bool rpOptnIndField;
        public BalForSubAcctBrDataRealStatePrtflUseTp useTpField;
        public BalForSubAcctBrDataRealStatePrtflValtInf valtInfField;
        /// <remarks/>
        public double BookVal
        {
            get
            {
                return this.bookValField;
            }
            set
            {
                this.bookValField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Enterprise")]
        public BalForSubAcctBrDataRealStatePrtflEnterprise[] Enterprise
        {
            get
            {
                return this.enterpriseField;
            }
            set
            {
                this.enterpriseField = value;
            }
        }
        /// <remarks/>
        public double FundPartProperty
        {
            get
            {
                return this.fundPartPropertyField;
            }
            set
            {
                this.fundPartPropertyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lease")]
        public BalForSubAcctBrDataRealStatePrtflLease[] Lease
        {
            get
            {
                return this.leaseField;
            }
            set
            {
                this.leaseField = value;
            }
        }
        /// <remarks/>
        public bool LgObjtInd
        {
            get
            {
                return this.lgObjtIndField;
            }
            set
            {
                this.lgObjtIndField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflLgObjtRsn LgObjtRsn
        {
            get
            {
                return this.lgObjtRsnField;
            }
            set
            {
                this.lgObjtRsnField = value;
            }
        }
        /// <remarks/>
        public NameAndAdressType NmAndAdr
        {
            get
            {
                return this.nmAndAdrField;
            }
            set
            {
                this.nmAndAdrField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflPropTp PropTp
        {
            get
            {
                return this.propTpField;
            }
            set
            {
                this.propTpField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflRatBookVal RatBookVal
        {
            get
            {
                return this.ratBookValField;
            }
            set
            {
                this.ratBookValField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RpOptnDt
        {
            get
            {
                return this.rpOptnDtField;
            }
            set
            {
                this.rpOptnDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RpOptnDtSpecified
        {
            get
            {
                return this.rpOptnDtFieldSpecified;
            }
            set
            {
                this.rpOptnDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool RpOptnInd
        {
            get
            {
                return this.rpOptnIndField;
            }
            set
            {
                this.rpOptnIndField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflUseTp UseTp
        {
            get
            {
                return this.useTpField;
            }
            set
            {
                this.useTpField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflValtInf ValtInf
        {
            get
            {
                return this.valtInfField;
            }
            set
            {
                this.valtInfField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflEnterprise
    {
        public string idField;
        public BalForSubAcctBrDataRealStatePrtflEnterprisePrtry prtryField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflEnterprisePrtry Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflEnterprisePrtry
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflLease
    {
        public string amtField;
        public BalForSubAcctBrDataRealStatePrtflLeaseTP tpField;
        /// <remarks/>
        public string Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflLeaseTP Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflLeaseTP
    {
        public BalForSubAcctBrDataRealStatePrtflLeaseTPCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflLeaseTPCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflLgObjtRsn
    {
        public string descField;
        /// <remarks/>
        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflPropTp
    {
        public BalForSubAcctBrDataRealStatePrtflPropTpCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflPropTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflRatBookVal
    {
        public BalForSubAcctBrDataRealStatePrtflRatBookValCode codeField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflRatBookValCode Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflUseTp
    {
        public BalForSubAcctBrDataRealStatePrtflUseTpCD cdField;
        public string regnNbField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflUseTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
        /// <remarks/>
        public string RegnNb
        {
            get
            {
                return this.regnNbField;
            }
            set
            {
                this.regnNbField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflValtInf
    {
        public BalForSubAcctBrDataRealStatePrtflValtInfEvaTp evaTpField;
        public string idField;
        public BalForSubAcctBrDataRealStatePrtflValtInfPrtry prtryField;
        public double ttlValAmtField;
        public bool ttlValAmtFieldSpecified;
        public System.DateTime valDateField;
        public bool valDateFieldSpecified;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflValtInfEvaTp EvaTp
        {
            get
            {
                return this.evaTpField;
            }
            set
            {
                this.evaTpField = value;
            }
        }
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflValtInfPrtry Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
        /// <remarks/>
        public double TtlValAmt
        {
            get
            {
                return this.ttlValAmtField;
            }
            set
            {
                this.ttlValAmtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlValAmtSpecified
        {
            get
            {
                return this.ttlValAmtFieldSpecified;
            }
            set
            {
                this.ttlValAmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ValDate
        {
            get
            {
                return this.valDateField;
            }
            set
            {
                this.valDateField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDateSpecified
        {
            get
            {
                return this.valDateFieldSpecified;
            }
            set
            {
                this.valDateFieldSpecified = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflValtInfEvaTp
    {
        public BalForSubAcctBrDataRealStatePrtflValtInfEvaTpCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflValtInfEvaTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRealStatePrtflValtInfPrtry
    {
        public BalForSubAcctBrDataRealStatePrtflValtInfPrtryID idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public BalForSubAcctBrDataRealStatePrtflValtInfPrtryID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataRiskLv
    {
        public BalForSubAcctBrDataRiskLvCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataRiskLvCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataSwap
    {
        public BalForSubAcctBrDataSwapGuar guarField;
        public BalForSubAcctBrDataSwapHedgTp hedgTpField;
        public PositionType longPosField;
        public PositionType shortPosField;
        public System.DateTime strtDtField;
        public bool strtDtFieldSpecified;
        /// <remarks/>
        public BalForSubAcctBrDataSwapGuar Guar
        {
            get
            {
                return this.guarField;
            }
            set
            {
                this.guarField = value;
            }
        }
        /// <remarks/>
        public BalForSubAcctBrDataSwapHedgTp HedgTp
        {
            get
            {
                return this.hedgTpField;
            }
            set
            {
                this.hedgTpField = value;
            }
        }
        /// <remarks/>
        public PositionType LongPos
        {
            get
            {
                return this.longPosField;
            }
            set
            {
                this.longPosField = value;
            }
        }
        /// <remarks/>
        public PositionType ShortPos
        {
            get
            {
                return this.shortPosField;
            }
            set
            {
                this.shortPosField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StrtDt
        {
            get
            {
                return this.strtDtField;
            }
            set
            {
                this.strtDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StrtDtSpecified
        {
            get
            {
                return this.strtDtFieldSpecified;
            }
            set
            {
                this.strtDtFieldSpecified = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataSwapGuar
    {
        public BalForSubAcctBrDataSwapGuarCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataSwapGuarCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BalForSubAcctBrDataSwapHedgTp
    {
        public BalForSubAcctBrDataSwapHedgTpCD cdField;
        /// <remarks/>
        public BalForSubAcctBrDataSwapHedgTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class BranchAndFinancialInstitutionIdentification5
    {
        public BranchData2 brnchIdField;
        public FinancialInstitutionIdentification8 finInstnIdField;
        /// <remarks/>
        public BranchData2 BrnchId
        {
            get
            {
                return this.brnchIdField;
            }
            set
            {
                this.brnchIdField = value;
            }
        }
        /// <remarks/>
        public FinancialInstitutionIdentification8 FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class BranchData2
    {
        public string idField;
        public string nmField;
        public PostalAddress6 pstlAdrField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BrkrType
    {
        public BrkrTypeBrkrPdVl brkrPdVlField;
        public string mktIdrCdField;
        public BrkrTypeRebaVl rebaVlField;
        /// <remarks/>
        public BrkrTypeBrkrPdVl BrkrPdVl
        {
            get
            {
                return this.brkrPdVlField;
            }
            set
            {
                this.brkrPdVlField = value;
            }
        }
        /// <remarks/>
        public string MktIdrCd
        {
            get
            {
                return this.mktIdrCdField;
            }
            set
            {
                this.mktIdrCdField = value;
            }
        }
        /// <remarks/>
        public BrkrTypeRebaVl RebaVl
        {
            get
            {
                return this.rebaVlField;
            }
            set
            {
                this.rebaVlField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BrkrTypeBrkrPdVl
    {
        public ActiveOrHistoricCurrencyAnd13DecimalAmount amtField;
        /// <remarks/>
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BrkrTypeRebaVl
    {
        public ActiveOrHistoricCurrencyAnd13DecimalAmount amtField;
        /// <remarks/>
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BrkTypeBrkId
    {
        public BrkTypeBrkIdBrkfSvcrTp brkfSvcrTpField;
        public BrkrType[] brkrField;
        public string idField;
        public GenericIdentification20 prtryField;
        public string transactionNbField;
        public bool transactionNbFieldSpecified;
        /// <remarks/>
        public BrkTypeBrkIdBrkfSvcrTp BrkfSvcrTp
        {
            get
            {
                return this.brkfSvcrTpField;
            }
            set
            {
                this.brkfSvcrTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Brkr")]
        public BrkrType[] Brkr
        {
            get
            {
                return this.brkrField;
            }
            set
            {
                this.brkrField = value;
            }
        }
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public GenericIdentification20 Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
        /// <remarks/>
        public string TransactionNb
        {
            get
            {
                return this.transactionNbField;
            }
            set
            {
                this.transactionNbField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionNbSpecified
        {
            get
            {
                return this.transactionNbFieldSpecified;
            }
            set
            {
                this.transactionNbFieldSpecified = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class BrkTypeBrkIdBrkfSvcrTp
    {
        public BrkTypeBrkIdBrkfSvcrTpCD cdField;
        /// <remarks/>
        public BrkTypeBrkIdBrkfSvcrTpCD Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }
    [XmlRoot(ElementName = nameof(BsnsMsg), Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
    public class BsnsMsg
    {
        [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
        public BusinessApplicationHeaderV01 AppHdr { get; set; }
        [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
        public DocumentXML Document { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class BusinessApplicationHeader1
    {
        public string bizMsgIdrField;
        public string bizSvcField;
        public string charSetField;
        public CopyDuplicate1Code cpyDplctField;
        public bool cpyDplctFieldSpecified;
        public System.DateTime creDtField;
        public Party9Choice frField;
        public string msgDefIdrField;
        public string prtyField;
        public bool pssblDplctField;
        public bool pssblDplctFieldSpecified;
        //Nenhum Uso encontrado
        public string sgntrField;
        public Party9Choice toField;
        /// <remarks/>
        public string BizMsgIdr
        {
            get
            {
                return this.bizMsgIdrField;
            }
            set
            {
                this.bizMsgIdrField = value;
            }
        }
        /// <remarks/>
        public string BizSvc
        {
            get
            {
                return this.bizSvcField;
            }
            set
            {
                this.bizSvcField = value;
            }
        }
        /// <remarks/>
        public string CharSet
        {
            get
            {
                return this.charSetField;
            }
            set
            {
                this.charSetField = value;
            }
        }
        /// <remarks/>
        public CopyDuplicate1Code CpyDplct
        {
            get
            {
                return this.cpyDplctField;
            }
            set
            {
                this.cpyDplctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CpyDplctSpecified
        {
            get
            {
                return this.cpyDplctFieldSpecified;
            }
            set
            {
                this.cpyDplctFieldSpecified = value;
            }
        }
        /// <remarks/>
        public System.DateTime CreDt
        {
            get
            {
                return this.creDtField;
            }
            set
            {
                this.creDtField = value;
            }
        }
        /// <remarks/>
        public Party9Choice Fr
        {
            get
            {
                return this.frField;
            }
            set
            {
                this.frField = value;
            }
        }
        /// <remarks/>
        public string MsgDefIdr
        {
            get
            {
                return this.msgDefIdrField;
            }
            set
            {
                this.msgDefIdrField = value;
            }
        }
        /// <remarks/>
        public string Prty
        {
            get
            {
                return this.prtyField;
            }
            set
            {
                this.prtyField = value;
            }
        }
        /// <remarks/>
        public bool PssblDplct
        {
            get
            {
                return this.pssblDplctField;
            }
            set
            {
                this.pssblDplctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PssblDplctSpecified
        {
            get
            {
                return this.pssblDplctFieldSpecified;
            }
            set
            {
                this.pssblDplctFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string Sgntr
        {
            get
            {
                return this.sgntrField;
            }
            set
            {
                this.sgntrField = value;
            }
        }
        /// <remarks/>
        public Party9Choice To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    [System.Xml.Serialization.XmlRootAttribute("AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01", IsNullable = false)]
    public partial class BusinessApplicationHeaderV01
    {
        public string bizMsgIdrField;
        public string bizSvcField;
        public string charSetField;
        public CopyDuplicate1Code cpyDplctField;
        public bool cpyDplctFieldSpecified;
        public System.DateTime creDtField;
        public Party9Choice frField;
        public string msgDefIdrField;
        public string prtyField;
        public bool pssblDplctField;
        public bool pssblDplctFieldSpecified;
        public BusinessApplicationHeader1 rltdField;
        //Nenhum Uso encontrado
        public string sgntrField;
        public Party9Choice toField;
        /// <remarks/>
        public string BizMsgIdr
        {
            get
            {
                return this.bizMsgIdrField;
            }
            set
            {
                this.bizMsgIdrField = value;
            }
        }
        /// <remarks/>
        public string BizSvc
        {
            get
            {
                return this.bizSvcField;
            }
            set
            {
                this.bizSvcField = value;
            }
        }
        /// <remarks/>
        public string CharSet
        {
            get
            {
                return this.charSetField;
            }
            set
            {
                this.charSetField = value;
            }
        }
        /// <remarks/>
        public CopyDuplicate1Code CpyDplct
        {
            get
            {
                return this.cpyDplctField;
            }
            set
            {
                this.cpyDplctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CpyDplctSpecified
        {
            get
            {
                return this.cpyDplctFieldSpecified;
            }
            set
            {
                this.cpyDplctFieldSpecified = value;
            }
        }
        /// <remarks/>
        public System.DateTime CreDt
        {
            get
            {
                return this.creDtField;
            }
            set
            {
                this.creDtField = value;
            }
        }
        /// <remarks/>
        public Party9Choice Fr
        {
            get
            {
                return this.frField;
            }
            set
            {
                this.frField = value;
            }
        }
        /// <remarks/>
        public string MsgDefIdr
        {
            get
            {
                return this.msgDefIdrField;
            }
            set
            {
                this.msgDefIdrField = value;
            }
        }
        /// <remarks/>
        public string Prty
        {
            get
            {
                return this.prtyField;
            }
            set
            {
                this.prtyField = value;
            }
        }
        /// <remarks/>
        public bool PssblDplct
        {
            get
            {
                return this.pssblDplctField;
            }
            set
            {
                this.pssblDplctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PssblDplctSpecified
        {
            get
            {
                return this.pssblDplctFieldSpecified;
            }
            set
            {
                this.pssblDplctFieldSpecified = value;
            }
        }
        /// <remarks/>
        public BusinessApplicationHeader1 Rltd
        {
            get
            {
                return this.rltdField;
            }
            set
            {
                this.rltdField = value;
            }
        }
        /// <remarks/>
        public string Sgntr
        {
            get
            {
                return this.sgntrField;
            }
            set
            {
                this.sgntrField = value;
            }
        }
        /// <remarks/>
        public Party9Choice To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class ClassificationType2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AltrnClssfctn", typeof(GenericIdentification19))]
        [System.Xml.Serialization.XmlElementAttribute("ClssfctnFinInstrm", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class ClearingSystemIdentification2Choice
    {
        public ItemChoiceType8 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class ClearingSystemMemberIdentification2
    {
        public ClearingSystemIdentification2Choice clrSysIdField;
        public string mmbIdField;
        /// <remarks/>
        public ClearingSystemIdentification2Choice ClrSysId
        {
            get
            {
                return this.clrSysIdField;
            }
            set
            {
                this.clrSysIdField = value;
            }
        }
        /// <remarks/>
        public string MmbId
        {
            get
            {
                return this.mmbIdField;
            }
            set
            {
                this.mmbIdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class ContactDetails2
    {
        public string emailAdrField;
        public string faxNbField;
        public string mobNbField;
        public string nmField;
        public NamePrefix1Code nmPrfxField;
        public bool nmPrfxFieldSpecified;
        public string othrField;
        public string phneNbField;
        /// <remarks/>
        public string EmailAdr
        {
            get
            {
                return this.emailAdrField;
            }
            set
            {
                this.emailAdrField = value;
            }
        }
        /// <remarks/>
        public string FaxNb
        {
            get
            {
                return this.faxNbField;
            }
            set
            {
                this.faxNbField = value;
            }
        }
        /// <remarks/>
        public string MobNb
        {
            get
            {
                return this.mobNbField;
            }
            set
            {
                this.mobNbField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public NamePrefix1Code NmPrfx
        {
            get
            {
                return this.nmPrfxField;
            }
            set
            {
                this.nmPrfxField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified
        {
            get
            {
                return this.nmPrfxFieldSpecified;
            }
            set
            {
                this.nmPrfxFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class DateAndDateTimeChoice
    {
        public ItemChoiceType1 itemElementNameField;
        public System.DateTime itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class DateAndPlaceOfBirth
    {
        public System.DateTime birthDtField;
        public string cityOfBirthField;
        public string ctryOfBirthField;
        public string prvcOfBirthField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDt
        {
            get
            {
                return this.birthDtField;
            }
            set
            {
                this.birthDtField = value;
            }
        }
        /// <remarks/>
        public string CityOfBirth
        {
            get
            {
                return this.cityOfBirthField;
            }
            set
            {
                this.cityOfBirthField = value;
            }
        }
        /// <remarks/>
        public string CtryOfBirth
        {
            get
            {
                return this.ctryOfBirthField;
            }
            set
            {
                this.ctryOfBirthField = value;
            }
        }
        /// <remarks/>
        public string PrvcOfBirth
        {
            get
            {
                return this.prvcOfBirthField;
            }
            set
            {
                this.prvcOfBirthField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class DerivativeBasicAttributes1
    {
        public bool intrstInclInPricField;
        public bool intrstInclInPricFieldSpecified;
        public ActiveOrHistoricCurrencyAndAmount ntnlCcyAndAmtField;
        /// <remarks/>
        public bool IntrstInclInPric
        {
            get
            {
                return this.intrstInclInPricField;
            }
            set
            {
                this.intrstInclInPricField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntrstInclInPricSpecified
        {
            get
            {
                return this.intrstInclInPricFieldSpecified;
            }
            set
            {
                this.intrstInclInPricFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount NtnlCcyAndAmt
        {
            get
            {
                return this.ntnlCcyAndAmtField;
            }
            set
            {
                this.ntnlCcyAndAmtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04", IsNullable = false)]
    public partial class DocumentXML
    {
        public SecuritiesBalanceAccountingReportV04 sctiesBalAcctgRptField;
        /// <remarks/>
        public SecuritiesBalanceAccountingReportV04 SctiesBalAcctgRpt
        {
            get
            {
                return this.sctiesBalAcctgRptField;
            }
            set
            {
                this.sctiesBalAcctgRptField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class EqulFeeType
    {
        public EqulIndexType[] equlIndexField;
        public string rateField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EqulIndex")]
        public EqulIndexType[] EqulIndex
        {
            get
            {
                return this.equlIndexField;
            }
            set
            {
                this.equlIndexField = value;
            }
        }
        /// <remarks/>
        public string Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class EqulIndexType
    {
        public EqulIndexTypeCode codeField;
        public string rateField;
        /// <remarks/>
        public EqulIndexTypeCode Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        /// <remarks/>
        public string Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class EqulIndexTypeCode
    {
        public GenericIdentification1 prtryField;
        /// <remarks/>
        public GenericIdentification1 Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class ExpnType
    {
        public EqulFeeType equlFeeField;
        public string mgmtFeeRateField;
        /// <remarks/>
        public EqulFeeType EqulFee
        {
            get
            {
                return this.equlFeeField;
            }
            set
            {
                this.equlFeeField = value;
            }
        }
        /// <remarks/>
        public string MgmtFeeRate
        {
            get
            {
                return this.mgmtFeeRateField;
            }
            set
            {
                this.mgmtFeeRateField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class FinancialIdentificationSchemeName1Choice
    {
        public ItemChoiceType9 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class FinancialInstitutionIdentification8
    {
        public string bICFIField;
        public ClearingSystemMemberIdentification2 clrSysMmbIdField;
        public string nmField;
        public GenericFinancialIdentification1 othrField;
        public PostalAddress6 pstlAdrField;
        /// <remarks/>
        public string BICFI
        {
            get
            {
                return this.bICFIField;
            }
            set
            {
                this.bICFIField = value;
            }
        }
        /// <remarks/>
        public ClearingSystemMemberIdentification2 ClrSysMmbId
        {
            get
            {
                return this.clrSysMmbIdField;
            }
            set
            {
                this.clrSysMmbIdField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public GenericFinancialIdentification1 Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
        /// <remarks/>
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class FinancialInstrument21
    {
        public string baseCcyField;
        public string clssTpField;
        public string ctryOfDmclField;
        public string dnmtnCcyField;
        public DistributionPolicy1Code dstrbtnPlcyField;
        public bool dstrbtnPlcyFieldSpecified;
        public bool dualFndIndField;
        public bool dualFndIndFieldSpecified;
        public string pdctGrpField;
        public string[] regdDstrbtnCtryField;
        public string reqdNAVCcyField;
        public FormOfSecurity1Code sctiesFormField;
        public bool sctiesFormFieldSpecified;
        public string umbrllNmField;
        /// <remarks/>
        public string BaseCcy
        {
            get
            {
                return this.baseCcyField;
            }
            set
            {
                this.baseCcyField = value;
            }
        }
        /// <remarks/>
        public string ClssTp
        {
            get
            {
                return this.clssTpField;
            }
            set
            {
                this.clssTpField = value;
            }
        }
        /// <remarks/>
        public string CtryOfDmcl
        {
            get
            {
                return this.ctryOfDmclField;
            }
            set
            {
                this.ctryOfDmclField = value;
            }
        }
        /// <remarks/>
        public string DnmtnCcy
        {
            get
            {
                return this.dnmtnCcyField;
            }
            set
            {
                this.dnmtnCcyField = value;
            }
        }
        /// <remarks/>
        public DistributionPolicy1Code DstrbtnPlcy
        {
            get
            {
                return this.dstrbtnPlcyField;
            }
            set
            {
                this.dstrbtnPlcyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified
        {
            get
            {
                return this.dstrbtnPlcyFieldSpecified;
            }
            set
            {
                this.dstrbtnPlcyFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DualFndInd
        {
            get
            {
                return this.dualFndIndField;
            }
            set
            {
                this.dualFndIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DualFndIndSpecified
        {
            get
            {
                return this.dualFndIndFieldSpecified;
            }
            set
            {
                this.dualFndIndFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string PdctGrp
        {
            get
            {
                return this.pdctGrpField;
            }
            set
            {
                this.pdctGrpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegdDstrbtnCtry")]
        public string[] RegdDstrbtnCtry
        {
            get
            {
                return this.regdDstrbtnCtryField;
            }
            set
            {
                this.regdDstrbtnCtryField = value;
            }
        }
        /// <remarks/>
        public string ReqdNAVCcy
        {
            get
            {
                return this.reqdNAVCcyField;
            }
            set
            {
                this.reqdNAVCcyField = value;
            }
        }
        /// <remarks/>
        public FormOfSecurity1Code SctiesForm
        {
            get
            {
                return this.sctiesFormField;
            }
            set
            {
                this.sctiesFormField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified
        {
            get
            {
                return this.sctiesFormFieldSpecified;
            }
            set
            {
                this.sctiesFormFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string UmbrllNm
        {
            get
            {
                return this.umbrllNmField;
            }
            set
            {
                this.umbrllNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class FinancialInstrumentAttributes20
    {
        public bool cllblIndField;
        public bool cllblIndFieldSpecified;
        public ClassificationType2Choice clssfctnTpField;
        public Price2 convsPricField;
        public Number2Choice cpnAttchdNbField;
        public System.DateTime cpnDtField;
        public bool cpnDtFieldSpecified;
        public FinancialInstrumentQuantity1Choice ctrctSzField;
        public string curFctrField;
        public bool curFctrFieldSpecified;
        public InterestComputationMethodFormat1Choice dayCntBsisField;
        public string dnmtnCcyField;
        public System.DateTime dtdDtField;
        public bool dtdDtFieldSpecified;
        public Price2 exrcPricField;
        public string finInstrmAttrAddtlDtlsField;
        public System.DateTime fltgRateFxgDtField;
        public bool fltgRateFxgDtFieldSpecified;
        public System.DateTime frstPmtDtField;
        public bool frstPmtDtFieldSpecified;
        public string indxRateBsisField;
        public bool indxRateBsisFieldSpecified;
        public string intrstRateField;
        public bool intrstRateFieldSpecified;
        public System.DateTime isseDtField;
        public bool isseDtFieldSpecified;
        public FinancialInstrumentQuantity1Choice minNmnlQtyField;
        public PriceType1Choice mktOrIndctvPricField;
        public System.DateTime mtrtyDtField;
        public bool mtrtyDtFieldSpecified;
        public System.DateTime nxtCllblDtField;
        public bool nxtCllblDtFieldSpecified;
        public string nxtFctrField;
        public bool nxtFctrFieldSpecified;
        public string nxtIntrstRateField;
        public bool nxtIntrstRateFieldSpecified;
        public OptionStyle4Choice optnStyleField;
        public OptionType2Choice optnTpField;
        public MarketIdentification5 plcOfListgField;
        public PaymentDirection2Choice pmtDrctnField;
        public Frequency3Choice pmtFrqcyField;
        public SecuritiesPaymentStatus2Choice pmtStsField;
        public Number2Choice poolNbField;
        public PreferenceToIncome2Choice prefToIncmField;
        public string prvsFctrField;
        public bool prvsFctrFieldSpecified;
        public System.DateTime putblDtField;
        public bool putblDtFieldSpecified;
        public bool putblIndField;
        public bool putblIndFieldSpecified;
        public FormOfSecurity2Choice regnFormField;
        public Price2 sbcptPricField;
        public Price2 strkPricField;
        public SecurityIdentification14[] undrlygFinInstrmIdField;
        public Frequency3Choice varblRateChngFrqcyField;
        public bool varblRateIndField;
        public bool varblRateIndFieldSpecified;
        public System.DateTime xpryDtField;
        public bool xpryDtFieldSpecified;
        /// <remarks/>
        public bool CllblInd
        {
            get
            {
                return this.cllblIndField;
            }
            set
            {
                this.cllblIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CllblIndSpecified
        {
            get
            {
                return this.cllblIndFieldSpecified;
            }
            set
            {
                this.cllblIndFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ClassificationType2Choice ClssfctnTp
        {
            get
            {
                return this.clssfctnTpField;
            }
            set
            {
                this.clssfctnTpField = value;
            }
        }
        /// <remarks/>
        public Price2 ConvsPric
        {
            get
            {
                return this.convsPricField;
            }
            set
            {
                this.convsPricField = value;
            }
        }
        /// <remarks/>
        public Number2Choice CpnAttchdNb
        {
            get
            {
                return this.cpnAttchdNbField;
            }
            set
            {
                this.cpnAttchdNbField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CpnDt
        {
            get
            {
                return this.cpnDtField;
            }
            set
            {
                this.cpnDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CpnDtSpecified
        {
            get
            {
                return this.cpnDtFieldSpecified;
            }
            set
            {
                this.cpnDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public FinancialInstrumentQuantity1Choice CtrctSz
        {
            get
            {
                return this.ctrctSzField;
            }
            set
            {
                this.ctrctSzField = value;
            }
        }
        /// <remarks/>
        public string CurFctr
        {
            get
            {
                return this.curFctrField;
            }
            set
            {
                this.curFctrField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurFctrSpecified
        {
            get
            {
                return this.curFctrFieldSpecified;
            }
            set
            {
                this.curFctrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public InterestComputationMethodFormat1Choice DayCntBsis
        {
            get
            {
                return this.dayCntBsisField;
            }
            set
            {
                this.dayCntBsisField = value;
            }
        }
        /// <remarks/>
        public string DnmtnCcy
        {
            get
            {
                return this.dnmtnCcyField;
            }
            set
            {
                this.dnmtnCcyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DtdDt
        {
            get
            {
                return this.dtdDtField;
            }
            set
            {
                this.dtdDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtdDtSpecified
        {
            get
            {
                return this.dtdDtFieldSpecified;
            }
            set
            {
                this.dtdDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public Price2 ExrcPric
        {
            get
            {
                return this.exrcPricField;
            }
            set
            {
                this.exrcPricField = value;
            }
        }
        /// <remarks/>
        public string FinInstrmAttrAddtlDtls
        {
            get
            {
                return this.finInstrmAttrAddtlDtlsField;
            }
            set
            {
                this.finInstrmAttrAddtlDtlsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FltgRateFxgDt
        {
            get
            {
                return this.fltgRateFxgDtField;
            }
            set
            {
                this.fltgRateFxgDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FltgRateFxgDtSpecified
        {
            get
            {
                return this.fltgRateFxgDtFieldSpecified;
            }
            set
            {
                this.fltgRateFxgDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FrstPmtDt
        {
            get
            {
                return this.frstPmtDtField;
            }
            set
            {
                this.frstPmtDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrstPmtDtSpecified
        {
            get
            {
                return this.frstPmtDtFieldSpecified;
            }
            set
            {
                this.frstPmtDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string IndxRateBsis
        {
            get
            {
                return this.indxRateBsisField;
            }
            set
            {
                this.indxRateBsisField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndxRateBsisSpecified
        {
            get
            {
                return this.indxRateBsisFieldSpecified;
            }
            set
            {
                this.indxRateBsisFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string IntrstRate
        {
            get
            {
                return this.intrstRateField;
            }
            set
            {
                this.intrstRateField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntrstRateSpecified
        {
            get
            {
                return this.intrstRateFieldSpecified;
            }
            set
            {
                this.intrstRateFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IsseDt
        {
            get
            {
                return this.isseDtField;
            }
            set
            {
                this.isseDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsseDtSpecified
        {
            get
            {
                return this.isseDtFieldSpecified;
            }
            set
            {
                this.isseDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public FinancialInstrumentQuantity1Choice MinNmnlQty
        {
            get
            {
                return this.minNmnlQtyField;
            }
            set
            {
                this.minNmnlQtyField = value;
            }
        }
        /// <remarks/>
        public PriceType1Choice MktOrIndctvPric
        {
            get
            {
                return this.mktOrIndctvPricField;
            }
            set
            {
                this.mktOrIndctvPricField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime MtrtyDt
        {
            get
            {
                return this.mtrtyDtField;
            }
            set
            {
                this.mtrtyDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtrtyDtSpecified
        {
            get
            {
                return this.mtrtyDtFieldSpecified;
            }
            set
            {
                this.mtrtyDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime NxtCllblDt
        {
            get
            {
                return this.nxtCllblDtField;
            }
            set
            {
                this.nxtCllblDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NxtCllblDtSpecified
        {
            get
            {
                return this.nxtCllblDtFieldSpecified;
            }
            set
            {
                this.nxtCllblDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string NxtFctr
        {
            get
            {
                return this.nxtFctrField;
            }
            set
            {
                this.nxtFctrField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NxtFctrSpecified
        {
            get
            {
                return this.nxtFctrFieldSpecified;
            }
            set
            {
                this.nxtFctrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string NxtIntrstRate
        {
            get
            {
                return this.nxtIntrstRateField;
            }
            set
            {
                this.nxtIntrstRateField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NxtIntrstRateSpecified
        {
            get
            {
                return this.nxtIntrstRateFieldSpecified;
            }
            set
            {
                this.nxtIntrstRateFieldSpecified = value;
            }
        }
        /// <remarks/>
        public OptionStyle4Choice OptnStyle
        {
            get
            {
                return this.optnStyleField;
            }
            set
            {
                this.optnStyleField = value;
            }
        }
        /// <remarks/>
        public OptionType2Choice OptnTp
        {
            get
            {
                return this.optnTpField;
            }
            set
            {
                this.optnTpField = value;
            }
        }
        /// <remarks/>
        public MarketIdentification5 PlcOfListg
        {
            get
            {
                return this.plcOfListgField;
            }
            set
            {
                this.plcOfListgField = value;
            }
        }
        /// <remarks/>
        public PaymentDirection2Choice PmtDrctn
        {
            get
            {
                return this.pmtDrctnField;
            }
            set
            {
                this.pmtDrctnField = value;
            }
        }
        /// <remarks/>
        public Frequency3Choice PmtFrqcy
        {
            get
            {
                return this.pmtFrqcyField;
            }
            set
            {
                this.pmtFrqcyField = value;
            }
        }
        /// <remarks/>
        public SecuritiesPaymentStatus2Choice PmtSts
        {
            get
            {
                return this.pmtStsField;
            }
            set
            {
                this.pmtStsField = value;
            }
        }
        /// <remarks/>
        public Number2Choice PoolNb
        {
            get
            {
                return this.poolNbField;
            }
            set
            {
                this.poolNbField = value;
            }
        }
        /// <remarks/>
        public PreferenceToIncome2Choice PrefToIncm
        {
            get
            {
                return this.prefToIncmField;
            }
            set
            {
                this.prefToIncmField = value;
            }
        }
        /// <remarks/>
        public string PrvsFctr
        {
            get
            {
                return this.prvsFctrField;
            }
            set
            {
                this.prvsFctrField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrvsFctrSpecified
        {
            get
            {
                return this.prvsFctrFieldSpecified;
            }
            set
            {
                this.prvsFctrFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PutblDt
        {
            get
            {
                return this.putblDtField;
            }
            set
            {
                this.putblDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PutblDtSpecified
        {
            get
            {
                return this.putblDtFieldSpecified;
            }
            set
            {
                this.putblDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool PutblInd
        {
            get
            {
                return this.putblIndField;
            }
            set
            {
                this.putblIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PutblIndSpecified
        {
            get
            {
                return this.putblIndFieldSpecified;
            }
            set
            {
                this.putblIndFieldSpecified = value;
            }
        }
        /// <remarks/>
        public FormOfSecurity2Choice RegnForm
        {
            get
            {
                return this.regnFormField;
            }
            set
            {
                this.regnFormField = value;
            }
        }
        /// <remarks/>
        public Price2 SbcptPric
        {
            get
            {
                return this.sbcptPricField;
            }
            set
            {
                this.sbcptPricField = value;
            }
        }
        /// <remarks/>
        public Price2 StrkPric
        {
            get
            {
                return this.strkPricField;
            }
            set
            {
                this.strkPricField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UndrlygFinInstrmId")]
        public SecurityIdentification14[] UndrlygFinInstrmId
        {
            get
            {
                return this.undrlygFinInstrmIdField;
            }
            set
            {
                this.undrlygFinInstrmIdField = value;
            }
        }
        /// <remarks/>
        public Frequency3Choice VarblRateChngFrqcy
        {
            get
            {
                return this.varblRateChngFrqcyField;
            }
            set
            {
                this.varblRateChngFrqcyField = value;
            }
        }
        /// <remarks/>
        public bool VarblRateInd
        {
            get
            {
                return this.varblRateIndField;
            }
            set
            {
                this.varblRateIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VarblRateIndSpecified
        {
            get
            {
                return this.varblRateIndFieldSpecified;
            }
            set
            {
                this.varblRateIndFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime XpryDt
        {
            get
            {
                return this.xpryDtField;
            }
            set
            {
                this.xpryDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XpryDtSpecified
        {
            get
            {
                return this.xpryDtFieldSpecified;
            }
            set
            {
                this.xpryDtFieldSpecified = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class FinancialInstrumentQuantity1Choice
    {
        public ItemChoiceType5 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AmtsdVal", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FaceAmt", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Unit", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class ForeignExchangeTerms14
    {
        public string qtdCcyField;
        public PartyIdentification49Choice qtgInstnField;
        public System.DateTime qtnDtField;
        public bool qtnDtFieldSpecified;
        public string unitCcyField;
        public string xchgRateField;
        /// <remarks/>
        public string QtdCcy
        {
            get
            {
                return this.qtdCcyField;
            }
            set
            {
                this.qtdCcyField = value;
            }
        }
        /// <remarks/>
        public PartyIdentification49Choice QtgInstn
        {
            get
            {
                return this.qtgInstnField;
            }
            set
            {
                this.qtgInstnField = value;
            }
        }
        /// <remarks/>
        public System.DateTime QtnDt
        {
            get
            {
                return this.qtnDtField;
            }
            set
            {
                this.qtnDtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtnDtSpecified
        {
            get
            {
                return this.qtnDtFieldSpecified;
            }
            set
            {
                this.qtnDtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string UnitCcy
        {
            get
            {
                return this.unitCcyField;
            }
            set
            {
                this.unitCcyField = value;
            }
        }
        /// <remarks/>
        public string XchgRate
        {
            get
            {
                return this.xchgRateField;
            }
            set
            {
                this.xchgRateField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class FormOfSecurity2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(FormOfSecurity1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Frequency3Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(EventFrequency3Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Frequency4Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(EventFrequency4Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    [XmlRoot(ElementName = nameof(GalgoAssBalStmt), Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
    public class GalgoAssBalStmt
    {
        [XmlElement(ElementName = "BsnsMsg", Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
        public BsnsMsg BsnsMsg { get; set; }
        [XmlElement(ElementName = "GalgoHdr", Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
        public GalgoHdr GalgoHdr { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }
    [XmlRoot(ElementName = nameof(GalgoHdr), Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
    public class GalgoHdr
    {
        [XmlElement(ElementName = "idMsgSender", Namespace = "http://www.sistemagalgo.com/SchemaPosicaoAtivos")]
        public string IdMsgSender { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class GenericFinancialIdentification1
    {
        public string idField;
        public string issrField;
        public FinancialIdentificationSchemeName1Choice schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public FinancialIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification1
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification13
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification19
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification20
    {
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification21
    {
        public string idField;
        public GenericIdentification20 tpField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public GenericIdentification20 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class GenericIdentification22
    {
        public string balField;
        public string idField;
        public string issrField;
        public string schmeNmField;
        /// <remarks/>
        public string Bal
        {
            get
            {
                return this.balField;
            }
            set
            {
                this.balField = value;
            }
        }
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class GenericOrganisationIdentification1
    {
        public string idField;
        public string issrField;
        public OrganisationIdentificationSchemeName1Choice schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public OrganisationIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class GenericPersonIdentification1
    {
        public string idField;
        public string issrField;
        public PersonIdentificationSchemeName1Choice schmeNmField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
        /// <remarks/>
        public PersonIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class IdentificationSource3Choice
    {
        public ItemChoiceType2 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class InterestComputationMethodFormat1Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(InterestComputationMethod2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Intermediary21
    {
        public Account11 acctField;
        public PartyIdentification49Choice idField;
        public Role2Choice roleField;
        /// <remarks/>
        public Account11 Acct
        {
            get
            {
                return this.acctField;
            }
            set
            {
                this.acctField = value;
            }
        }
        /// <remarks/>
        public PartyIdentification49Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public Role2Choice Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class MarketIdentification1Choice
    {
        public ItemChoiceType3 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Desc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MktIdrCd", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class MarketIdentification5
    {
        public MarketIdentification1Choice idField;
        public MarketType2Choice tpField;
        /// <remarks/>
        public MarketIdentification1Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public MarketType2Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class MarketIdentification6
    {
        public MarketIdentification1Choice idField;
        public MarketType4Choice tpField;
        /// <remarks/>
        public MarketIdentification1Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public MarketType4Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class MarketType2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(MarketType5Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class MarketType4Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(MarketType4Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class NameAndAddress5
    {
        public PostalAddress1 adrField;
        public string nmField;
        /// <remarks/>
        public PostalAddress1 Adr
        {
            get
            {
                return this.adrField;
            }
            set
            {
                this.adrField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class NameAndAdressType
    {
        public AddressType adrField;
        public string nmField;
        /// <remarks/>
        public AddressType Adr
        {
            get
            {
                return this.adrField;
            }
            set
            {
                this.adrField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Number2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lng", typeof(GenericIdentification1))]
        [System.Xml.Serialization.XmlElementAttribute("Shrt", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Number3Choice
    {
        public ItemChoiceType itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lng", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Shrt", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class OptionStyle4Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(OptionStyle2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class OptionType2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(OptionType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class OrganisationIdentification7
    {
        public string anyBICField;
        public GenericOrganisationIdentification1[] othrField;
        /// <remarks/>
        public string AnyBIC
        {
            get
            {
                return this.anyBICField;
            }
            set
            {
                this.anyBICField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public GenericOrganisationIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class OrganisationIdentificationSchemeName1Choice
    {
        public ItemChoiceType6 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class OriginalAndCurrentQuantities1
    {
        public string amtsdValField;
        public string faceAmtField;
        /// <remarks/>
        public string AmtsdVal
        {
            get
            {
                return this.amtsdValField;
            }
            set
            {
                this.amtsdValField = value;
            }
        }
        /// <remarks/>
        public string FaceAmt
        {
            get
            {
                return this.faceAmtField;
            }
            set
            {
                this.faceAmtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class OtherIdentification1
    {
        public string idField;
        public string sfxField;
        public IdentificationSource3Choice tpField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Sfx
        {
            get
            {
                return this.sfxField;
            }
            set
            {
                this.sfxField = value;
            }
        }
        /// <remarks/>
        public IdentificationSource3Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Pagination
    {
        public bool lastPgIndField;
        public string pgNbField;
        /// <remarks/>
        public bool LastPgInd
        {
            get
            {
                return this.lastPgIndField;
            }
            set
            {
                this.lastPgIndField = value;
            }
        }
        /// <remarks/>
        public string PgNb
        {
            get
            {
                return this.pgNbField;
            }
            set
            {
                this.pgNbField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class Party10Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification7))]
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification5))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class Party9Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FIId", typeof(BranchAndFinancialInstitutionIdentification5))]
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(PartyIdentification42))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PartyIdentification36Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification19))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class PartyIdentification42
    {
        public ContactDetails2 ctctDtlsField;
        public string ctryOfResField;
        public Party10Choice idField;
        public string nmField;
        public PostalAddress6 pstlAdrField;
        /// <remarks/>
        public ContactDetails2 CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
        /// <remarks/>
        public string CtryOfRes
        {
            get
            {
                return this.ctryOfResField;
            }
            set
            {
                this.ctryOfResField = value;
            }
        }
        /// <remarks/>
        public Party10Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PartyIdentification49Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification19))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PaymentDirection2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ind", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class PersonIdentification5
    {
        public DateAndPlaceOfBirth dtAndPlcOfBirthField;
        public GenericPersonIdentification1[] othrField;
        /// <remarks/>
        public DateAndPlaceOfBirth DtAndPlcOfBirth
        {
            get
            {
                return this.dtAndPlcOfBirthField;
            }
            set
            {
                this.dtAndPlcOfBirthField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public GenericPersonIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class PersonIdentificationSchemeName1Choice
    {
        public ItemChoiceType7 itemElementNameField;
        public string itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class PositionType
    {
        public string balField;
        public PositionTypeIndx indxField;
        public string rtField;
        /// <remarks/>
        public string Bal
        {
            get
            {
                return this.balField;
            }
            set
            {
                this.balField = value;
            }
        }
        /// <remarks/>
        public PositionTypeIndx Indx
        {
            get
            {
                return this.indxField;
            }
            set
            {
                this.indxField = value;
            }
        }
        /// <remarks/>
        public string Rt
        {
            get
            {
                return this.rtField;
            }
            set
            {
                this.rtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class PositionTypeIndx
    {
        public GenericIdentification19 prtryField;
        public string rtField;
        /// <remarks/>
        public GenericIdentification19 Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
        /// <remarks/>
        public string Rt
        {
            get
            {
                return this.rtField;
            }
            set
            {
                this.rtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PostalAddress1
    {
        public string[] adrLineField;
        public AddressType2Code adrTpField;
        public bool adrTpFieldSpecified;
        public string bldgNbField;
        public string ctryField;
        public string ctrySubDvsnField;
        public string pstCdField;
        public string strtNmField;
        public string twnNmField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public string[] AdrLine
        {
            get
            {
                return this.adrLineField;
            }
            set
            {
                this.adrLineField = value;
            }
        }
        /// <remarks/>
        public AddressType2Code AdrTp
        {
            get
            {
                return this.adrTpField;
            }
            set
            {
                this.adrTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified
        {
            get
            {
                return this.adrTpFieldSpecified;
            }
            set
            {
                this.adrTpFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string BldgNb
        {
            get
            {
                return this.bldgNbField;
            }
            set
            {
                this.bldgNbField = value;
            }
        }
        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }
        /// <remarks/>
        public string CtrySubDvsn
        {
            get
            {
                return this.ctrySubDvsnField;
            }
            set
            {
                this.ctrySubDvsnField = value;
            }
        }
        /// <remarks/>
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }
        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }
        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public partial class PostalAddress6
    {
        public string[] adrLineField;
        public AddressType2Code1 adrTpField;
        public bool adrTpFieldSpecified;
        public string bldgNbField;
        public string ctryField;
        public string ctrySubDvsnField;
        public string deptField;
        public string pstCdField;
        public string strtNmField;
        public string subDeptField;
        public string twnNmField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public string[] AdrLine
        {
            get
            {
                return this.adrLineField;
            }
            set
            {
                this.adrLineField = value;
            }
        }
        /// <remarks/>
        public AddressType2Code1 AdrTp
        {
            get
            {
                return this.adrTpField;
            }
            set
            {
                this.adrTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified
        {
            get
            {
                return this.adrTpFieldSpecified;
            }
            set
            {
                this.adrTpFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string BldgNb
        {
            get
            {
                return this.bldgNbField;
            }
            set
            {
                this.bldgNbField = value;
            }
        }
        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }
        /// <remarks/>
        public string CtrySubDvsn
        {
            get
            {
                return this.ctrySubDvsnField;
            }
            set
            {
                this.ctrySubDvsnField = value;
            }
        }
        /// <remarks/>
        public string Dept
        {
            get
            {
                return this.deptField;
            }
            set
            {
                this.deptField = value;
            }
        }
        /// <remarks/>
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }
        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }
        /// <remarks/>
        public string SubDept
        {
            get
            {
                return this.subDeptField;
            }
            set
            {
                this.subDeptField = value;
            }
        }
        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PreferenceToIncome2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(PreferenceToIncome1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Price2
    {
        public YieldedOrValueType1Choice tpField;
        public PriceRateOrAmountChoice valField;
        /// <remarks/>
        public YieldedOrValueType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
        /// <remarks/>
        public PriceRateOrAmountChoice Val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PriceInformation5
    {
        public DateAndDateTimeChoice qtnDtField;
        public MarketIdentification6 srcOfPricField;
        public TypeOfPrice4Choice tpField;
        public PriceRateOrAmountOrUnknownChoice valField;
        public YieldedOrValueType1Choice valTpField;
        /// <remarks/>
        public DateAndDateTimeChoice QtnDt
        {
            get
            {
                return this.qtnDtField;
            }
            set
            {
                this.qtnDtField = value;
            }
        }
        /// <remarks/>
        public MarketIdentification6 SrcOfPric
        {
            get
            {
                return this.srcOfPricField;
            }
            set
            {
                this.srcOfPricField = value;
            }
        }
        /// <remarks/>
        public TypeOfPrice4Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
        /// <remarks/>
        public PriceRateOrAmountOrUnknownChoice Val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
        /// <remarks/>
        public YieldedOrValueType1Choice ValTp
        {
            get
            {
                return this.valTpField;
            }
            set
            {
                this.valTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PriceRateOrAmountChoice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Amt", typeof(ActiveOrHistoricCurrencyAnd13DecimalAmount))]
        [System.Xml.Serialization.XmlElementAttribute("Rate", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PriceRateOrAmountOrUnknownChoice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Amt", typeof(ActiveOrHistoricCurrencyAnd13DecimalAmount))]
        [System.Xml.Serialization.XmlElementAttribute("Rate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UknwnInd", typeof(bool))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PriceType1Choice
    {
        public ItemChoiceType4 itemElementNameField;
        public Price2 itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Indctv", typeof(Price2))]
        [System.Xml.Serialization.XmlElementAttribute("Mkt", typeof(Price2))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public Price2 Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PurposeCode1Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(SecuritiesAccountPurposeType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification13))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class PurposeCode2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(SecuritiesAccountPurposeType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Quantity6Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrgnlAndCurFace", typeof(OriginalAndCurrentQuantities1))]
        [System.Xml.Serialization.XmlElementAttribute("Qty", typeof(FinancialInstrumentQuantity1Choice))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class QuantityAndAvailability1
    {
        public bool avlbtyIndField;
        public FinancialInstrumentQuantity1Choice qtyField;
        /// <remarks/>
        public bool AvlbtyInd
        {
            get
            {
                return this.avlbtyIndField;
            }
            set
            {
                this.avlbtyIndField = value;
            }
        }
        /// <remarks/>
        public FinancialInstrumentQuantity1Choice Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class QuantityBreakdown4
    {
        public BalanceAmounts2 acctBaseCcyAmtsField;
        public BalanceAmounts2 altrnRptgCcyAmtsField;
        public BalanceAmounts2 instrmCcyAmtsField;
        public DateAndDateTimeChoice lotDtTmField;
        public Number2Choice lotNbField;
        public Price2 lotPricField;
        public FinancialInstrumentQuantity1Choice lotQtyField;
        public TypeOfPrice3Choice tpOfPricField;
        /// <remarks/>
        public BalanceAmounts2 AcctBaseCcyAmts
        {
            get
            {
                return this.acctBaseCcyAmtsField;
            }
            set
            {
                this.acctBaseCcyAmtsField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts2 AltrnRptgCcyAmts
        {
            get
            {
                return this.altrnRptgCcyAmtsField;
            }
            set
            {
                this.altrnRptgCcyAmtsField = value;
            }
        }
        /// <remarks/>
        public BalanceAmounts2 InstrmCcyAmts
        {
            get
            {
                return this.instrmCcyAmtsField;
            }
            set
            {
                this.instrmCcyAmtsField = value;
            }
        }
        /// <remarks/>
        public DateAndDateTimeChoice LotDtTm
        {
            get
            {
                return this.lotDtTmField;
            }
            set
            {
                this.lotDtTmField = value;
            }
        }
        /// <remarks/>
        public Number2Choice LotNb
        {
            get
            {
                return this.lotNbField;
            }
            set
            {
                this.lotNbField = value;
            }
        }
        /// <remarks/>
        public Price2 LotPric
        {
            get
            {
                return this.lotPricField;
            }
            set
            {
                this.lotPricField = value;
            }
        }
        /// <remarks/>
        public FinancialInstrumentQuantity1Choice LotQty
        {
            get
            {
                return this.lotQtyField;
            }
            set
            {
                this.lotQtyField = value;
            }
        }
        /// <remarks/>
        public TypeOfPrice3Choice TpOfPric
        {
            get
            {
                return this.tpOfPricField;
            }
            set
            {
                this.tpOfPricField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class ReceInvstmtFndType
    {
        public ReceInvstmtFndTypeTtlBookValChng ttlBookValChngField;
        /// <remarks/>
        public ReceInvstmtFndTypeTtlBookValChng TtlBookValChng
        {
            get
            {
                return this.ttlBookValChngField;
            }
            set
            {
                this.ttlBookValChngField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class ReceInvstmtFndTypeTtlBookValChng
    {
        public ActiveOrHistoricCurrencyAnd13DecimalAmount amtField;
        public bool sgnField;
        /// <remarks/>
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
        /// <remarks/>
        public bool Sgn
        {
            get
            {
                return this.sgnField;
            }
            set
            {
                this.sgnField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Role2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(InvestmentFundRole2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        [System.Xml.Serialization.XmlElementAttribute("Txt", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SafekeepingPlaceFormat3Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ctry", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Id", typeof(SafekeepingPlaceTypeAndText3))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification21))]
        [System.Xml.Serialization.XmlElementAttribute("TpAndId", typeof(SafekeepingPlaceTypeAndAnyBICIdentifier1))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SafekeepingPlaceTypeAndAnyBICIdentifier1
    {
        public string idField;
        public SafekeepingPlace1Code sfkpgPlcTpField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public SafekeepingPlace1Code SfkpgPlcTp
        {
            get
            {
                return this.sfkpgPlcTpField;
            }
            set
            {
                this.sfkpgPlcTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SafekeepingPlaceTypeAndText3
    {
        public string idField;
        public SafekeepingPlace3Code sfkpgPlcTpField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public SafekeepingPlace3Code SfkpgPlcTp
        {
            get
            {
                return this.sfkpgPlcTpField;
            }
            set
            {
                this.sfkpgPlcTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SecuritiesAccount11
    {
        public string dsgntField;
        public string idField;
        public string nmField;
        public PurposeCode1Choice tpField;
        /// <remarks/>
        public string Dsgnt
        {
            get
            {
                return this.dsgntField;
            }
            set
            {
                this.dsgntField = value;
            }
        }
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public PurposeCode1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SecuritiesAccount14
    {
        public string idField;
        public string nmField;
        public PurposeCode2Choice tpField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
        /// <remarks/>
        public PurposeCode2Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SecuritiesBalanceAccountingReportV04
    {
        public TotalValueInPageAndStatement2 acctBaseCcyTtlAmtsField;
        public PartyIdentification36Choice acctOwnrField;
        public PartyIdentification49Choice acctSvcrField;
        public TotalValueInPageAndStatement2 altrnRptgCcyTtlAmtsField;
        public AggregateBalanceInformation13[] balForAcctField;
        public Intermediary21[] intrmyInfField;
        public Pagination pgntnField;
        public SecuritiesAccount11 sfkpgAcctField;
        public Statement20 stmtGnlDtlsField;
        public SubAccountIdentification16[] subAcctDtlsField;
        /// <remarks/>
        public TotalValueInPageAndStatement2 AcctBaseCcyTtlAmts
        {
            get
            {
                return this.acctBaseCcyTtlAmtsField;
            }
            set
            {
                this.acctBaseCcyTtlAmtsField = value;
            }
        }
        /// <remarks/>
        public PartyIdentification36Choice AcctOwnr
        {
            get
            {
                return this.acctOwnrField;
            }
            set
            {
                this.acctOwnrField = value;
            }
        }
        /// <remarks/>
        public PartyIdentification49Choice AcctSvcr
        {
            get
            {
                return this.acctSvcrField;
            }
            set
            {
                this.acctSvcrField = value;
            }
        }
        /// <remarks/>
        public TotalValueInPageAndStatement2 AltrnRptgCcyTtlAmts
        {
            get
            {
                return this.altrnRptgCcyTtlAmtsField;
            }
            set
            {
                this.altrnRptgCcyTtlAmtsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalForAcct")]
        public AggregateBalanceInformation13[] BalForAcct
        {
            get
            {
                return this.balForAcctField;
            }
            set
            {
                this.balForAcctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IntrmyInf")]
        public Intermediary21[] IntrmyInf
        {
            get
            {
                return this.intrmyInfField;
            }
            set
            {
                this.intrmyInfField = value;
            }
        }
        /// <remarks/>
        public Pagination Pgntn
        {
            get
            {
                return this.pgntnField;
            }
            set
            {
                this.pgntnField = value;
            }
        }
        /// <remarks/>
        public SecuritiesAccount11 SfkpgAcct
        {
            get
            {
                return this.sfkpgAcctField;
            }
            set
            {
                this.sfkpgAcctField = value;
            }
        }
        /// <remarks/>
        public Statement20 StmtGnlDtls
        {
            get
            {
                return this.stmtGnlDtlsField;
            }
            set
            {
                this.stmtGnlDtlsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubAcctDtls")]
        public SubAccountIdentification16[] SubAcctDtls
        {
            get
            {
                return this.subAcctDtlsField;
            }
            set
            {
                this.subAcctDtlsField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SecuritiesPaymentStatus2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(SecuritiesPaymentStatus1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SecurityIdentification14
    {
        public string descField;
        public string iSINField;
        public OtherIdentification1[] othrIdField;
        /// <remarks/>
        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }
        /// <remarks/>
        public string ISIN
        {
            get
            {
                return this.iSINField;
            }
            set
            {
                this.iSINField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OthrId")]
        public OtherIdentification1[] OthrId
        {
            get
            {
                return this.othrIdField;
            }
            set
            {
                this.othrIdField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class ShHldgIdType
    {
        public string idField;
        public GenericIdentification20 prtryField;
        public ShHldgIdTypeTtlBookValChng ttlBookValChngField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        /// <remarks/>
        public GenericIdentification20 Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
        /// <remarks/>
        public ShHldgIdTypeTtlBookValChng TtlBookValChng
        {
            get
            {
                return this.ttlBookValChngField;
            }
            set
            {
                this.ttlBookValChngField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public partial class ShHldgIdTypeTtlBookValChng
    {
        public ActiveOrHistoricCurrencyAnd13DecimalAmount amtField;
        public bool sgnField;
        /// <remarks/>
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
        /// <remarks/>
        public bool Sgn
        {
            get
            {
                return this.sgnField;
            }
            set
            {
                this.sgnField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SimpleIdentificationInformation
    {
        public string idField;
        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class Statement20
    {
        public bool actvtyIndField;
        public bool audtdIndField;
        public Frequency4Choice frqcyField;
        public string qryRefField;
        public Number3Choice rptNbField;
        public StatementBasis3Choice stmtBsisField;
        public DateAndDateTimeChoice stmtDtTmField;
        public string stmtIdField;
        public bool subAcctIndField;
        public bool taxLotIndField;
        public bool taxLotIndFieldSpecified;
        public UpdateType2Choice updTpField;
        /// <remarks/>
        public bool ActvtyInd
        {
            get
            {
                return this.actvtyIndField;
            }
            set
            {
                this.actvtyIndField = value;
            }
        }
        /// <remarks/>
        public bool AudtdInd
        {
            get
            {
                return this.audtdIndField;
            }
            set
            {
                this.audtdIndField = value;
            }
        }
        /// <remarks/>
        public Frequency4Choice Frqcy
        {
            get
            {
                return this.frqcyField;
            }
            set
            {
                this.frqcyField = value;
            }
        }
        /// <remarks/>
        public string QryRef
        {
            get
            {
                return this.qryRefField;
            }
            set
            {
                this.qryRefField = value;
            }
        }
        /// <remarks/>
        public Number3Choice RptNb
        {
            get
            {
                return this.rptNbField;
            }
            set
            {
                this.rptNbField = value;
            }
        }
        /// <remarks/>
        public StatementBasis3Choice StmtBsis
        {
            get
            {
                return this.stmtBsisField;
            }
            set
            {
                this.stmtBsisField = value;
            }
        }
        /// <remarks/>
        public DateAndDateTimeChoice StmtDtTm
        {
            get
            {
                return this.stmtDtTmField;
            }
            set
            {
                this.stmtDtTmField = value;
            }
        }
        /// <remarks/>
        public string StmtId
        {
            get
            {
                return this.stmtIdField;
            }
            set
            {
                this.stmtIdField = value;
            }
        }
        /// <remarks/>
        public bool SubAcctInd
        {
            get
            {
                return this.subAcctIndField;
            }
            set
            {
                this.subAcctIndField = value;
            }
        }
        /// <remarks/>
        public bool TaxLotInd
        {
            get
            {
                return this.taxLotIndField;
            }
            set
            {
                this.taxLotIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxLotIndSpecified
        {
            get
            {
                return this.taxLotIndFieldSpecified;
            }
            set
            {
                this.taxLotIndFieldSpecified = value;
            }
        }
        /// <remarks/>
        public UpdateType2Choice UpdTp
        {
            get
            {
                return this.updTpField;
            }
            set
            {
                this.updTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class StatementBasis3Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(StatementBasis1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SubAccountIdentification16
    {
        public PartyIdentification36Choice acctOwnrField;
        public bool actvtyIndField;
        public AggregateBalanceInformation13[] balForSubAcctField;
        public SecuritiesAccount14 sfkpgAcctField;
        /// <remarks/>
        public PartyIdentification36Choice AcctOwnr
        {
            get
            {
                return this.acctOwnrField;
            }
            set
            {
                this.acctOwnrField = value;
            }
        }
        /// <remarks/>
        public bool ActvtyInd
        {
            get
            {
                return this.actvtyIndField;
            }
            set
            {
                this.actvtyIndField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalForSubAcct")]
        public AggregateBalanceInformation13[] BalForSubAcct
        {
            get
            {
                return this.balForSubAcctField;
            }
            set
            {
                this.balForSubAcctField = value;
            }
        }
        /// <remarks/>
        public SecuritiesAccount14 SfkpgAcct
        {
            get
            {
                return this.sfkpgAcctField;
            }
            set
            {
                this.sfkpgAcctField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SubBalanceInformation6
    {
        public AdditionalBalanceInformation6[] addtlBalBrkdwnDtlsField;
        public SubBalanceQuantity3Choice qtyField;
        public string subBalAddtlDtlsField;
        public SubBalanceType5Choice subBalTpField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlBalBrkdwnDtls")]
        public AdditionalBalanceInformation6[] AddtlBalBrkdwnDtls
        {
            get
            {
                return this.addtlBalBrkdwnDtlsField;
            }
            set
            {
                this.addtlBalBrkdwnDtlsField = value;
            }
        }
        /// <remarks/>
        public SubBalanceQuantity3Choice Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
        /// <remarks/>
        public string SubBalAddtlDtls
        {
            get
            {
                return this.subBalAddtlDtlsField;
            }
            set
            {
                this.subBalAddtlDtlsField = value;
            }
        }
        /// <remarks/>
        public SubBalanceType5Choice SubBalTp
        {
            get
            {
                return this.subBalTpField;
            }
            set
            {
                this.subBalTpField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SubBalanceQuantity3Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification22))]
        [System.Xml.Serialization.XmlElementAttribute("Qty", typeof(FinancialInstrumentQuantity1Choice))]
        [System.Xml.Serialization.XmlElementAttribute("QtyAndAvlbty", typeof(QuantityAndAvailability1))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SubBalanceType5Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(SecuritiesBalanceType12Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SubBalanceType6Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(SecuritiesBalanceType7Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SupplementaryData1
    {
        public SupplementaryDataEnvelope1 envlpField;
        public string plcAndNmField;
        /// <remarks/>
        public SupplementaryDataEnvelope1 Envlp
        {
            get
            {
                return this.envlpField;
            }
            set
            {
                this.envlpField = value;
            }
        }
        /// <remarks/>
        public string PlcAndNm
        {
            get
            {
                return this.plcAndNmField;
            }
            set
            {
                this.plcAndNmField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class SupplementaryDataEnvelope1
    {
        [XmlElement(Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
        public BalForSubAcctBrData BalForSubAcctBrData { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class TotalValueInPageAndStatement2
    {
        public AmountAndDirection6 ttlBookValOfStmtField;
        public AmountAndDirection6 ttlHldgsValOfPgField;
        public AmountAndDirection6 ttlHldgsValOfStmtField;
        /// <remarks/>
        public AmountAndDirection6 TtlBookValOfStmt
        {
            get
            {
                return this.ttlBookValOfStmtField;
            }
            set
            {
                this.ttlBookValOfStmtField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 TtlHldgsValOfPg
        {
            get
            {
                return this.ttlHldgsValOfPgField;
            }
            set
            {
                this.ttlHldgsValOfPgField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection6 TtlHldgsValOfStmt
        {
            get
            {
                return this.ttlHldgsValOfStmtField;
            }
            set
            {
                this.ttlHldgsValOfStmtField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class TypeOfPrice3Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(TypeOfPrice14Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class TypeOfPrice4Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(TypeOfPrice11Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class UpdateType2Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(StatementUpdateType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification20))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public partial class YieldedOrValueType1Choice
    {
        public object itemField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValTp", typeof(PriceValueType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Yldd", typeof(bool))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum AddressType2Code
    {
        /// <remarks/>
        ADDR,
        /// <remarks/>
        PBOX,
        /// <remarks/>
        HOME,
        /// <remarks/>
        BIZZ,
        /// <remarks/>
        MLTO,
        /// <remarks/>
        DLVY,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AddressType2Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public enum AddressType2Code1
    {
        /// <remarks/>
        ADDR,
        /// <remarks/>
        PBOX,
        /// <remarks/>
        HOME,
        /// <remarks/>
        BIZZ,
        /// <remarks/>
        MLTO,
        /// <remarks/>
        DLVY,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataCcyFwdOptnTPCD
    {
        /// <remarks/>
        FORW,
        /// <remarks/>
        NDFW,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataCorpRiskLvCD
    {
        /// <remarks/>
        LOWW,
        /// <remarks/>
        MEDI,
        /// <remarks/>
        HIGH,
        /// <remarks/>
        MEHI,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataDebeRiskLvCD
    {
        /// <remarks/>
        LOWW,
        /// <remarks/>
        MEDI,
        /// <remarks/>
        HIGH,
        /// <remarks/>
        MEHI,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataGoveRiskLvCD
    {
        /// <remarks/>
        LOWW,
        /// <remarks/>
        MEDI,
        /// <remarks/>
        HIGH,
        /// <remarks/>
        MEHI,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataGuarCD
    {
        /// <remarks/>
        BOGU,
        /// <remarks/>
        NOGU,
        /// <remarks/>
        LOGU,
        /// <remarks/>
        SHGU,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataHedgTpCD
    {
        /// <remarks/>
        NOHE,
        /// <remarks/>
        FIHE,
        /// <remarks/>
        EQHE,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflLeaseTPCD
    {
        /// <remarks/>
        AGRD,
        /// <remarks/>
        DELA,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflPropTpCD
    {
        /// <remarks/>
        INDU,
        /// <remarks/>
        COMM,
        /// <remarks/>
        STOR,
        /// <remarks/>
        MALL,
        /// <remarks/>
        HOSP,
        /// <remarks/>
        HOTE,
        /// <remarks/>
        THPA,
        /// <remarks/>
        RURA,
        /// <remarks/>
        RESI,
        /// <remarks/>
        LOTT,
        /// <remarks/>
        OTHR,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflRatBookValCode
    {
        /// <remarks/>
        NONE,
        /// <remarks/>
        DEPR,
        /// <remarks/>
        REPA,
        /// <remarks/>
        REVA,
        /// <remarks/>
        FVPP,
        /// <remarks/>
        OTHR,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflUseTpCD
    {
        /// <remarks/>
        ENTE,
        /// <remarks/>
        REIN,
        /// <remarks/>
        REFD,
        /// <remarks/>
        OWUS,
        /// <remarks/>
        OTHR,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflValtInfEvaTpCD
    {
        /// <remarks/>
        INDV,
        /// <remarks/>
        CORP,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRealStatePrtflValtInfPrtryID
    {
        /// <remarks/>
        CNPJ,
        /// <remarks/>
        CPF,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataRiskLvCD
    {
        /// <remarks/>
        LOWW,
        /// <remarks/>
        MEDI,
        /// <remarks/>
        HIGH,
        /// <remarks/>
        MEHI,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataSwapGuarCD
    {
        /// <remarks/>
        BOGU,
        /// <remarks/>
        NOGU,
        /// <remarks/>
        LOGU,
        /// <remarks/>
        SHGU,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BalForSubAcctBrDataSwapHedgTpCD
    {
        /// <remarks/>
        NOHE,
        /// <remarks/>
        FIHE,
        /// <remarks/>
        EQHE,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.anbimacom.br/BalanceForSubAccountBrazil")]
    public enum BrkTypeBrkIdBrkfSvcrTpCD
    {
        /// <remarks/>
        REEX,
        /// <remarks/>
        EXEC,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public enum CopyDuplicate1Code
    {
        /// <remarks/>
        CODU,
        /// <remarks/>
        COPY,
        /// <remarks/>
        DUPL,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum CorporateActionOption5Code
    {
        /// <remarks/>
        CASH,
        /// <remarks/>
        SECU,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum DistributionPolicy1Code
    {
        /// <remarks/>
        DIST,
        /// <remarks/>
        ACCU,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum EventFrequency3Code
    {
        /// <remarks/>
        YEAR,
        /// <remarks/>
        MNTH,
        /// <remarks/>
        QUTR,
        /// <remarks/>
        SEMI,
        /// <remarks/>
        WEEK,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum EventFrequency4Code
    {
        /// <remarks/>
        YEAR,
        /// <remarks/>
        ADHO,
        /// <remarks/>
        MNTH,
        /// <remarks/>
        DAIL,
        /// <remarks/>
        INDA,
        /// <remarks/>
        WEEK,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum FormOfSecurity1Code
    {
        /// <remarks/>
        BEAR,
        /// <remarks/>
        REGD,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum InterestComputationMethod2Code
    {
        /// <remarks/>
        A001,
        /// <remarks/>
        A002,
        /// <remarks/>
        A003,
        /// <remarks/>
        A004,
        /// <remarks/>
        A005,
        /// <remarks/>
        A006,
        /// <remarks/>
        A007,
        /// <remarks/>
        A008,
        /// <remarks/>
        A009,
        /// <remarks/>
        A010,
        /// <remarks/>
        A011,
        /// <remarks/>
        A012,
        /// <remarks/>
        A013,
        /// <remarks/>
        A014,
        /// <remarks/>
        NARR,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum InvestmentFundRole2Code
    {
        /// <remarks/>
        FMCO,
        /// <remarks/>
        REGI,
        /// <remarks/>
        TRAG,
        /// <remarks/>
        INTR,
        /// <remarks/>
        DIST,
        /// <remarks/>
        CONC,
        /// <remarks/>
        UCL1,
        /// <remarks/>
        UCL2,
        /// <remarks/>
        TRAN,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        Lng,
        /// <remarks/>
        Shrt,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        /// <remarks/>
        Dt,
        /// <remarks/>
        DtTm,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType2
    {
        /// <remarks/>
        Cd,
        /// <remarks/>
        Prtry,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType3
    {
        /// <remarks/>
        Desc,
        /// <remarks/>
        MktIdrCd,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType4
    {
        /// <remarks/>
        Indctv,
        /// <remarks/>
        Mkt,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]//, IncludeInSchema = false)]
    public enum ItemChoiceType5
    {
        /// <remarks/>
        AmtsdVal,
        /// <remarks/>
        FaceAmt,
        /// <remarks/>
        Unit,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]//, IncludeInSchema = false)]
    public enum ItemChoiceType6
    {
        /// <remarks/>
        Cd,
        /// <remarks/>
        Prtry,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]//, IncludeInSchema = false)]
    public enum ItemChoiceType7
    {
        /// <remarks/>
        Cd,
        /// <remarks/>
        Prtry,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]//, IncludeInSchema = false)]
    public enum ItemChoiceType8
    {
        /// <remarks/>
        Cd,
        /// <remarks/>
        Prtry,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]//, IncludeInSchema = false)]
    public enum ItemChoiceType9
    {
        /// <remarks/>
        Cd,
        /// <remarks/>
        Prtry,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum MarketType4Code
    {
        /// <remarks/>
        FUND,
        /// <remarks/>
        LMAR,
        /// <remarks/>
        THEO,
        /// <remarks/>
        VEND,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum MarketType5Code
    {
        /// <remarks/>
        OTCO,
        /// <remarks/>
        EXCH,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
    public enum NamePrefix1Code
    {
        /// <remarks/>
        DOCT,
        /// <remarks/>
        MIST,
        /// <remarks/>
        MISS,
        /// <remarks/>
        MADM,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum OptionStyle2Code
    {
        /// <remarks/>
        AMER,
        /// <remarks/>
        EURO,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum OptionType1Code
    {
        /// <remarks/>
        CALL,
        /// <remarks/>
        PUTO,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum PreferenceToIncome1Code
    {
        /// <remarks/>
        ORDN,
        /// <remarks/>
        PFRD,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum PriceValueType1Code
    {
        /// <remarks/>
        DISC,
        /// <remarks/>
        PREM,
        /// <remarks/>
        PARV,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SafekeepingPlace1Code
    {
        /// <remarks/>
        CUST,
        /// <remarks/>
        ICSD,
        /// <remarks/>
        NCSD,
        /// <remarks/>
        SHHE,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SafekeepingPlace3Code
    {
        /// <remarks/>
        SHHE,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SecuritiesAccountPurposeType1Code
    {
        /// <remarks/>
        MARG,
        /// <remarks/>
        SHOR,
        /// <remarks/>
        ABRD,
        /// <remarks/>
        CEND,
        /// <remarks/>
        DVPA,
        /// <remarks/>
        PHYS,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SecuritiesBalanceType12Code
    {
        /// <remarks/>
        BLOK,
        /// <remarks/>
        AWAS,
        /// <remarks/>
        BLCA,
        /// <remarks/>
        BLOT,
        /// <remarks/>
        BLOV,
        /// <remarks/>
        BORR,
        /// <remarks/>
        BODE,
        /// <remarks/>
        BORE,
        /// <remarks/>
        COLI,
        /// <remarks/>
        COLO,
        /// <remarks/>
        LOAN,
        /// <remarks/>
        LODE,
        /// <remarks/>
        LORE,
        /// <remarks/>
        MARG,
        /// <remarks/>
        PECA,
        /// <remarks/>
        PEDA,
        /// <remarks/>
        PEND,
        /// <remarks/>
        PENR,
        /// <remarks/>
        PLED,
        /// <remarks/>
        REGO,
        /// <remarks/>
        RSTR,
        /// <remarks/>
        OTHR,
        /// <remarks/>
        TRAN,
        /// <remarks/>
        DRAW,
        /// <remarks/>
        WDOC,
        /// <remarks/>
        BTRA,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SecuritiesBalanceType7Code
    {
        /// <remarks/>
        COLA,
        /// <remarks/>
        OTHR,
        /// <remarks/>
        CLEN,
        /// <remarks/>
        DIRT,
        /// <remarks/>
        NOMI,
        /// <remarks/>
        SPOS,
        /// <remarks/>
        UNRG,
        /// <remarks/>
        ISSU,
        /// <remarks/>
        QUAS,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum SecuritiesPaymentStatus1Code
    {
        /// <remarks/>
        FULL,
        /// <remarks/>
        NILL,
        /// <remarks/>
        PART,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum ShortLong1Code
    {
        /// <remarks/>
        SHOR,
        /// <remarks/>
        LONG,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum StatementBasis1Code
    {
        /// <remarks/>
        CONT,
        /// <remarks/>
        SETT,
        /// <remarks/>
        TRAD,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum StatementUpdateType1Code
    {
        /// <remarks/>
        COMP,
        /// <remarks/>
        DELT,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum TypeOfPrice11Code
    {
        /// <remarks/>
        BIDE,
        /// <remarks/>
        OFFR,
        /// <remarks/>
        NAVL,
        /// <remarks/>
        CREA,
        /// <remarks/>
        CANC,
        /// <remarks/>
        INTE,
        /// <remarks/>
        SWNG,
        /// <remarks/>
        MIDD,
        /// <remarks/>
        RINV,
        /// <remarks/>
        SWIC,
        /// <remarks/>
        MRKT,
        /// <remarks/>
        INDC,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.04")]
    public enum TypeOfPrice14Code
    {
        /// <remarks/>
        AVER,
    }
}