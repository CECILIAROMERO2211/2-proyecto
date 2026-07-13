using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Services;

    public interface IPropiedadService
    {
        IEnumerable<Propiedad> ObtenerTodas();
        Propiedad ObtenerPorId(int id);
        void Guardar(Propiedad propiedad);
    }
