using System.Collections.Generic;

namespace BienesRaicesWeb.Data
{
    /**
     * @brief Interfaz genérica para la abstracción del patrón de diseño Repository.
     * @details Define las firmas de los métodos universales de acceso a datos (Lectura, Inserción y Borrado).
     * @typeparam T Entidad del modelo de dominio sobre la que se operan las transacciones.
     */
    public interface IRepository<T> where T : class
    {
        /**
         * @brief Obtiene todos los registros de la entidad.
         */
        IEnumerable<T> GetAll();

        /**
         * @brief Localiza un registro único por su identificador.
         */
        T GetById(int id);

        /**
         * @brief Registra una nueva entidad en el contexto.
         */
        void Add(T entity);
    }
}