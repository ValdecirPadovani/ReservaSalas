using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaSalas.DTO
{
    public class SalaDTO
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
    }
}
