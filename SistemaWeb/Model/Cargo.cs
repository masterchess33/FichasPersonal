using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Model;

public class Cargo
{
    [Key]
    public int CargoId { get; set; }
    
    [Required(ErrorMessage = "El Nombre es requerido")]
    [DisplayName("Nombre:")]
    public string? Nombre { get; set; }
    
    public List<Empleado>? Empleados { get; set; }
}