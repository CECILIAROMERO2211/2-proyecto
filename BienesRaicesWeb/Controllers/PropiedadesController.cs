using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BienesRaicesWeb.Services;
using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Controllers
{
    public class PropiedadesController : Controller
    {
        private readonly IPropiedadService _propiedadService;

        public PropiedadesController(IPropiedadService propiedadService)
        {
            _propiedadService = propiedadService;
        }

        public IActionResult Index(string? tipo, decimal? precioMax)
        {
            try
            {
                ViewBag.TipoSeleccionado = tipo ?? "Todos";
                ViewBag.PrecioMax = precioMax;
                
                var propiedades = _propiedadService.ObtenerTodas(tipo, precioMax);
                return View(propiedades);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(new List<Propiedad>());
            }
        }

        public IActionResult Detalle(int id)
        {
            try
            {
                var propiedad = _propiedadService.ObtenerPorId(id);
                return View(propiedad);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}