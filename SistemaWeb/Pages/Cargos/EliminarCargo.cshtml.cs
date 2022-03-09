using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Cargos;

[BindProperties]
public class EliminarCargo : PageModel
{
    private readonly ApplicationDbContext _db;
    public Cargo Cargo { get; set; }

    public EliminarCargo(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Cargo = _db.Cargo.Find(id)!;
    }

    public async Task<IActionResult> OnPost()
    {
        var cargoDeDb = await _db.Cargo.FindAsync(Cargo.CargoId);
        
        if (cargoDeDb != null)
        {
            _db.Cargo.Remove(cargoDeDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexCargo");
        }
        return Page();
    }
    
}