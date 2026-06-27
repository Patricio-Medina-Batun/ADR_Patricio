using System.Text.Json;
using TallerApp.Domain;

namespace TallerApp.Infrastructure;

public class JsonOrdenRepository : IOrdenRepository
{
    private readonly string _filePath = "taller_data.json";

    public List<OrdenTrabajo> ObtenerTodas()
    {
        if (!File.Exists(_filePath)) return new List<OrdenTrabajo>();

        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<OrdenTrabajo>>(json) ?? new List<OrdenTrabajo>();
    }

    public void Guardar(OrdenTrabajo orden)
    {
        var ordenes = ObtenerTodas();
        ordenes.Add(orden);

        var json = JsonSerializer.Serialize(ordenes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }
}