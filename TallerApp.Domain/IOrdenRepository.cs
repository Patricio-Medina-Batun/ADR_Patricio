namespace TallerApp.Domain;

public interface IOrdenRepository
{
    List<OrdenTrabajo> ObtenerTodas();
    void Guardar(OrdenTrabajo orden);
}