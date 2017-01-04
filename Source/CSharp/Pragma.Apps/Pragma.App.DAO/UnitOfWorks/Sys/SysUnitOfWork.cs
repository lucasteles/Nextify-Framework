using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface ISysUnitOfWork : IUnitOfWork
    {
        IControleRepository Controle { get; set; }
        IAjudaSistemaRepository AjudaSistema { get; set; }
        
        IParametrosRepository Parametros { get; set; }
    }
    public class SysUnitOfWork : BaseUnitOfWork, ISysUnitOfWork
    {
        public IControleRepository Controle { get; set; }
        public IAjudaSistemaRepository AjudaSistema { get; set; }
        
        public IParametrosRepository Parametros { get; set; }

        public SysUnitOfWork(
                SysContext context,
                 Func<IContext, IControleRepository> controle,
                 Func<IContext, IAjudaSistemaRepository> ajudaSistema,
        
                 Func<IContext, IParametrosRepository> parametros
        ) : base(context)
        {

            Controle = controle(context);
            AjudaSistema = ajudaSistema(context);
        
            Parametros = parametros(context);
        }
    }
}
