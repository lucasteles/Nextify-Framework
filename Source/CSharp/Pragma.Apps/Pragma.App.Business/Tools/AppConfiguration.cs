using Pragma.App.DAO;

namespace Pragma.App.Business
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
        public void SetSysConnection(string connectionName)
        {
            ConnectionData.SysConnection = connectionName;
        }
    }
}

public class ConnectionInfo
{
    public ConnectionInfo(string display, string name)
    {
        Name = name;
        DisplayName = display;
    }
    /// <summary>
    /// Nome da conexão no arquivo de configuração
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Alias para a conexão. Exemplo OficialConnection = Oficial ou Base Oficial
    /// </summary>
    public string DisplayName { get; set; } = string.Empty;
}