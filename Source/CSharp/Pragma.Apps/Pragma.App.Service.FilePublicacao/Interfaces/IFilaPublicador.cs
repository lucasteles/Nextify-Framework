using System.ServiceModel;

namespace Pragma.App.Service.FilePublicacao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFilaPublicador
    {
        /// <summary>
        /// Receber um novo item para a fila de publicação
        /// </summary>
        /// <param name="tXml">XML indicando o Investimento,De e Ate</param>
        /// <returns>confirmação da operação</returns>
        [OperationContract]
        string RecebeListaFilaXml(string tXml);

        /// <summary>
        /// Recebe um novo item para a fila de publicação
        /// </summary>
        /// <param name="tFila">Lista para ser adicionada a fila</param>
        /// <returns>true se incluiu com sucesso</returns>
        [OperationContract]
        bool RecebeListaFila(FiltroInvestimento[] tFila);

        /// <summary>
        /// Receber o pedido, erro ou aviso de termino, sempre indicando o Id que recebe no pedido
        /// </summary>
        /// <param name="tId">Id do pedido</param>
        /// <param name="tUser">Código do usuario no Invest</param>
        /// <param name="tMachineName">Nome da maquina que fez o pedido</param>
        /// <param name="tStatus">Status que indica se é um pedido, erro ou termino</param>
        /// <param name="tMsgErro">se for erro, deve indicar a msg de erro</param>
        /// <param name="DataBase">Nome da base de dados conectada</param>
        /// <returns>confirmação da operação</returns>
        [OperationContract]
        string PedidoPublicacao(int tId, int tUser, string DataBase, string tMachineName, int tStatus, string tMsgErro);

        /// <summary>
        /// Retorna a lista atual de processamento
        /// </summary>
        /// <param name="DataBase">Nome da base de dados conectada</param>
        /// <returns>Lista de processamento como xml</returns>
        [OperationContract]
        GuiaInvestimentos[] EnviarListaProcessamento(string DataBase);

        /// <summary>
        /// Envia a fila atual
        /// </summary>
        /// <param name="DataBase">Nome da base de dados conectada</param>
        /// <returns>Lista de Investimentos esperando processamento</returns>
        [OperationContract]
        GuiaInvestimentos[] EnviarFila(string DataBase);

        /// <summary>
        /// Envia a lista dos ultimos pedidos
        /// </summary>
        /// <param name="DataBase">Nome da base de dados conectada</param>
        /// <returns>Lista de Investimentos esperando processamento</returns>
        [OperationContract]
        GuiaInvestimentos[] EnviarListaPedidos(string DataBase);

        /// <summary>
        /// Remove todos os itens da fila
        /// </summary>
        /// <param name="DataBase">Nome da base de dados conectada</param>
        /// <returns>Lista de Investimentos esperando processamento</returns>
        [OperationContract]
        bool LimparFila(string DataBase);
    }
}
