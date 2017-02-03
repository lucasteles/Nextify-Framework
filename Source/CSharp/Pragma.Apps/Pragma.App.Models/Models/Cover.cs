using Pragma.Abstraction;
using Pragma.Core;

namespace Pragma.App.Models
{
    public class Cover : IModelWithKey
    {
        public int Id { get; set; }
        public Course Course { get; set; }
    }
}
