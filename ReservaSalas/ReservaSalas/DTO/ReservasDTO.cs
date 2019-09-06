using System.ComponentModel.DataAnnotations;

namespace ReservaSalas.DTO
{
    public class ReservasDTO
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        /*EF Relations*/
        public SalaDTO sala { get; set; }
    }
}
