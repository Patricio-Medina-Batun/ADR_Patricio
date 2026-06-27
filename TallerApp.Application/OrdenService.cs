using TallerApp.Domain;

namespace TallerApp.Application;

public class OrdenService
{
    private readonly IOrdenRepository _repository;

    
    public OrdenService(IOrdenRepository repository)
    {
        _repository = repository;
    }

    public List<OrdenTrabajo> ObtenerHistorial()
    {
        return _repository.ObtenerTodas().OrderByDescending(o => o.FechaIngreso).ToList();
    }

    public void RecibirVehiculo(OrdenTrabajo nuevaOrden)
    {
        
        _repository.Guardar(nuevaOrden);
    }
}