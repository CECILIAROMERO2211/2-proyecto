using Microsoft.EntityFrameworkCore.Migrations;

namespace BienesRaicesWeb.Migrations
{
    /**
     * @namespace BienesRaicesWeb.Migrations
     * @brief Módulo que almacena el historial evolutivo y cambios estructurales de la base de datos SQL.
     */

    /**
     * @class Inicial
     * @brief Migración inicial que genera la estructura base del sistema en SQL.
     * @details Traduce las clases C# en tablas físicas reales dentro del servidor (como la tabla Propiedades).
     */
    public partial class Inicial : Migration
    {
        /**
         * @brief Operación ascendente (Up). Ejecuta la creación de tablas y restricciones en la base de datos.
         * @param migrationBuilder Constructor de herramientas de migración de Entity Framework.
         */
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.Id);
                });
        }

        /**
         * @brief Operación descendente (Down). Revierte los cambios de esta migración eliminando las estructuras creadas.
         * @param migrationBuilder Constructor de herramientas de migración de Entity Framework.
         */
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propiedades");
        }
    }
}