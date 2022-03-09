using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Direcciones;

public class IndexDireccion : PageModel
{

    private readonly ApplicationDbContext _db;
    public IEnumerable<Direccion> Direcciones { get; set; }
    
    public IndexDireccion(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Direcciones = _db.Direccion;
    }
}