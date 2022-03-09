using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Cargos;

[BindProperties]
public class CrearCargo : PageModel
{

    private readonly ApplicationDbContext _db;
    public Cargo Cargo { get; set; }

    public CrearCargo(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        
    }
    
    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            await _db.Cargo.AddAsync(Cargo);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexCargo");
        }
        return Page();
    }
}