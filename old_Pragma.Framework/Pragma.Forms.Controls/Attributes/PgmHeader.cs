using System;

namespace Pragma.Forms.Controls.Attributes
{
    /// <summary>
    /// Ao exibir uma model na Grid sem configurar o Header, esse atributo será usado
    /// </summary>
    public class PgmHeader : Attribute
    {
        public PgmHeader()
        {

        }
        public PgmHeader(PgmHeader tHeader)
        {
            foreach (var p in tHeader.GetType().GetProperties())
            {
                p.SetValue(this, p.GetValue(tHeader));
            }
        }
        /// <summary>
        /// Nome do campo na lista
        /// </summary>
        public string FieldName { get; set; } = "";
        /// <summary>
        /// Nome de exibição do campo
        /// </summary>
        public string ColumnName { get; set; } = "";
        /// <summary>
        /// Formato no qual o campo será exibido
        /// </summary>
        public string Format { get; set; } = "";
        /// <summary>
        /// Quando nulo exibe o que estiver nessa propriedade
        /// </summary>
        public string NullValue { get; set; } = "";
        /// <summary>
        /// Define o tamanho da coluna
        /// </summary>
        public int ColumnSize { get; set; } = 70;
        /// <summary>
        /// Define o tamanho da linha
        /// </summary>
        public int LineSize { get; set; } = 15;
        /// <summary>
        /// Define o tamanho máximo da coluna
        /// </summary>
        public int ColumnMaxSize { get; set; } = 0;
        /// <summary>
        /// Define o tamanho minimo da coluna
        /// </summary>
        public int ColumnMinSize { get; set; } = 0;
        /// <summary>
        /// Alinhamento do texto 0-esqueda,1-centro e 2-direita
        /// </summary>
        public int Alignment { get; set; } = 1;
        /// <summary>
        /// Define se vai ter um contorno ao redor da coluna
        /// </summary>
        public bool Outline { get; set; }
        /// <summary>
        /// Define se vai ter agrupamento das classes de ativos
        /// </summary>
        public bool Grouping { get; set; }
        /// <summary>
        /// Define se a tabela será listrada
        /// </summary>
        public bool Striped { get; set; }
        /// <summary>
        /// Define se a tabela atribuirá a cor de cada linha
        /// </summary>
        public bool Color { get; set; }
        /// <summary>
        /// Define se a tabela terá a linha vermelha inferior
        /// </summary>
        public bool LowerRedLine { get; set; } = false;
        /// <summary>
        /// Define se o conteúdo estará em negrito
        /// </summary>
        public bool Bold { get; set; }
        /// <summary>
        /// Define se o conteúdo estará em itálico
        /// </summary>
        public bool Italic { get; set; }
        /// <summary>
        /// Define se o conteúdo estará sublinhado
        /// </summary>
        public bool Underline { get; set; }
        /// <summary>
        /// Define se o conteúdo do meio (entre e a primeira e última linhas) terá um espaço inicial (tab)
        /// </summary>
        public bool IndentMiddleContent { get; set; }
        /// <summary>
        /// Define se o header terá cor (cinza)
        /// </summary>
        public bool NoHeaderColor { get; set; }
        /// <summary>
        /// Tipo do controle usado para exibição do campo
        /// </summary>
        public ControlType Control { get; set; } = ControlType.TextBox;
        /// <summary>
        /// Ordem horizontal do Header (menor valor à esquerda, maior valor à direita).
        /// </summary>
        public int HeaderOrder { get; set; }
        /// <summary>
        /// Prioridade do header na ordenação do conteúdo da Grid (o valor mais alto será a ordem principal, demais valores serão ordens secundárias).
        /// Valores iguais ou inferiores a 0 serão ignorados.
        /// </summary>
        public int DataOrderPriority { get; set; }
    }
}
