using Microsoft.EntityFrameworkCore;
using AppSaveMoney.Models;
using AppSaveMoney.EntityLayer;

namespace AppSaveMoney.Datos;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Transaccion> Transacciones { get; set; }
    public DbSet<Presupuesto> Presupuestos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}

