using Pragma.App.DAO;
using Pragma.App.DAO.Repositories;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class DaoBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            #region ComboUnitOfWork
            container.Register<IComboUnitOfWork, ComboUnitOfWork>();

            container.Register<IConnectionsRepository, ConnectionsRepository>();
            #endregion

            #region UserUnitOfWork
            container.Register<IDireitosUnitOfWork, DireitosUnitOfWork>();

            container.Register<IUsuarioGrupoRepository, UsuarioGrupoRepository>();
            container.Register<IUsuarioLoginRepository, UsuarioLoginRepository>();
            container.Register<IUsuarioLoginGrupoRepository, UsuarioLoginGrupoRepository>();

            container.Register<IMenuSistemaRepository, MenuSistemaRepository>();
            #endregion

            #region PowerPointUnitOfWork
            container.Register<IPowerPointUnitOfWork, PowerPointUnitOfWork>();

            container.Register<IPptPaginaRepository, PptPaginaRepository>();
            container.Register<IPptPaginaImportadaRepository, PptPaginaImportadaRepository>();
            container.Register<IPptRelatorioRepository, PptRelatorioRepository>();
            container.Register<IPptRelatorioInvestimentoRepository, PptRelatorioInvestimentoRepository>();
            container.Register<IPptRelatorioPaginaRepository, PptRelatorioPaginaRepository>();
            container.Register<IPptRotinaRepository, PptRotinaRepository>();
            container.Register<IPptRelatorioTextoRepository, PptRelatorioTextoRepository>();
            #endregion

            #region FinanceUnitOfWork
            container.Register<IFinanceUnitOfWork, FinanceUnitOfWork>();

            container.Register<IIndiceRepository, IndiceRepository>();
            container.Register<IIndiceCotacaoRepository, IndiceCotacaoRepository>();
            #endregion

            #region SysUnitOfWork
            container.Register<ISysUnitOfWork, SysUnitOfWork>();
            container.Register<IControleRepository, ControleRepository>();
            container.Register<IAjudaSistemaRepository, AjudaSistemaRepository>();
            //container.Register<IMenuSistemaRepository, MenuSistemaRepository>();
            container.Register<IParametrosRepository, ParametrosRepository>();
            #endregion

            container.Register<IMenuUnitOfWork, MenuUnitOfWork>();



            container.Register<IAjusteRepository, AjusteRepository>();
            container.Register<IAlavancagemRepository, AlavancagemRepository>();
            container.Register<IAlavancagemItemRepository, AlavancagemItemRepository>();
            container.Register<IAluguelRepository, AluguelRepository>();
            container.Register<IAtivoRepository, AtivoRepository>();
            container.Register<IAtivoClasseRepository, AtivoClasseRepository>();
            container.Register<IAtivoClassificacaoRepository, AtivoClassificacaoRepository>();
            container.Register<IAtivoConjuntoRepository, AtivoConjuntoRepository>();
            container.Register<IAtivoCotacaoRepository, AtivoCotacaoRepository>();
            container.Register<IAtivoExternoRepository, AtivoExternoRepository>();
            container.Register<IAtivoIsentoRepository, AtivoIsentoRepository>();
            container.Register<IAtivoLiquidezRepository, AtivoLiquidezRepository>();
            container.Register<IAtivoLiquidezRegraRepository, AtivoLiquidezRegraRepository>();
            container.Register<IAtivoRegiaoRepository, AtivoRegiaoRepository>();
            container.Register<IAtivoSeparacaoRepository, AtivoSeparacaoRepository>();
            container.Register<IAtivoSubClasseRepository, AtivoSubClasseRepository>();
            container.Register<IAtivoTipoRepository, AtivoTipoRepository>();
            container.Register<IAtivoTipoControleRepository, AtivoTipoControleRepository>();
            container.Register<IBoletaRepository, BoletaRepository>();
            container.Register<ICadunicoRepository, CadunicoRepository>();
            container.Register<ICidadeNovoRepository, CidadeNovoRepository>();
            container.Register<IClubeXContaRepository, ClubeXContaRepository>();
            container.Register<IConciliacaoErroRepository, ConciliacaoErroRepository>();
            container.Register<IConciliacaoExecucaoRepository, ConciliacaoExecucaoRepository>();
            container.Register<IConciliacaoJustificativaRepository, ConciliacaoJustificativaRepository>();
            container.Register<IConciliacaoMotivoRepository, ConciliacaoMotivoRepository>();
            container.Register<IConciliacaoResultadoRepository, ConciliacaoResultadoRepository>();
            container.Register<IConferenciaRepository, ConferenciaRepository>();
            container.Register<IContaRepository, ContaRepository>();
            container.Register<IConversaoMoedaRepository, ConversaoMoedaRepository>();
            container.Register<ICotaEspecialRepository, CotaEspecialRepository>();
            container.Register<ICotaOficialRepository, CotaOficialRepository>();
            container.Register<ICotaOficialDivulgacaoRepository, CotaOficialDivulgacaoRepository>();
            container.Register<ICotistaRepository, CotistaRepository>();
            container.Register<ICotSaldoRepository, CotSaldoRepository>();
            container.Register<IEmpresaRepository, EmpresaRepository>();
            container.Register<IEmpresaInstituicaoRepository, EmpresaInstituicaoRepository>();
            container.Register<IEmpresaTipoRepository, EmpresaTipoRepository>();
            container.Register<IEstCotaRepository, EstCotaRepository>();
            container.Register<IEstrategiaRepository, EstrategiaRepository>();
            container.Register<IExemploRepository, ExemploRepository>();
            container.Register<IFacAnbidRepository, FacAnbidRepository>();
            container.Register<IFechamentoRepository, FechamentoRepository>();
            container.Register<IFeriadoRepository, FeriadoRepository>();
            container.Register<IFeriadoGenericoRepository, FeriadoGenericoRepository>();
            container.Register<IFundoCotacaoRepository, FundoCotacaoRepository>();
            container.Register<IGalgoRepository, GalgoRepository>();
            container.Register<IGalgoLogRepository, GalgoLogRepository>();
            container.Register<IInstituicaoRepository, InstituicaoRepository>();
            container.Register<IInvestAtivoRepository, InvestAtivoRepository>();
            container.Register<IInvestCarteiraRepository, InvestCarteiraRepository>();
            container.Register<IInvestFechamentoRepository, InvestFechamentoRepository>();
            container.Register<IInvestimentoRepository, InvestimentoRepository>();
            container.Register<IInvestimentoMandatoRepository, InvestimentoMandatoRepository>();
            container.Register<IInvestimentoPosicaoRepository, InvestimentoPosicaoRepository>();
            container.Register<IInvestimentoTipoRepository, InvestimentoTipoRepository>();
            container.Register<ILiquidacaoFormaRepository, LiquidacaoFormaRepository>();
            container.Register<ILiquidacaoModoRepository, LiquidacaoModoRepository>();
            container.Register<ILiquidacaoTipoRepository, LiquidacaoTipoRepository>();
            container.Register<ILiquidezPeriodoRepository, LiquidezPeriodoRepository>();
            container.Register<ILogUsuarioRepository, LogUsuarioRepository>();
            container.Register<IMandatoRepository, MandatoRepository>();
            container.Register<IMandatoItemRepository, MandatoItemRepository>();
            container.Register<IMandatoVersaoRepository, MandatoVersaoRepository>();

            container.Register<IMoedaRepository, MoedaRepository>();
            container.Register<IMoedaIndiceRepository, MoedaIndiceRepository>();
            container.Register<IMovCartRepository, MovCartRepository>();
            container.Register<IMovCotaRepository, MovCotaRepository>();
            container.Register<IMovimentacaoEventoRepository, MovimentacaoEventoRepository>();
            container.Register<IMovimentacaoStatusRepository, MovimentacaoStatusRepository>();
            container.Register<IMovimentacaoStatusEtapasRepository, MovimentacaoStatusEtapasRepository>();
            container.Register<IMovimentoAtivoRepository, MovimentoAtivoRepository>();
            container.Register<IMovimentoAtivoItemRepository, MovimentoAtivoItemRepository>();
            container.Register<IMovimentoCaixaRepository, MovimentoCaixaRepository>();
            container.Register<IMovimentoPassivoRepository, MovimentoPassivoRepository>();
            container.Register<IOrigemExternaRepository, OrigemExternaRepository>();
            container.Register<IPagRecRepository, PagRecRepository>();
            container.Register<IPagRecDescricaoRepository, PagRecDescricaoRepository>();
            container.Register<IPaisRepository, PaisRepository>();
            container.Register<IPaisNovoRepository, PaisNovoRepository>();
            container.Register<IParametrosRepository, ParametrosRepository>();
            container.Register<IPassivoAtivoRepository, PassivoAtivoRepository>();
            container.Register<IPortfolioRepository, PortfolioRepository>();
            container.Register<IPreBoletaRepository, PreBoletaRepository>();
            container.Register<IPreBoletaVersaoRepository, PreBoletaVersaoRepository>();
            container.Register<IProventoRepository, ProventoRepository>();
            container.Register<IPublicadoCotasRepository, PublicadoCotasRepository>();
            container.Register<IPublicadoIndiceRepository, PublicadoIndiceRepository>();
            container.Register<IPublicadoLiquidezRepository, PublicadoLiquidezRepository>();
            container.Register<IPublicadoMovtoRepository, PublicadoMovtoRepository>();
            container.Register<IPublicadoPerfilRepository, PublicadoPerfilRepository>();
            container.Register<IStatusPreBoletaRepository, StatusPreBoletaRepository>();
            container.Register<ISubdivisaoRepository, SubdivisaoRepository>();
            container.Register<ITesteRepository, TesteRepository>();
            container.Register<IUsuExternoRepository, UsuExternoRepository>();
            container.Register<IXML5Repository, XML5Repository>();
            container.Register<IXmlCotasRepository, XmlCotasRepository>();
            container.Register<IXmlHeaderRepository, XmlHeaderRepository>();
            container.Register<IXMLModelRepository, XMLModelRepository>();
        }
    }
}
