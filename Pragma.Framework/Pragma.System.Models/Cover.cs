using Pragma.Core;

namespace Pragma.App.Models
{
    public class Cover : IModelWithId
    {
        public int Id { get; set; }
        public Course Course { get; set; }
    }
}
