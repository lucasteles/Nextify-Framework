using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System;
using Pragma.Abstraction;

namespace Pragma.App.Models
{
    public class CourseDTO : IInative
    {

        [Key]
        [PgmColumn(DisplayText  = "Cód.")]
        public int Id { get; set; }

        [PgmColumn(DisplayText = "Nome")]
        public string Name { get; set; }

        [PgmColumn(DisplayText = "Descrição")]
        public string Description { get; set; }

        [PgmColumn(DisplayText = "Autor")]
        public string AuthorName { get; set; }

        [PgmColumn(DisplayText = "Preço", Format = "#,###,###.00")]
        public float FullPrice { get; set; }

        public bool Inative { get; set; }
       
    }
}
