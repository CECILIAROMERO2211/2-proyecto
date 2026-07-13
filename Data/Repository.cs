using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BienesRaicesWeb.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _data = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T? GetById(int id)
        {
            var property = typeof(T).GetProperty("Id");
            if (property == null) throw new InvalidOperationException("La entidad no tiene una propiedad Id.");

            return _data.FirstOrDefault(e => (int)(property.GetValue(e) ?? 0) == id);
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _data.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _data.Remove(entity);
            }
        }
    }
}