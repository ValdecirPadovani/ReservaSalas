using ReservaSalas.Models;
using ReservaSalas.Repository.Interface;
using ReservaSalas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ReservaSalas.Services
{
    public class SalaService : ISalaService
    {

        private readonly ISalasRepository _salaRepository;

        public SalaService(ISalasRepository salaRepository)
        {
            _salaRepository = salaRepository;
        }

        public async Task Adicionar(Sala sala)
        {
            if (sala == null) return;

            await _salaRepository.Adicionar(sala);

        }

        public void Dispose()
        {
            _salaRepository?.Dispose();
        }

        public async Task<bool> Editar(Sala sala)
        {
            if (_salaRepository.ObterPorId(sala.Id) == null) return false;

            await _salaRepository.Atualizar(sala);
            return true;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
