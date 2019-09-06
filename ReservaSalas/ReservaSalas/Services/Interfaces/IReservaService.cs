using ReservaSalas.Models;
using System;
using System.Threading.Tasks;

namespace ReservaSalas.Services.Interfaces
{
    interface IReservaService : IDisposable
    {
        Task Adicionar(Reserva reserva);
        Task Editar(Reserva reserva);
        Task Remover(Guid id);
        
    }
}
