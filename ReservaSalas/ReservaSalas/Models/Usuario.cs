
using System.ComponentModel.DataAnnotations;

namespace ReservaSalas.Models
{
    public class Usuario 
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }
    }
}
