using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaWeb.Model;

public class Empleado
{
    [Key]
    public int EmpleadoId { get; set; }
    
    [Required(ErrorMessage = "Los nombres son requeridos")]
    [DisplayName("Nombres:")]
    public string? Nombres { get; set; }
    
    [Required(ErrorMessage = "Los apellidos son requeridos")]
    [DisplayName("Apellidos:")]
    public string? Apellidos { get; set; }
    
    [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
    [DataType(DataType.Date)]
    [DisplayName("Fecha Nacimiento:")]
    public DateTime FechaNacimiento { get; set; }
    
    [Required(ErrorMessage = "El email es requerido")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    [DisplayName("Email:")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "El teléfono es requerido")]
    [Phone]
    [DisplayName("Teléfono:")]
    public string? Telefono { get; set; }
    
    [Required(ErrorMessage = "El DNI es requerido")]
    [DisplayName("DNI:")]
    public string? Dni { get; set; }
    
    [DisplayName("Foto:")]
    public byte[]? Foto { get; set; }

    public Departamento? Departamento { get; set; }
    public Direccion? Direccion { get; set; }
    public Cargo? Cargo { get; set; }
    
}