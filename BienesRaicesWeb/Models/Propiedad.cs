using System.ComponentModel.DataAnnotations;

namespace BienesRaicesWeb.Models
{
    /**
     * @class Propiedad
     * @brief Modelo de dominio que representa un inmueble dentro del sistema.
     * @details Contiene la estructura de datos que se mapeará a la base de datos.
     */
    public class Propiedad
    {
       [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; } 
        public decimal Precio { get; set; }
        public int MetrosCuadrados { get; set; }
        public string Tipo { get; set; }
        public string Ubicacion { get; set; }
        public string ImagenUrl { get; set; }
        public int Habitaciones { get; set; }
        public int Banos { get; set; }
    }
}