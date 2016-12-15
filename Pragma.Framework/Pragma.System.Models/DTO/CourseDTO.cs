using Pragma.Forms.Controls.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Pragma.App.Models
{
    public class CourseDTO
    {

        [Key]
        [PgmHeader(ColumnName = "Cód.")]
        public int Id { get; set; }

        [PgmHeader(ColumnName = "Nome")]
        public string Name { get; set; }

        [PgmHeader(ColumnName = "Descrição")]
        public string Description { get; set; }

        [PgmHeader(ColumnName = "Autor")]
        public string AuthorName { get; set; }

        [PgmHeader(ColumnName = "Preço", Format = "#,###,###.00")]
        public decimal FullPrice { get; set; }
    }
}
