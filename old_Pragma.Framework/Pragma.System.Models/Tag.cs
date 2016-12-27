using Pragma.Core;
using System.Collections.Generic;

namespace Pragma.App.Models
{
    public class Tag : IModelWithId
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
