using Microsoft.EntityFrameworkCore;
using X20240408.EntidadesDeNegocio;

namespace X20240408.AccesoADatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PersonaX> PersonasX{ get; set; }
    }
}
