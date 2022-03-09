using Microsoft.EntityFrameworkCore;
using SistemaWeb.Model;

namespace SistemaWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Cargo> Cargo { get; set; }
    public DbSet<Departamento> Departamento { get; set; }
    public DbSet<Direccion> Direccion { get; set; }
    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Horario> Horario { get; set; }
    public DbSet<Sucursal> Sucursal { get; set; }
}