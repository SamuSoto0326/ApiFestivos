using Microsoft.EntityFrameworkCore; // Necesario para DbContext
using ApiFestivos.Modelos; // Asegúrate de que este sea el espacio de nombres correcto para tu modelo Festivo

namespace ApiFestivos.Data // Asegúrate de que el espacio de nombres sea correcto
{
    public class FestivosDbContext : DbContext
    {
        public FestivosDbContext(DbContextOptions<FestivosDbContext> options) : base(options) { }

        public DbSet<Festivo> Festivos { get; set; } // Aquí defines la tabla que representa a Festivo
    }
}



