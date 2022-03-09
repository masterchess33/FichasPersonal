using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;

namespace SistemaWeb.Pages.Horarios;

[BindProperties]
public class EditarHorario : PageModel
{

    private readonly ApplicationDbContext _db;
    
    public Model.Horario Horario { get; set; }

    public EditarHorario(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet(int id)
    {
        Horario = _db.Horario.Find(id)!;
    }
    
    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Horario.Update(Horario);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexHorario");
        }
        return Page();
    }
}