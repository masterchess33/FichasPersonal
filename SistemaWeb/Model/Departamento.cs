using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Model;

public class Departamento
{
    [Key]
    public int DepartamentoId { get; set; }
    
    [Required(ErrorMessage = "El nombre es requerido")]
    public string? Nombre { get; set; }
    
    public Sucursal? Sucursal { get; set; }

    public List<Empleado>? Empleados { get; set; }
}