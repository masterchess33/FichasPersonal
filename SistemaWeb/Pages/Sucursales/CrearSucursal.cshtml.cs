using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaWeb.Data;
using SistemaWeb.Dtos;
using SistemaWeb.Model;

namespace SistemaWeb.Pages.Sucursales;

[BindProperties]
public class CrearSucursal : PageModel
{
    private readonly ApplicationDbContext _db;
    public CrearSucursalDto Sucursal { get; set; }

    public IEnumerable<SelectListItem> Direcciones { get; set; }

    public CrearSucursal(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult OnGet()
    {

        Direcciones = ListaDirecciones();
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            var nuevaScursal = new Sucursal
            {
                Nombre = Sucursal.Nombre, Telefono = Sucursal.Telefono,
                Direccion = await _db.Direccion.FindAsync(Sucursal.IdDireccion)
            };
            await _db.Sucursal.AddAsync(nuevaScursal);
            await _db.SaveChangesAsync();
            return RedirectToPage("IndexSucursal");
        }


        Direcciones = ListaDirecciones();
        return Page();
    }

    private IEnumerable<SelectListItem> ListaDirecciones()
    {
        var direcionesDb = _db.Direccion;
        
        return direcionesDb.Select(m =>
            new SelectListItem
                {Value = m.DireccionId.ToString(), Text = m.Calle + ", " + m.Departamento + ", " + m.Ciudad + ", " + m.Pais});
    }
}