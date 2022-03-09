using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Direcciones;

[BindProperties]
public class CrearDireccion : PageModel
{
    private readonly ApplicationDbContext _db;
    
    public Direccion Direccion { get; set; }
    public string RutaRetorno;

    public CrearDireccion(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet(string returnRute)
    {
        RutaRetorno = returnRute;
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            await _db.Direccion.AddAsync(Direccion);
            await _db.SaveChangesAsync();
            return RedirectToPage(RutaRetorno);
        }

        return Page();
    }
}