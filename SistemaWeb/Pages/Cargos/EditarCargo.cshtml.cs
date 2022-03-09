using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;

namespace SistemaWeb.Pages.Cargos;

[BindProperties]
public class EditarCargo : PageModel
{
    private readonly ApplicationDbContext _db;
    public Model.Cargo Cargo { get; set; }

    public EditarCargo(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet(int id)
    {
        Cargo = _db.Cargo.Find(id)!;
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Cargo.Update(Cargo);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexCargo");
        }
        return Page();
    }
}