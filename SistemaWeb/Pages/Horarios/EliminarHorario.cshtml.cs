using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaWeb.Data;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Horarios;

[BindProperties]
public class EliminarHorario : PageModel
{

    private readonly ApplicationDbContext _db;
    
    public Model.Horario Horario { get; set; }

    public EliminarHorario(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Horario = _db.Horario.Find(id)!;
    }
    
    public async Task<IActionResult> OnPost()
    {
        var horarioDeDb = await _db.Horario.FindAsync(Horario.HorarioId);
        
        if (horarioDeDb != null)
        {
            _db.Horario.Remove(horarioDeDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexHorario");
        }
        return Page();
    }
}