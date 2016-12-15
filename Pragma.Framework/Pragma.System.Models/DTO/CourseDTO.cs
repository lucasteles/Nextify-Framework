using System.ComponentModel.DataAnnotations;

namespace Pragma.App.Models
{
    public class CourseDTO
    {

        [Key]
        public int Id { get; set; }


        public string Name { get; set; }

        public string Description { get; set; }

        public string AuthorName { get; set; }

        public decimal FullPrice { get; set; }
    }
}
