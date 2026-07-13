using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BienesRaicesWeb.Data;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id)!;
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges(); // Guarda los cambios físicamente en el archivo .db
    }

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}