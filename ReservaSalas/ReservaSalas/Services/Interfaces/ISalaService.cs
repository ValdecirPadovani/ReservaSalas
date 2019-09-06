using ReservaSalas.Models;
using System;
using System.Threading.Tasks;

namespace ReservaSalas.Services.Interfaces
{
    public interface ISalaService : IDisposable
    {
        Task Adicionar(Sala sala);
        Task Editar(Sala sala);
        Task Remover(Guid id);
    }
}
