using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace SistemaWeb.Model;

public class Horario
{
    [Key]
    public int HorarioId { get; set; }
    
    [Required(ErrorMessage = "El dia de inicio es requerido")]
    [DisplayName("Dia de Inicio:")]
    public string? DiaInicio { get; set; }
    
    [Required(ErrorMessage = "El dia de termino es requerido")]
    [DisplayName("Dia de Termino:")]
    public string? DiaTermino { get; set; }
    
    [Required(ErrorMessage = "La hora de inicio es requerida")]
    [DisplayName("Hora de Inicio:")]
    public TimeSpan HoraInicio { get; set; }
    
    [Required(ErrorMessage = "La hora de termino es requerida")]
    [DisplayName("Hora de Termino:")]
    public TimeSpan HoraTermino { get; set; }

    public List<Sucursal>? Sucursales { get; set; }
}