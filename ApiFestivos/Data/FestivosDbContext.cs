using ApiFestivos.Modelos;

using Microsoft.EntityFrameworkCore;

namespace ApiFestivos.Data
{
    public class FestivosDbContext : DbContext
    {
        public FestivosDbContext(DbContextOptions<FestivosDbContext> options) : base(options) { }
        public DbSet<Festivo> Festivos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }
}
    


