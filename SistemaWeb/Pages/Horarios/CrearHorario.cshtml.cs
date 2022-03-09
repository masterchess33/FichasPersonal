using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;

namespace SistemaWeb.Pages.Horarios;

[BindProperties]
public class CrearHorario : PageModel
{

    private readonly ApplicationDbContext _db;
    
    public Model.Horario Horario { get; set; }

    public CrearHorario(ApplicationDbContext db)
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
            await _db.Horario.AddAsync(Horario);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexHorario");
        }
        return Page();
    }
}