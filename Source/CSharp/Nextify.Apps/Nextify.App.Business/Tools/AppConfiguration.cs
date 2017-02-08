using Nextify.App.DAO;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace Nextify.App.Business
{
    /// <summary>
    /// informações bases do sistema
    /// </summary>
    public class AppConfiguration
    {
        /// <summary>
        /// Informações do usuario logado
        /// </summary>
        public static SysUser InfoUserCurrent { get; set; }
        public void SetConnection(string connectionName)
        {
            ConnectionData.MainConnection = connectionName;
        }
      
        public static IEnumerable<ConnectionInfo> GetConnections()
        {
            foreach (ConnectionStringSettings c in ConfigurationManager.ConnectionStrings)
                yield return new ConnectionInfo() { Name = c.Name, ConnectionString = c.ConnectionString };
        }


    }
}

public class ConnectionInfo
{
    public ConnectionInfo()
    {
        
    }
    /// <summary>
    /// Nome da conexão no arquivo de configuração
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Alias para a conexão. Exemplo OficialConnection = Oficial ou Base Oficial
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;
}