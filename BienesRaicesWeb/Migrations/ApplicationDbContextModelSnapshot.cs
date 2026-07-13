using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using BienesRaicesWeb.Data;

/**
 * @namespace BienesRaicesWeb.Migrations
 * @brief Módulo que almacena el historial evolutivo y cambios estructurales de la base de datos SQL.
 */
namespace BienesRaicesWeb.Migrations
{
    /**
     * @class ApplicationDbContextModelSnapshot
     * @brief Instantánea del estado actual del modelo de datos para Entity Framework.
     * @details Archivo generado automáticamente que guarda la estructura vigente de las tablas para futuras comparaciones de migración.
     */
    [DbContext(typeof(ApplicationDbContext))]
    public partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        /**
         * @brief Construye el modelo de datos actual reflejando las entidades en metadatos.
         * @param modelBuilder Constructor y mapeador estructural del modelo para Entity Framework.
         */
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BienesRaicesWeb.Models.Propiedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Propiedades");
                });
#pragma warning restore 612, 618
        }
    }
}