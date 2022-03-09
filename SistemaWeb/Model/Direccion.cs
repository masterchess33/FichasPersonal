using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Model;

public class Direccion
{
    [Key]
    public int DireccionId { get; set; }
    
    [Required(ErrorMessage = "La calle es requerida")]
    [DisplayName("Calle:")]
    public string? Calle { get; set; }
    
    [Required(ErrorMessage = "El Pais es requerido")]
    [DisplayName("País:")]
    public string? Pais { get; set; }
    
    [Required(ErrorMessage = "La ciudad es requerida")]
    [DisplayName("Ciudad:")]
    public string? Ciudad { get; set; }
    
    [DisplayName("Departamento:")]
    public string? Departamento { get; set; }

    public virtual Sucursal? Sucursal { get; set; }
    public List<Empleado>? Empleados { get; set; }
}