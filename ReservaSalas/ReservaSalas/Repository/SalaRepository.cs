using ReservaSalas.Models;
using ReservaSalas.Repository.Interface;

namespace ReservaSalas.Repository
{
    public class SalaRepository : Repository<Sala>, ISalasRepository
    {
        public SalaRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        //Implementar consultas específicas

    }
}
