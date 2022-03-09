using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Cargos;

public class IndexHorario : PageModel
{

    private readonly ApplicationDbContext _db;
    public IEnumerable<Model.Horario> Horarios { get; set; }
    
    public IndexHorario(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Horarios = _db.Horario;
    }
}