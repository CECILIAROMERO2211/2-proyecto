using Microsoft.AspNetCore.Mvc;
using BienesRaicesWeb.Models; // Asegúrate de que este namespace coincida con tu proyecto

namespace BienesRaicesWeb.Controllers
{
    public class HomeController : Controller
    {
        // Método principal que ya tenías
        public IActionResult Index()
        {
            return View();
        }

        // ==========================================
        // NUEVAS RUTAS DE NAVEGACIÓN (DENTRO DE LA CLASE)
        // ==========================================

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult AgendarCita()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}