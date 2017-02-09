using Nextify.Core;
using System.ComponentModel.DataAnnotations;
using System;
using Nextify.Abstraction;

namespace Nextify.App.Models
{
    public class CourseDTO : IInative
    {

        [Key]
        [LayoutColumn(DisplayText  = "Cód.")]
        public int Id { get; set; }

        [LayoutColumn(DisplayText = "Nome")]
        public string Name { get; set; }

        [LayoutColumn(DisplayText = "Descrição")]
        public string Description { get; set; }

        [LayoutColumn(DisplayText = "Autor")]
        public string AuthorName { get; set; }

        [LayoutColumn(DisplayText = "Preço", Format = "#,###,###.00")]
        public double FullPrice { get; set; }

        
        public bool Inative { get; set; }
       
    }
}
