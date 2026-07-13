namespace BienesRaicesWeb.Models
{
    public class Propiedad
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Ubicacion { get; set; } = string.Empty;
        public int Habitaciones { get; set; }
        public int Banos { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; } = string.Empty;
        public string Tipo { get; set; } = "Casa"; // Casa, Departamento, Terreno
    }
}