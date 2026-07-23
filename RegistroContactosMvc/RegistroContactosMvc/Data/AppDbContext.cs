using Microsoft.EntityFrameworkCore;
using RegistroContactosMvc.Models;

namespace RegistroContactosMvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Contacto> Contactos => Set<Contacto>();
}
