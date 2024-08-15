using Microsoft.EntityFrameworkCore;

namespace TSNP084024__UNIDAD3.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(c => c.IdPelicula);
        }
    }
}

