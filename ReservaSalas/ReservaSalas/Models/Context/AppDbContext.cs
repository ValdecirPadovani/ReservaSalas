using Microsoft.EntityFrameworkCore;

namespace ReservaSalas.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Reserva> reservas { get; set; }

        public DbSet<Sala> salas { get; set; }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
