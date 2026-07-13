using System;
using System.Collections.Generic;
using System.Linq;
using BienesRaicesWeb.Data;
using BienesRaicesWeb.Models;

namespace BienesRaicesWeb.Services
{
    public class PropiedadService : IPropiedadService
    {
        private readonly IRepository<Propiedad> _repository;

        public PropiedadService(IRepository<Propiedad> repository)
        {
            _repository = repository;
            CargarDatosIniciales();
        }

        public IEnumerable<Propiedad> ObtenerTodas(string? tipoFiltro = null, decimal? precioMaximo = null)
        {
            try
            {
                var propiedades = _repository.GetAll();

                if (!string.IsNullOrEmpty(tipoFiltro) && tipoFiltro != "Todos")
                {
                    propiedades = propiedades.Where(p => p.Tipo.Equals(tipoFiltro, StringComparison.OrdinalIgnoreCase));
                }

                if (precioMaximo.HasValue && precioMaximo.Value > 0)
                {
                    propiedades = propiedades.Where(p => p.Precio <= precioMaximo.Value);
                }

                return propiedades;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al consultar el catálogo de propiedades.", ex);
            }
        }

        public Propiedad ObtenerPorId(int id)
        {
            try
            {
                if (id <= 0) throw new ArgumentException("El ID debe ser mayor a cero.");
                
                var propiedad = _repository.GetById(id);
                if (propiedad == null)
                {
                    throw new KeyNotFoundException($"No se encontró la propiedad con ID {id}.");
                }

                return propiedad;
            }
            catch (Exception ex) when (ex is not KeyNotFoundException && ex is not ArgumentException)
            {
                throw new ApplicationException($"Error al recuperar la propiedad {id}.", ex);
            }
        }

        public void RegistrarPropiedad(Propiedad propiedad)
        {
            if (propiedad.Precio <= 0) throw new InvalidOperationException("El precio debe ser mayor a 0.");
            _repository.Add(propiedad);
        }

        private void CargarDatosIniciales()
        {
            if (!_repository.GetAll().Any())
            {
                _repository.Add(new Propiedad { Id = 1, Titulo = "Residencia de Lujo en Juriquilla", Descripcion = "Hermosa casa moderna con acabados de primera, jardín amplio y seguridad privada 24/7.", Precio = 4500000, Ubicacion = "Querétaro, Qro.", Habitaciones = 4, Banos = 3, MetrosCuadrados = 320, Tipo = "Casa", ImagenUrl = "https://images.unsplash.com/photo-1600596542815-ffad4c1539a9?w=800&q=80" });
                _repository.Add(new Propiedad { Id = 2, Titulo = "Penthouse Vista Panorámica", Descripcion = "Departamento exclusivo con terraza privada, alberca semi-olímpica y acceso directo a centro comercial.", Precio = 3800000, Ubicacion = "Ciudad de México, CDMX", Habitaciones = 2, Banos = 2, MetrosCuadrados = 180, Tipo = "Departamento", ImagenUrl = "https://images.unsplash.com/photo-1545324418-cc1a3fa10c00?w=800&q=80" });
                _repository.Add(new Propiedad { Id = 3, Titulo = "Villa Colonial con Alberca", Descripcion = "Propiedad estilo colonial remodelada, ideal para descanso y reuniones familiares.", Precio = 5200000, Ubicacion = "San Miguel de Allende, Gto.", Habitaciones = 5, Banos = 4, MetrosCuadrados = 450, Tipo = "Casa", ImagenUrl = "https://images.unsplash.com/photo-1512917774080-9991f1c4c750?w=800&q=80" });
                _repository.Add(new Propiedad { Id = 4, Titulo = "Terreno Residencial Premium", Descripcion = "Lote listo para construir en fraccionamiento privado con casa club y campo de golf.", Precio = 1800000, Ubicacion = "Querétaro, Qro.", Habitaciones = 0, Banos = 0, MetrosCuadrados = 250, Tipo = "Terreno", ImagenUrl = "https://images.unsplash.com/photo-1500382017468-9049fed747ef?w=800&q=80" });
            }
        }
    }
}