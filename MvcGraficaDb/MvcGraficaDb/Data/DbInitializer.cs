using MvcGraficaDb.Models;

namespace MvcGraficaDb.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext db)
    {
        if (db.Ventas.Any())
        {
            return;
        }

        db.Ventas.AddRange(
            new Venta { Mes = "Enero", Total = 18500 },
            new Venta { Mes = "Febrero", Total = 22100 },
            new Venta { Mes = "Marzo", Total = 19800 },
            new Venta { Mes = "Abril", Total = 26300 },
            new Venta { Mes = "Mayo", Total = 31200 },
            new Venta { Mes = "Junio", Total = 28750 },
            new Venta { Mes = "Julio", Total = 35400 }
        );

        db.SaveChanges();
    }
}
