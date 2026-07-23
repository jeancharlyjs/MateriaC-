using RegistroContactosMvc.Models;

namespace RegistroContactosMvc.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext db)
    {
        if (db.Contactos.Any())
        {
            return;
        }

        db.Contactos.AddRange(
            new Contacto
            {
                Nombre = "Ana Martinez",
                Telefono = "809-555-1020",
                Correo = "ana.martinez@email.com",
                Ciudad = "Santo Domingo",
                FechaRegistro = DateTime.Today.AddDays(-8)
            },
            new Contacto
            {
                Nombre = "Carlos Perez",
                Telefono = "829-555-3311",
                Correo = "carlos.perez@email.com",
                Ciudad = "Santiago",
                FechaRegistro = DateTime.Today.AddDays(-5)
            },
            new Contacto
            {
                Nombre = "Laura Gomez",
                Telefono = "849-555-7788",
                Correo = "laura.gomez@email.com",
                Ciudad = "La Romana",
                FechaRegistro = DateTime.Today.AddDays(-2)
            }
        );

        db.SaveChanges();
    }
}
