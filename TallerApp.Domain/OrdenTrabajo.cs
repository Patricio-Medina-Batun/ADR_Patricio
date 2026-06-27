namespace TallerApp.Domain;

public class OrdenTrabajo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Placas { get; set; } = string.Empty;
    public string FallaReportada { get; set; } = string.Empty;
    public string DiagnosticoMecanico { get; set; } = string.Empty;
    public string Estado { get; set; } = "En Revisión"; 
    public DateTime FechaIngreso { get; set; } = DateTime.Now;
}