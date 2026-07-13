using BienesRaicesWeb.Data;
using BienesRaicesWeb.Models;
using System.Collections.Generic;

namespace BienesRaicesWeb.Services
{
    /**
     * @class PropiedadService
     * @brief Implementación concreta de la lógica de negocio para la gestión de inmuebles.
     * @details Resuelve las validaciones comerciales, filtros y operaciones operativas del catálogo de propiedades antes de su persistencia.
     */
    public class PropiedadService : IPropiedadService
    {
        /**
         * @brief Referencia interna al repositorio genérico de datos encapsulado.
         */
        private readonly IRepository<Propiedad> _repository;

        /**
         * @brief Constructor del servicio que inyecta el repositorio de datos.
         * @param repository Repositorio de la entidad Propiedad para transacciones de almacenamiento.
         */
        public PropiedadService(IRepository<Propiedad> repository)
        {
            _repository = repository;
        }

        /**
         * @brief Recupera la lista global de inmuebles del catálogo.
         * @return Una colección enumerable con todas las entidades Propiedad registradas.
         */
        public IEnumerable<Propiedad> ObtenerTodas()
        {
            return _repository.GetAll(); 
        }

        /**
         * @brief Registra o añade una nueva propiedad en el inventario.
         * @param propiedad Objeto entidad con los datos financieros y catastrales a guardar.
         */
        public void Guardar(Propiedad propiedad)
        {
            _repository.Add(propiedad);
        }

        /**
         * @brief Localiza una propiedad específica mediante su clave primaria.
         * @param id Identificador numérico único del inmueble.
         * @return La entidad Propiedad correspondiente o null si no se encuentra.
         */
        public Propiedad ObtenerPorId(int id)
        {
            return _repository.GetById(id);
        }
    }
}