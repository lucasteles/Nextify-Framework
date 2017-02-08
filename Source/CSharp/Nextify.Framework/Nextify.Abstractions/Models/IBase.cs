using Nextify.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace  Nextify.Abstraction
{
    public interface IBase : IInative
    {

       
        /// <summary>
        /// Propriedade contendo a data de criação do registro
        /// </summary>
        [PgmColumn(DisplayText = "Data e Hora de Inclusão")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        DateTime? Created { get; set; }
        /// <summary>
        /// Propriedade contendo a data de atualização do registro
        /// </summary>
        [PgmColumn(DisplayText = "Data e Hora da Alteração")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        DateTime? Updated { get; set; }

    }

    public interface IInative
    {
        /// <summary>
        /// Propriedade indicando se o registro está ativo
        /// </summary>
        [PgmColumn(DisplayText = "Inativo")]
        bool Inative { get; set; }



    }

}
