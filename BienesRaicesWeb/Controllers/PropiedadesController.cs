using BienesRaicesWeb.Data;
using BienesRaicesWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BienesRaicesWeb.Controllers
{
    /// <summary>
    /// Gestiona el catálogo y las operaciones CRUD de propiedades.
    /// </summary>
    public class PropiedadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Recibe el contexto de la base de datos mediante inyección
        /// de dependencias.
        /// </summary>
        public PropiedadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Muestra todas las propiedades y permite filtrarlas.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Index(
            string? tipo,
            decimal? precioMax)
        {
            IQueryable<Propiedad> consulta = _context.Propiedades
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(tipo) &&
                !tipo.Equals(
                    "Todos",
                    StringComparison.OrdinalIgnoreCase))
            {
                consulta = consulta.Where(
                    propiedad => propiedad.Tipo == tipo);
            }

            if (precioMax.HasValue && precioMax.Value > 0)
            {
                consulta = consulta.Where(
                    propiedad => propiedad.Precio <= precioMax.Value);
            }

            ViewBag.TipoSeleccionado =
                string.IsNullOrWhiteSpace(tipo)
                    ? "Todos"
                    : tipo;

            ViewBag.PrecioMaximo = precioMax;

            List<Propiedad> propiedades = await consulta
                .OrderBy(propiedad => propiedad.Id)
                .ToListAsync();

            // La lista nunca se envía como null.
            return View(propiedades);
        }

        /// <summary>
        /// Muestra la información completa de una propiedad.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Detalle(int id)
        {
            Propiedad? propiedad = await _context.Propiedades
                .AsNoTracking()
                .FirstOrDefaultAsync(
                    propiedad => propiedad.Id == id);

            if (propiedad is null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        /// <summary>
        /// Abre el formulario para registrar una propiedad.
        /// </summary>
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Propiedad());
        }

        /// <summary>
        /// Guarda una propiedad nueva.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            Propiedad propiedad)
        {
            if (!ModelState.IsValid)
            {
                return View(propiedad);
            }

            _context.Propiedades.Add(propiedad);
            await _context.SaveChangesAsync();

            TempData["MensajeExito"] =
                "La propiedad se registró correctamente.";

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Abre el formulario de edición.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Propiedad? propiedad = await _context.Propiedades
                .FindAsync(id);

            if (propiedad is null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        /// <summary>
        /// Guarda los cambios realizados en una propiedad.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            Propiedad propiedad)
        {
            if (id != propiedad.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(propiedad);
            }

            bool existe = await _context.Propiedades
                .AnyAsync(item => item.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            try
            {
                _context.Propiedades.Update(propiedad);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict(
                    "La propiedad fue modificada por otro proceso.");
            }

            TempData["MensajeExito"] =
                "La propiedad se actualizó correctamente.";

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Muestra la confirmación para eliminar una propiedad.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Propiedad? propiedad = await _context.Propiedades
                .AsNoTracking()
                .FirstOrDefaultAsync(
                    propiedad => propiedad.Id == id);

            if (propiedad is null)
            {
                return NotFound();
            }

            return View(propiedad);
        }

        /// <summary>
        /// Elimina definitivamente una propiedad.
        /// </summary>
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Propiedad? propiedad = await _context.Propiedades
                .FindAsync(id);

            if (propiedad is null)
            {
                return NotFound();
            }

            _context.Propiedades.Remove(propiedad);
            await _context.SaveChangesAsync();

            TempData["MensajeExito"] =
                "La propiedad se eliminó correctamente.";

            return RedirectToAction(nameof(Index));
        }
    }
}