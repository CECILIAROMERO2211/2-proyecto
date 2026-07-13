using Microsoft.EntityFrameworkCore;
using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Crea la tabla "Propiedades" usando tu modelo
    public DbSet<Propiedad> Propiedades { get; set; }
}