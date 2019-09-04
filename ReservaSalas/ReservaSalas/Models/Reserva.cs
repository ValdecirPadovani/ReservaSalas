
using System.ComponentModel.DataAnnotations;

namespace ReservaSalas.Models
{
    public class Reserva
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        /*EF Relations*/
        public int SalaID { get; set; }

        public Sala sala { get; set; }
    }
}
