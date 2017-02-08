using Nextify.Abstraction;
using Nextify.Core;
using System.Collections.Generic;

namespace Nextify.App.Models
{
    public class Tag : BaseModel, IModelWithKey
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
