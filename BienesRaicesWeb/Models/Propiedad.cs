/**
 * @namespace BienesRaicesWeb.Models
 * @brief Modelos de datos atómicos y entidades de negocio del dominio inmobiliario.
 */

namespace BienesRaicesWeb.Models
{
    /**
     * @class Propiedad
     * @brief Entidad que define las propiedades físicas, características y precios de un inmueble.
     * @details Contiene variables comerciales esenciales como ID, Título, Precio, Habitaciones, Ubicación y URL multimedia.
     */
    public class Propiedad
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}