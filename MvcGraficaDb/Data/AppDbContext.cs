using Microsoft.EntityFrameworkCore;
using MvcGraficaDb.Models;

namespace MvcGraficaDb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Venta> Ventas => Set<Venta>();
}
