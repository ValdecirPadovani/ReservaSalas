
using System.ComponentModel.DataAnnotations;

namespace ReservaSalas.Models
{
    public class Reserva : EntityBase
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        /*EF Relations*/

        public Sala sala { get; set; }
    }
}
