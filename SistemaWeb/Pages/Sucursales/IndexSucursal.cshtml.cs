using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Sucursales;

public class IndexSucursal : PageModel
{

    private readonly ApplicationDbContext _db;
    public IEnumerable<Sucursal> Sucursales { get; set; }
    
    public IndexSucursal(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Sucursales = _db.Sucursal;
    }
}