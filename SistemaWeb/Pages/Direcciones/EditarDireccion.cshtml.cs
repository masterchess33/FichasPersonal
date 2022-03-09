using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Direcciones;

[BindProperties]
public class EditarDireccion : PageModel
{
    private readonly ApplicationDbContext _db;
    public Direccion Direccion { get; set; }

    public EditarDireccion(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Direccion = _db.Direccion.Find(id)!;
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Direccion.Update(Direccion);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexDireccion");
        }

        return Page();
    }
}