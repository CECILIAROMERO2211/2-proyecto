using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BienesRaicesWeb.Data
{
    /**
     * @brief Implementación concreta, genérica y centralizada del acceso a datos.
     * @details Transforma las operaciones del patrón repositorio en consultas físicas a la base de datos usando Entity Framework.
     * @typeparam T Entidad del modelo de dominio que hereda la lógica CRUD.
     */
    public class Repository<T> : IRepository<T> where T : class
    {
        // Métodos internos heredados
        public IEnumerable<T> GetAll() => throw new System.NotImplementedException();
        public T GetById(int id) => throw new System.NotImplementedException();
        public void Add(T entity) => throw new System.NotImplementedException();
    }
}