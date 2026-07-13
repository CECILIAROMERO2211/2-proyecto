using Microsoft.AspNetCore.Mvc;
using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Controllers
{
    /**
     * @brief Controlador principal para la gestión de la navegación del sitio web.
     * @details Esta clase se encarga de manejar las peticiones HTTP para las páginas estáticas 
     * y secciones principales de la plataforma Horizon Bienes Raíces (Nosotros, Servicios, Blog, etc.).
     * @author Horizon Development Team
     * @date Julio 2026
     */
    public class HomeController : Controller
    {
        /**
         * @brief Muestra la página de inicio (Landing Page).
         * @return Redirecciona a la vista Index.cshtml del Home.
         */
        public IActionResult Index()
        {
            return View();
        }

        /**
         * @brief Muestra la sección institucional "Sobre Nosotros".
         * @details Carga la información de la historia, misión y visión de la inmobiliaria boutique.
         * @return Redirecciona a la vista Nosotros.cshtml.
         */
        public IActionResult Nosotros()
        {
            return View();
        }

        /**
         * @brief Muestra el catálogo de servicios premium ofrecidos.
         * @details Detalla las soluciones inmobiliarias como Venta Residencial, Asesoría Legal y Proyectos de Inversión.
         * @return Redirecciona a la vista Servicios.cshtml.
         */
        public IActionResult Servicios()
        {
            return View();
        }

        /**
         * @brief Muestra el blog de noticias y tendencias ("Horizon Insights").
         * @details Despliega artículos de interés sobre finanzas, plusvalía y el mercado inmobiliario de lujo.
         * @return Redirecciona a la vista Blog.cshtml.
         */
        public IActionResult Blog()
        {
            return View();
        }

        /**
         * @brief Muestra el formulario de contacto de la empresa.
         * @details Permite a los clientes enviar dudas, mensajes y solicitudes generales de información.
         * @return Redirecciona a la vista Contacto.cshtml con el formulario listo.
         */
        public IActionResult Contacto()
        {
            return View();
        }

        /**
         * @brief Muestra el módulo de reserva y agendamiento de citas.
         * @details Permite a los usuarios seleccionar fechas, horarios y tipos de asesoría personalizada.
         * @return Redirecciona a la vista AgendarCita.cshtml.
         */
        public IActionResult AgendarCita()
        {
            return View();
        }

        /**
         * @brief Muestra la política de privacidad y términos legales del sitio web.
         * @return Redirecciona a la vista Privacy.cshtml.
         */
        public IActionResult Privacy()
        {
            return View();
        }
    }
}