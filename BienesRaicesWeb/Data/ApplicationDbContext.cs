using Microsoft.EntityFrameworkCore;
using BienesRaicesWeb.Models;
/**
 * @namespace BienesRaicesWeb.Data
 * @brief Estructura de persistencia, repositorios y comunicación con bases de datos relacionales.
 */
namespace BienesRaicesWeb.Data
{
    /**
     * @class ApplicationDbContext
     * @brief Contexto de Entity Framework Core para el mapeo relacional de la base de datos SQL.
     * @details Conecta las clases del sistema con el servidor de base de datos y expone los conjuntos de datos.
     */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /**
         * @brief Colección de datos mapeada de la entidad Propiedad.
         * @details Gestiona la tabla física "Propiedades" permitiendo la persistencia y consultas LINQ del catálogo.
         */
        public DbSet<Propiedad> Propiedades { get; set; }
    }
}