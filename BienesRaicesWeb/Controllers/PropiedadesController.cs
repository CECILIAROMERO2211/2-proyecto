using Microsoft.AspNetCore.Mvc;
using BienesRaicesWeb.Services;
using System.Linq;

namespace BienesRaicesWeb.Controllers;

public class PropiedadesController : Controller
{
    private readonly IPropiedadService _propiedadService;

    public PropiedadesController(IPropiedadService propiedadService)
    {
        _propiedadService = propiedadService;
    }

    // Modificamos el método para que acepte los filtros del formulario web
    public IActionResult Index(string tipo, decimal? precioMax)
    {
        // 1. Traer todos los registros de la base de datos
        var propiedades = _propiedadService.ObtenerTodas();

        // 2. Filtrar por tipo (si seleccionan algo distinto a "Todos")
        if (!string.IsNullOrEmpty(tipo) && tipo != "Todos")
        {
            propiedades = propiedades.Where(p => p.Tipo == tipo);
        }

        // 3. Filtrar por precio máximo si el usuario escribió un número
        if (precioMax.HasValue)
        {
            propiedades = propiedades.Where(p => p.Precio <= precioMax.Value);
        }

        // Guardamos los valores para que no se borren de las cajitas al presionar "Filtrar"
        ViewBag.TipoSeleccionado = tipo;
        ViewBag.PrecioMaximo = precioMax;

        return View(propiedades.ToList());
    }
}