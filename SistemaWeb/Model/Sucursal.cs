using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Model;

public class Sucursal
{
    [Key]
    public int SucursalId { get; set; }
    
    [Required(ErrorMessage = "El nombre es requerido")]
    [DisplayName("Nombre:")]
    public string? Nombre { get; set; }
    
    [Phone]
    [DisplayName("Teléfono:")]
    public string? Telefono { get; set; }
    
    public List<Horario>? Horarios { get; set; }

    public List<Departamento>? Departamentos { get; set; }
    
    public int? DireccionId { get; set; }
    public virtual Direccion? Direccion { get; set; }
}