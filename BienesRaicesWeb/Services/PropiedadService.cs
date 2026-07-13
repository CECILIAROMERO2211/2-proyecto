using BienesRaicesWeb.Data;
using BienesRaicesWeb.Models;
using System.Collections.Generic;

namespace BienesRaicesWeb.Services;

public class PropiedadService : IPropiedadService
{
    private readonly IRepository<Propiedad> _repository;

    public PropiedadService(IRepository<Propiedad> repository)
    {
        _repository = repository;
    }

    public IEnumerable<Propiedad> ObtenerTodas()
    {
        return _repository.GetAll(); 
    }

    public void Guardar(Propiedad propiedad)
    {
        _repository.Add(propiedad);
    }

    public Propiedad ObtenerPorId(int id)
    {
        return _repository.GetById(id);
    }
}