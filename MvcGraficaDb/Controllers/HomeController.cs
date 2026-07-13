using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGraficaDb.Data;
using MvcGraficaDb.Models;

namespace MvcGraficaDb.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;

    public HomeController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var ventas = await _db.Ventas
            .OrderBy(v => v.Id)
            .ToListAsync();

        var model = new VentasGraficaViewModel
        {
            Meses = ventas.Select(v => v.Mes).ToList(),
            Totales = ventas.Select(v => v.Total).ToList(),
            TotalGeneral = ventas.Sum(v => v.Total),
            Promedio = ventas.Count == 0 ? 0 : ventas.Average(v => v.Total)
        };

        return View(model);
    }
}
