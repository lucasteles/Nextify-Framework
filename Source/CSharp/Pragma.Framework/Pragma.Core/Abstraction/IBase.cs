using System;
using System.ComponentModel.DataAnnotations;

namespace Pragma.Core
{
    public interface IBase : IInative
    {

        /// <summary>
        /// Propriedade indicando qual é o código do usuario que incluiu o registro
        /// </summary>
        [PgmColumn(DisplayText = "Usuario")]
        int? Owner { get; set; }
        /// <summary>
        /// Propriedade contendo a data de criação do registro
        /// </summary>
        [PgmColumn(DisplayText = "Data e Hora de Inclusão")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        DateTime? DhInclusao { get; set; }
        /// <summary>
        /// Propriedade contendo a data de atualização do registro
        /// </summary>
        [PgmColumn(DisplayText = "Data e Hora da Alteração")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        DateTime? DhAlteracao { get; set; }

    }

    public interface IInative
    {
        /// <summary>
        /// Propriedade indicando se o registro está ativo
        /// </summary>
        [PgmColumn(DisplayText = "Inativo")]
        decimal? Inativo { get; set; }

        bool IsInative();

    }

}
