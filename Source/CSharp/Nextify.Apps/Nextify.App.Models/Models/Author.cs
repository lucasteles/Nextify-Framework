using Nextify.Abstraction;
using Nextify.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nextify.App.Models
{
    public class Author : BaseModel, IModelWithKey
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [LayoutColumn(DisplayText = "Id")]
        public int Id { get; set; }

        [LayoutColumn(DisplayText = "Nome")]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
