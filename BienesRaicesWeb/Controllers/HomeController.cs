using Microsoft.AspNetCore.Mvc;
using BienesRaicesWeb.Models;
/**
 * @namespace BienesRaicesWeb
 * @brief Namespace raíz del ecosistema Horizon Bienes Raíces.
 */

/**
 * @namespace BienesRaicesWeb.Controllers
 * @brief Módulo encargado de la capa de presentación y control de flujos HTTP.
 */
namespace BienesRaicesWeb.Controllers
{
    /**
     * @class HomeController
     * @brief Controlador maestro para la gestión de la navegación pública del sitio web.
     * @details Se encarga de resolver las peticiones HTTP y renderizar las páginas principales y estáticas de la plataforma Horizon Bienes Raíces.
     * @author Horizon Development Team
     * @date Julio 2026
     */
    public class HomeController : Controller
    {
        /**
         * @brief Carga la página de inicio (Landing Page).
         * @details Renderiza la vista principal con los banners de presentación y propiedades destacadas.
         * @return Vista Index.cshtml.
         */
        public IActionResult Index()
        {
            return View();
        }

        /**
         * @brief Muestra la sección institucional "Sobre Nosotros".
         * @details Expone la historia, la misión, la visión y los valores corporativos de la inmobiliaria premium.
         * @return Vista Nosotros.cshtml.
         */
        public IActionResult Nosotros()
        {
            return View();
        }

        /**
         * @brief Despliega el catálogo de soluciones corporativas y servicios comerciales.
         * @details Muestra los servicios de brokerage residencial, consultoría de inversiones y asesoría legal.
         * @return Vista Servicios.cshtml.
         */
        public IActionResult Servicios()
        {
            return View();
        }

        /**
         * @brief Muestra el portal de artículos y noticias ("Horizon Insights").
         * @details Diseñado para captar tráfico mediante posicionamiento orgánico SEO analizando tendencias del mercado.
         * @return Vista Blog.cshtml.
         */
        public IActionResult Blog()
        {
            return View();
        }

        /**
         * @brief Renderiza el formulario de contacto y atención al cliente.
         * @details Captura datos clave de clientes potenciales (Leads) para canalizarlos con el equipo de ventas.
         * @return Vista Contacto.cshtml.
         */
        public IActionResult Contacto()
        {
            return View();
        }

        /**
         * @brief Muestra el módulo interactivo de reserva de citas.
         * @details Permite a los usuarios agendar un espacio en la agenda cronológica de un asesor inmobiliario.
         * @return Vista AgendarCita.cshtml.
         */
        public IActionResult AgendarCita()
        {
            return View();
        }

        /**
         * @brief Despliega las políticas legales, términos y condiciones del sitio.
         * @details Muestra el aviso de privacidad vigente conforme a las normativas de protección de datos.
         * @return Vista Privacy.cshtml.
         */
        public IActionResult Privacy()
        {
            return View();
        }
    }
}