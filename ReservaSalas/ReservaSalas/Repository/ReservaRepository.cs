using ReservaSalas.Models;
using ReservaSalas.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaSalas.Repository
{
    public class ReservaRepository : Repository<Reserva>, IReservaSalasRepository
    {
        public ReservaRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
