using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;

namespace SistemaWeb.Pages.Cargos;

public class IndexCargo : PageModel
{

    private readonly ApplicationDbContext _db;
    public IEnumerable<Model.Cargo> Cargos { get; set; }
    
    public IndexCargo(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Cargos = _db.Cargo;
    }
}