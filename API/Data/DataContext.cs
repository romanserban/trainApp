using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Train> Trains { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}