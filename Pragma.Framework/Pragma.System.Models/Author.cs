using Pragma.Core;
using System.Collections.Generic;

namespace Pragma.App.Models
{
    public class Author : IModelWithId
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
