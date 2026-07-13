using Microsoft.AspNetCore.Mvc;
namespace BienesRaicesWeb.Controllers
{
    /**
     * @class PropiedadesController
     * @brief Núcleo del sistema CRUD de gestión de activos inmobiliarios.
     * @details Módulo administrativo restringido para agentes que permite controlar el stock e inventario de inmuebles en tiempo real.
     */
    public class PropiedadesController : Controller
    {
        /**
         * @brief Panel de administración general.
         * @details Lista todo el catálogo de propiedades internas con filtros avanzados de búsqueda y estados.
         */
        public IActionResult Index()
        {
            return View();
        }

        /**
         * @brief Formulario de creación de inmuebles.
         * @details Procesa la carga física y lógica de nuevos activos al sistema (imágenes, precios y descripciones).
         */
        public IActionResult Create()
        {
            return View();
        }

        /**
         * @brief Interfaz de modificación de fichas existentes.
         * @details Permite actualizar datos catastrales, precios o reasignar estados en tiempo real.
         */
        public IActionResult Edit(int id)
        {
            return View();
        }

        /**
         * @brief Remoción o baja física del inventario público.
         * @details Retira una propiedad debido a su venta exitosa o término de contrato de exclusividad.
         */
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}