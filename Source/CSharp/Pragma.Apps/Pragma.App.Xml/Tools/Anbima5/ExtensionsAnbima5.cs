//using Pragma.App.Xml.Models.Anbima4;
//using Pragma.App.Xml.Models.Anbima5;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;

//namespace PGM.Xml.Tools.Anbima5
//{
//    public static class ExtensionsAnbima5
//    {
//        public static TSelf CopyChoiceProperties<TSelf>(this TSelf tSelf, object tObj, Type choiceType)
//        {

//            if (tObj != null)
//            {
//                var item = tObj.GetType().GetProperty("Item").GetValue(tObj);
//                if (item != null && item.GetType() == choiceType)
//                {
//                    if (tSelf == null)
//                    {
//                        tSelf = choiceType == typeof(string) ? (TSelf)Activator.CreateInstance(typeof(TSelf), new object[] { 'a', 0 }) : (TSelf)Activator.CreateInstance(typeof(TSelf));
//                    }

//                    var converter = tSelf.GetType().GetMethod("op_Implicit", new[] { choiceType });

//                    if (converter != null)
//                    {
//                        tSelf = (TSelf)converter.Invoke(null, new[] { item });
//                    }
//                    else
//                    {
//                        try
//                        {
//                            tSelf = (TSelf)item;
//                        }
//                        catch (InvalidCastException)
//                        {
//                            tSelf.CopyProperties(item);
//                        }
//                    }
//                }
//            }
//            return tSelf;
//        }
//        public static TSelf CopyChoiceProperties<TSelf>(this TSelf tSelf, object tObj)
//        {
//            if (tObj != null)
//            {
//                var item = tObj.GetType().GetProperty("Item").GetValue(tObj);
//                if (item != null && item is Enum)
//                {
//                    tSelf = (TSelf)item;
//                }
//            }
//            return tSelf;
//        }
//        public static object GetChoice<T>(this T tObj, Type choiceType)
//        {
//            object r = null;
//            if (tObj != null)
//            {
//                var item = tObj.GetType().GetProperty("Item").GetValue(tObj);
//                if (item != null && item.GetType() == choiceType)
//                {
//                    r = item;
//                }
//            }
//            return r;
//        }
//        public static object GetChild<T>(this T tObj, string childName)
//        {
//            object r = null;
//            if (tObj != null)
//            {
//                var item = tObj.GetType().GetProperty(childName).GetValue(tObj);
//                if (item != null)
//                {
//                    r = item;
//                }
//            }
//            return r;
//        }
//        public static T ConvertValue<T>(this T tObj, object value)
//        {
//            if (value != null)
//            {
//                tObj = (T)value;
//            }
//            return tObj;
//        }

//        #region XML 5.0 De/Para

//        public static XMLAnbima4 GetAnbima4(this DbXMLGalgoAssBalStmt galgo)
//        {
//            var repoAtivos = PgmInjector.GetInstance<ISysRepository<DbInvestAtivo>>();
//            if (galgo == null) return null;

//            var fundo = new Fundo();

//            //Fundo
//            var balance = galgo?.SctiesBalAcctgRpt?.BalForAcct?.First();
//            if (balance != null)
//            {
//                //Header
//                fundo.Header.Add(new Header
//                {

//                    Isin = balance.FinInstrmId?.ISIN,
//                    Cnpj = balance.FinInstrmId?.OthrId?.Find(i => i.Item.Equals("CNPJ"))?.Id,
//                    Nome = balance.FinInstrmId?.Desc,
//                    DtPosicao = galgo.SctiesBalAcctgRpt?.StmtGnlDtls?.Item.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                    NomeAdm = "",
//                    CnpjAdm = galgo.SctiesBalAcctgRpt?.AcctOwnrPrtryId?.Id,
//                    NomeGestor = "",
//                    CnpjGestor = galgo.SctiesBalAcctgRpt?.AcctSvcrPrtryId?.Id,
//                    NomeCustodiante = galgo.SctiesBalAcctgRpt?.SfkpgAcct?.Nm,
//                    CnpjCustodiante = galgo.SctiesBalAcctgRpt?.SfkpgAcct?.Id,
//                    ValorCota = decimal.Parse(balance.PricDtls?.Find(i => i.Cd == TypeOfPrice11Code.NAVL)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                    Quantidade = decimal.Parse(balance.AggtBal?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                    PatLiq = decimal.Parse(galgo.SctiesBalAcctgRpt?.AcctBaseCcyTtlAmts?.TtlHldgsValOfStmt?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)galgo.SctiesBalAcctgRpt?.AcctBaseCcyTtlAmts?.TtlHldgsValOfStmt?.Sgn ? 1 : -1),
//                    ValorAtivos = decimal.Parse(balance.AcctBaseCcyAmts?.HldgVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)balance.AcctBaseCcyAmts?.HldgVal?.Sgn ? 1 : -1),
//                    ValorReceber = 0,
//                    ValorPagar = 0,
//                    VlCotasEmitir = 0,
//                    VlCotasResgatar = 0,
//                    CodAnbid = 0,
//                    TipoFundo = 0,
//                    NivelRsc = ""
//                });

//                //PagRec
//                var pagRec = balance.BalBrkdwn;
//                foreach (var balBreakdown in pagRec)
//                {
//                    var balType = balBreakdown.SubBalTpPrtry?.Id ?? "";

//                    if (balType.Equals("EXPN"))
//                    {
//                        //Despesas
//                        fundo.Despesas.Add(new Despesas
//                        {
//                            TxAdm = decimal.Parse(balBreakdown.AddtlBalBrkdwnDtls?.Find(i => i.SubBalTpPrtry.Id.Equals("MANF")).Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                            Tributos = 0,
//                            PercTaxaAdm = decimal.Parse(balance.SplmtryData?.First()?.BalForSubAcctBrData?.Expn?.MgmtFeeRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                            TxPerf = "",
//                            VltxPerf = 0,
//                            PercTxPerf = 0,
//                            PercIndex = 0,
//                            OutTax = 0,
//                            Indexador = balance.SplmtryData?.Find(i => true)?.BalForSubAcctBrData?.Expn?.EqulIndex?.Find(i => true)?.Prtry?.Id
//                        });

//                        //OutrasDespesas
//                        foreach (var outDesp in balBreakdown.AddtlBalBrkdwnDtls)
//                        {
//                            if (outDesp.SubBalTpPrtry.Id.Equals("MANF")) continue;

//                            fundo.OutrasDespesas.Add(new OutrasDespesas
//                            {
//                                CodDesp = GetCodigo(outDesp.SubBalTpPrtry),
//                                Valor = decimal.Parse(outDesp.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)
//                            });
//                        }
//                    }

//                    //Provisoes
//                    if (balType.Equals("RECE") || balType.Equals("PAYA"))
//                    {
//                        var count = 0;
//                        foreach (var prov in balBreakdown.AddtlBalBrkdwnDtls)
//                        {
//                            var p = new Provisao
//                            {
//                                CodProv = GetCodigo(prov.SubBalTpPrtry, balType),
//                                CreDeb = (balType.Equals("PAYA") || prov.SubBalTpPrtry.Id.Equals("SECU") ? "D" : "C"),
//                                Dt = prov.SubBalAddtlDtls.Replace("-", ""),
//                                Valor = decimal.Parse(prov.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)
//                            };

//                            //Somar provisoes (cod 8)
//                            if (p.CodProv == 8 && fundo.Provisao.Count(i => i.CodProv == 8) > 0)
//                            {
//                                var despAdm = fundo.Provisao.First(i => i.CodProv == 8);
//                                //Somar valores
//                                despAdm.Valor += p.Valor * (p.CreDeb.Equals(despAdm.CreDeb) ? 1 : -1);
//                                //Trocar Credeb se valor<0
//                                if (despAdm.Valor < 0)
//                                {
//                                    despAdm.CreDeb = despAdm.CreDeb.Equals("C") ? "D" : "C";
//                                    despAdm.Valor *= -1;
//                                }
//                                continue;
//                            }

//                            if (p.CreDeb.Equals("D"))
//                            {
//                                fundo.Provisao.Add(p);
//                            }
//                            else
//                            {
//                                fundo.Provisao.Insert(count++, p);
//                            }
//                        }
//                    }
//                }

//                //Corretagem
//                var corr = balance.SplmtryData?.First().BalForSubAcctBrData?.Brk?.Count > 0 ? balance.SplmtryData?.First().BalForSubAcctBrData?.Brk?.First() : null;
//                if (corr != null)
//                {
//                    fundo.Corretagem.Add(new Corretagem
//                    {

//                        CnpjCorretora = corr.Id ?? "",
//                        TpCorretora = 0,
//                        NumOpe = int.Parse(corr.TransactionNb),
//                        VlBov = decimal.Parse(corr.Brkr?.First().BrkrPdVlValue ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        VlRepasseBov = 0,
//                        Vlbmf = 0,
//                        VlRepassebmf = 0,
//                        VlOutbolsas = 0,
//                        VlRepasseoutbol = 0
//                    });
//                }
//            }

//            //Ativos
//            var ativos = galgo?.SctiesBalAcctgRpt?.SubAcctDtls?.First()?.BalForSubAcct;
//            var debeListPRE = new List<Debenture>();
//            var debeListTJL = new List<Debenture>();
//            foreach (var ativo in ativos)
//            {
//                var tipoAtivo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("TABELA NIVEL 1"))?.Id ?? "";
//                var idLastro = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("TABELA NIVEL 2"))?.Id ?? "";
//                var idRepAgr = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("TABELA NIVEL 3"))?.Id ?? "";
//                //Titulos publicos
//                if (tipoAtivo.Equals("GOVE") || (tipoAtivo.Equals("REPO") && idLastro.Equals("GOVE")))
//                {
//                    var a = new TitPublico
//                    {
//                        Isin = GetISIN(ativo),
//                        CodAtivo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("SELC"))?.Id ?? "",
//                        Cusip = "",
//                        DtEmissao = ativo.FinInstrmAttrbts?.IsseDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        DtOperacao = ativo.PricDtls.Find(i => i.ItemElementName == ItemChoiceType1.Dt)?.Item.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        DtVencimento = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        QtDisponivel = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        QtGarantia = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Depgar = 0,
//                        PuCompra = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.OFFR)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        PuVencimento = 0,
//                        PuPosicao = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT || i.Cd == TypeOfPrice11Code.INDC)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        PuEmissao = decimal.Parse(ativo.FinInstrmAttrbts?.SbcptPric?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Principal = decimal.Parse(ativo.AcctBaseCcyAmts?.BookVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)(ativo.AcctBaseCcyAmts?.BookVal?.Sgn ?? true) ? 1 : -1),
//                        //TODO: Achar um exemplo de uso.
//                        Tributos = 0,
//                        ValorFinDisp = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        ValorFinEmgar = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Coupom = decimal.Parse(ativo.FinInstrmAttrbts?.IntrstRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Indexador = ativo.FinInstrmAttrbts?.CpnAttchdNbLng?.Id,
//                        PercIndex = decimal.Parse(ativo.FinInstrmAttrbts?.IndxRateBsis ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Caracteristica = "",
//                        PercProvcred = 0,
//                        ClasseOperacao = "",
//                        IdInternoAtivo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("IdInternoAtivo"))?.Id ?? ""
//                    };

//                    //Subsecao Compromisso
//                    if (!tipoAtivo.Equals("GOVE"))
//                    {
//                        a.DtEmissao = "";
//                        a.DtOperacao = ativo.FinInstrmAttrbts?.IsseDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
//                        a.DtVencimento = "";
//                        a.QtDisponivel = decimal.Parse(ativo.AggtBal?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                        a.Principal = decimal.Parse(ativo.AcctBaseCcyAmts?.HldgVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)ativo.AcctBaseCcyAmts?.HldgVal?.Sgn ? 1 : -1);
//                        a.Coupom = 0;

//                        a.Compromisso = new Compromisso
//                        {
//                            DtRetorno = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                            PuRetorno = decimal.Parse(ativo.AcctBaseCcyAmts?.HldgVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) / decimal.Parse(ativo.AggtBal?.Item),
//                            IndexAdorComp = ativo.FinInstrmAttrbts?.CpnAttchdNbLng?.Id,
//                            PerIndexComp = 100,
//                            TxOperacao = decimal.Parse(ativo.FinInstrmAttrbts?.IntrstRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                            //TODO: Achar uso V
//                            ClasseComp = "C"
//                        };
//                    }

//                    if (tipoAtivo.Equals("GOVE"))
//                    {
//                        a.NivelRsc = ((RiskLevel)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.GoveRiskLvCd).ToString();
//                    }
//                    else
//                    {
//                        a.NivelRsc = ((RiskLevel)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.RiskLvCd).ToString();
//                    }
//                    fundo.TitPublico.Add(a);
//                }

//                //Titulos Privados
//                //TODO: Terminar Titulos Publicos e copiar estrutura basica
//                if ((tipoAtivo.Equals("CORP") || (tipoAtivo.Equals("REPO") && idLastro.Equals("CORP"))) && ativo.FinInstrmId?.ISIN != null)
//                {
//                    var a = new TitPrivado
//                    {
//                        Isin = GetISIN(ativo),
//                        CodAtivo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("CETI"))?.Id,
//                        Cusip = "",
//                        DtEmissao = ativo.FinInstrmAttrbts?.IsseDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
//                    };
//                    if (tipoAtivo.Equals("CORP"))
//                    {
//                        a.DtOperacao = ativo.PricDtls.Find(i => i.ItemElementName == ItemChoiceType1.Dt).Item.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
//                    }
//                    else
//                    {
//                        ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
//                    }

//                    a.DtVencimento = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
//                    //CNPJ EMISSOR
//                    a.QtDisponivel = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.QtGarantia = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.Depgar = 0;
//                    a.PuCompra = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.OFFR)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.PuVencimento = decimal.Parse(ativo.FinInstrmAttrbts?.ConvsPric?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.PuPosicao = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.PuEmissao = decimal.Parse(ativo.FinInstrmAttrbts?.SbcptPric?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.Principal = decimal.Parse(ativo.AcctBaseCcyAmts?.BookVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    //TODO: Achar um exemplo de uso.
//                    a.Tributos = 0;
//                    a.ValorFinDisp = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.ValorFinEmgar = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.Coupom = decimal.Parse(ativo.FinInstrmAttrbts?.IntrstRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.Indexador = ativo.FinInstrmAttrbts?.CpnAttchdNbLng?.Id;
//                    a.PercIndex = decimal.Parse(ativo.FinInstrmAttrbts?.IndxRateBsis ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                    a.Caracteristica = "N";
//                    a.PercProvcred = 0;

//                    //Subsecao Compromisso
//                    if (!tipoAtivo.Equals("CORP"))
//                    {
//                        a.Compromisso = new Compromisso();

//                        a.Compromisso.DtRetorno = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
//                        a.Compromisso.PuRetorno = decimal.Parse(ativo.AcctBaseCcyAmts?.HldgVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) / decimal.Parse(ativo.AggtBal?.Item);
//                        a.Compromisso.IndexAdorComp = ativo.FinInstrmAttrbts?.CpnAttchdNbLng?.Id;
//                        //TODO: Find
//                        a.Compromisso.PerIndexComp = 100;
//                        a.Compromisso.TxOperacao = decimal.Parse(ativo.FinInstrmAttrbts?.IntrstRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
//                        //TODO: Achar uso V
//                        a.Compromisso.ClasseComp = "C";
//                    }

//                    a.ClasseOperacao = "";
//                    a.IdInternoAtivo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("IdInternoAtivo"))?.Id;
//                    if (tipoAtivo.Equals("CORP"))
//                    {
//                        a.NivelRsc = ((RiskLevel)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.CorpRiskLvCd).ToString();
//                    }
//                    else
//                    {
//                        a.NivelRsc = ((RiskLevel)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.RiskLvCd).ToString();
//                    }

//                    //CNPJ EMISSOR
//                    a.CnpjEmissor = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("CNPJ"))?.Id ?? "00000000000000";

//                    fundo.TitPrivado.Add(a);
//                }

//                //Debentures
//                if (tipoAtivo.Equals("DEBE"))
//                {
//                    var idInterno = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("IdInternoAtivo"))?.Id;
//                    var qtDisp = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);

//                    //Checar se o item já existe
//                    if (debeListPRE.Count(i => i.IdInternoAtivo == idInterno && i.QtDisponivel == qtDisp) > 0 || debeListTJL.Count(i => i.IdInternoAtivo == idInterno && i.QtDisponivel == qtDisp) > 0)
//                        continue;

//                    var a = new Debenture
//                    {

//                        Isin = GetISIN(ativo),
//                        Coddeb = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("BVMF"))?.Id,
//                        Debconv = (bool)ativo.SplmtryData?.First()?.BalForSubAcctBrData.ConvInd ? "S" : "N",
//                        DebpartLucro = (bool)ativo.SplmtryData?.First()?.BalForSubAcctBrData.ProfSharInd ? "S" : "N",
//                        SPE = (bool)ativo.SplmtryData?.First()?.BalForSubAcctBrData.SpeInd ? "S" : "N",
//                        Cusip = "",
//                        DtEmissao = ativo.FinInstrmAttrbts?.IsseDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        DtOperacao = ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.OFFR)?.Item.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        DtVencimento = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        CnpjEmissor = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("CNPJ"))?.Id ?? "00000000000000",
//                        QtDisponivel = qtDisp,
//                        QtGarantia = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        //TODO: Achar exemplo != 0
//                        Depgar = 0,
//                        PuCompra = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.OFFR)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        //TODO: Achar exemplo != 0
//                        PuVencimento = 0,
//                        PuPosicao = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        PuEmissao = decimal.Parse(ativo.FinInstrmAttrbts?.SbcptPric?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Principal = decimal.Parse(ativo.AcctBaseCcyAmts?.BookVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)ativo.AcctBaseCcyAmts?.BookVal?.Sgn ? 1 : -1),
//                        Tributos = 0,
//                        //TODO: OR BalBrkdwn/AddtlBalBrkdwnDtls/Qty/Qty/FaceAmt
//                        ValorFinDisp = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.AddtlBalBrkdwnDtls.First().Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        ValorFinEmgar = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.AddtlBalBrkdwnDtls.First().Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Coupom = decimal.Parse(ativo.FinInstrmAttrbts?.IntrstRate ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Indexador = ativo.FinInstrmAttrbts?.CpnAttchdNbLng?.Id,
//                        PercIndex = decimal.Parse(ativo.FinInstrmAttrbts?.IndxRateBsis ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Caracteristica = "N",
//                        PercProvcred = 0,
//                        Compromisso = new List<Compromisso>(),
//                        ClasseOperacao = "",
//                        IdInternoAtivo = idInterno,
//                        NivelRsc = ""
//                    };

//                    if (a.Indexador.Equals("PRE"))
//                    {
//                        debeListPRE.Add(a);
//                    }
//                    else
//                    {
//                        debeListTJL.Add(a);
//                    }
//                }

//                //Acoes
//                if (tipoAtivo.Equals("EQUI"))
//                {
//                    var isin = GetISIN(ativo);
//                    var a = repoAtivos.Single(i => i.CdIsin.Equals(isin));
//                    fundo.Acoes.Add(new Acoes
//                    {
//                        Isin = isin,
//                        Cusip = "",
//                        Codativo = repoAtivos.Single(i => i.CdIsin.Equals(isin)).PkId,
//                        QtDisponivel = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Lote = int.Parse(ativo.QtyBrkdwn?.First()?.LotQtyItem),
//                        QtGarantia = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        ValorFindisp = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        ValorFinemgar = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.AddtlBalBrkdwnDtls?.First()?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Tributos = 0,
//                        PuPosicao = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        PercProvcred = 0,
//                        //TODO: achar exemplo de uso de tipo 2
//                        TpConta = 1,
//                        ClasseOperacao = "",
//                        //TODO: achar exemplo de uso
//                        DtVencalug = "",
//                        TxAlug = 0,
//                        CnpjInter = "00000000000000"
//                    });
//                }

//                //Futuros
//                if (tipoAtivo.Equals("FUTU"))
//                {
//                    fundo.Futuros.Add(new Futuros
//                    {
//                        Isin = GetISIN(ativo),
//                        Ativo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("BVMF"))?.Id,
//                        CnpjCorretora = ativo.Id,
//                        Serie = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("BVMF"))?.Sfx,
//                        Quantidade = decimal.Parse(ativo.AggtBal?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        VlTotalpos = decimal.Parse(ativo.AddtlDerivAttrbts?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Tributos = 0,
//                        DtVencimento = ativo.FinInstrmAttrbts?.MtrtyDt.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
//                        VlAjuste = decimal.Parse(ativo.AcctBaseCcyAmts?.HldgVal?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * ((bool)ativo.AcctBaseCcyAmts?.HldgVal?.Sgn ? 1 : -1),
//                        ClasseOperacao = "",
//                        Hedge = ativo.SplmtryData?.First()?.BalForSubAcctBrData?.HedgTpCd > 0 ? "S" : "N",
//                        TpHedge = (int)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.HedgTpCd
//                    });
//                }

//                //Caixa
//                if (tipoAtivo.Equals("CASH"))
//                {
//                    fundo.Caixa.Add(new Caixa
//                    {
//                        IsinInstituicao = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("Instituicao Financeira"))?.Id,
//                        TpConta = ativo.FinInstrmAttrbts?.AltrnClssfctn?.Id,
//                        Saldo = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Nivelrsc = ((RiskLevel)ativo.SplmtryData?.First()?.BalForSubAcctBrData?.RiskLvCd).ToString()
//                    });
//                }

//                //Cotas
//                if (tipoAtivo.Equals("SHAR"))
//                {
//                    fundo.Cotas.Add(new Cotas
//                    {
//                        Isin = GetISIN(ativo),
//                        CnpjFundo = ativo.FinInstrmId?.OthrId.Find(i => i.Item.Equals("CNPJ"))?.Id ?? "00000000000000",
//                        QtDisponivel = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.AWAS)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        QtGarantia = decimal.Parse(ativo.BalBrkdwn?.Find(i => i.Cd12 == SecuritiesBalanceType12Code.BLOK)?.Item ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        PuPosicao = decimal.Parse(ativo.PricDtls.Find(i => i.Cd == TypeOfPrice11Code.MRKT)?.Value ?? "0", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture),
//                        Tributos = 0,
//                        NivelRsc = ""
//                    });
//                }
//            }
//            //Adicionar debentures na ordem certa
//            fundo.Debenture.AddRange(debeListPRE);
//            fundo.Debenture.AddRange(debeListTJL.OrderBy(i => i.IdInternoAtivo));

//            return new XMLAnbima4
//            {
//                Fundo = fundo
//            };
//        }

//        private static int GetCodigo(DbXMLGenericIdentification prtry)
//        {
//            var cod = (int)Enum.Parse(typeof(ChargeTypeCode), prtry.Id);

//            if (cod == 12 && prtry.SchmeNm.Equals("Regulatory Fee - CVM")) return 14;
//            //if (cod == 45 && prtry.SchmeNm.Equals("Awaiting Settlement Date")) return 47;
//            //cod 46
//            if (cod == 18)
//            {
//                var ativo = prtry.SchmeNm.Split('-').Last().Trim(' ');
//                if (ativo.Equals("GOVE")) return 18; //Titulos Públicos
//                if (ativo.Equals("CORP")) return 19; //Titulos Privados
//                if (ativo.Equals("DEBE")) return 20; //Debêntures
//                if (ativo.Equals("EQUI") || ativo.Equals("OPTNEQUI")) return 21; //Ações ou Opções Ações
//                if (ativo.Equals("DERI")) return 22; //Derivativos(Opções Deriv.ou Flexiveis ou Futuros)
//                if (ativo.Equals("FWRDEQUI")) return 23; //Termo Ações
//                if (ativo.Equals("FWRDSELI")) return 24; //Termo Selic
//                if (ativo.Equals("SWAP")) return 26; //Swap
//                if (ativo.Equals("LOANEQUI")) return 31; //Emprestimo Ação
//                if (ativo.Equals("LOANGOVE")) return 32; //Emprestimo Titulo Público

//            }

//            return cod;
//        }

//        private static int GetCodigo(DbXMLGenericIdentification prtry, string type)
//        {
//            var cod = (int)Enum.Parse(typeof(ChargeTypeCode), prtry.Id);

//            if (cod == 45 && type.Equals("PAYA")) return 47;
//            //cod 46

//            return GetCodigo(prtry);
//        }

//        private static string GetISIN(DbXMLAggregateBalanceInformation ativo)
//        {
//            return ativo?.FinInstrmId?.ISIN?.PadRight(12, '*') ?? "";
//        }

//        #endregion
//    }

//}
