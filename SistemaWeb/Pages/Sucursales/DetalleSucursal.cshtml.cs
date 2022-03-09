using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Sucursales;


public class DetalleSucursal : PageModel
{
    private readonly ApplicationDbContext _db;
    
    public Direccion Direccion { get; set; }
    public Sucursal Sucursal { get; set; }

    public DetalleSucursal(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Sucursal = _db.Sucursal.Find(id);
        Direccion = _db.Direccion.Find(Sucursal.DireccionId);
    }
}