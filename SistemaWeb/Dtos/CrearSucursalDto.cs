using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Dtos;

public class CrearSucursalDto
{
    [Required(ErrorMessage = "El nombre es requerido")]
    public string? Nombre { get; set; }

    [Phone] 
    public string? Telefono { get; set; }
    
    [Required(ErrorMessage = "Seleccionar una dirección es requerido")]
    [DisplayName("Dirección:")]
    public int IdDireccion { get; set; }
}