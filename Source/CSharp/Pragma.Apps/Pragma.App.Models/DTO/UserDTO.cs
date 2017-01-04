using System.ComponentModel.DataAnnotations;

namespace Pragma.App.Models.DTO
{
    public class UserDTO
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Grupos { get; set; }

    }
}
