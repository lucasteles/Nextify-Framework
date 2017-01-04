using Pragma.Core;
using System.ComponentModel.DataAnnotations;

namespace Pragma.Tests
{
    public class TestModel
    {
        [Key]
        [PgmColumn()]
        public int Id { get; set; }

        [PgmColumn()]
        public string Property { get; set; }
        public static TestModel[] GetData()
        {
            return new TestModel[] {

                new TestModel { Id=1, Property="Apple"  },
                new TestModel { Id=2, Property="Banana" },
                new TestModel { Id=3, Property="Avocado" },
                new TestModel { Id=4, Property="Blackberry" },
                new TestModel { Id=5, Property="Cherry"},
                new TestModel { Id=6, Property="Coconut"},
                new TestModel { Id=7, Property="Strawberry" },
                new TestModel { Id=8, Property="Grape" },
                new TestModel { Id=9, Property="Lemon" },
                new TestModel { Id=10, Property="Peach" }
            };
        }

    }
}
