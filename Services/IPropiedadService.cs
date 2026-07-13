using System.Collections.Generic;
using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Services
{
    public interface IPropiedadService
    {
        IEnumerable<Propiedad> ObtenerTodas(string? tipoFiltro = null, decimal? precioMaximo = null);
        Propiedad ObtenerPorId(int id);
        void RegistrarPropiedad(Propiedad propiedad);
    }
}