using Pragma.Abstraction;
using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pragma.App.Models
{

    public class Course : BaseModel, IModelWithKey
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int Level { get; set; }

        public double FullPrice { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

      
        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }




    }
}
