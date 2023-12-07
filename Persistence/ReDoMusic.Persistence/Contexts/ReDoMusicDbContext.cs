using Microsoft.EntityFrameworkCore;
using ReDoMusic.Domain.Entities;
using ReDoMusic.Persistence;
using ReDoMusic.Domain.Entities;
using ReDoMusic.Persistence.Contexts;

namespace ReDoMusic.Persistence.Contexts
{
    public class ReDoMusicDbContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        }
    }
}
