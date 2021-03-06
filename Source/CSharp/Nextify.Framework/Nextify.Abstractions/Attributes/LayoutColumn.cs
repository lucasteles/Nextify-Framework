﻿using System;

namespace  Nextify.Core
{
    public enum PgmTextAlignment
    {
        Left = 0,
        Center = 1,
        Right = 2,
    }

    /// <summary>
    /// Ao exibir uma model na Grid sem configurar o Header, esse atributo será usado
    /// </summary>
    public class LayoutColumn : Attribute
    {
        public LayoutColumn()
        {

        }

        public LayoutColumn(LayoutColumn column)
        {
            foreach (var p in column.GetType().GetProperties())
            {
                p.SetValue(this, p.GetValue(column));
            }
        }

        /// <summary>
        /// Nome da propriedade na view.
        /// </summary>
        public string PropertyName { get; set; } = "";

        /// <summary>
        /// Nome de exibição do campo.
        /// </summary>
        public string DisplayText { get; set; } = "";

        /// <summary>
        /// Formato no qual o campo será exibido.
        /// </summary>
        public string Format { get; set; } = "";

        /// <summary>
        /// Quando nulo, exibe o valor desta propriedade.
        /// </summary>
        public string ValueIfNull { get; set; } = "";

        /// <summary>
        /// Define o tamanho da coluna.
        /// </summary>
        public int ColumnSize { get; set; } = 100;

        /// <summary>
        /// Define o tamanho máximo da coluna.
        /// </summary>
        public int ColumnMaxSize { get; set; }

        /// <summary>
        /// Define o tamanho mínimo da coluna.
        /// </summary>
        public int ColumnMinSize { get; set; }

        /// <summary>
        /// Define o alinhamento do texto.
        /// </summary>
        public PgmTextAlignment Alignment { get; set; } = PgmTextAlignment.Left;

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