using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Direcciones;

[BindProperties]
public class EliminarDireccion : PageModel
{
    private readonly ApplicationDbContext _db;
    public Direccion Direccion { get; set; }

    public EliminarDireccion(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Direccion = _db.Direccion.Find(id)!;
    }

    public async Task<IActionResult> OnPost()
    {
        var direccionDb = await _db.Direccion.FindAsync(Direccion.DireccionId);
        
        if (direccionDb != null)
        {
            Console.WriteLine("hola");
            _db.Direccion.Remove(direccionDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexDireccion");
        }
        else
        {
            Console.WriteLine("hola else");
        }

        return Page();
    }
}