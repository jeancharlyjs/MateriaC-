using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGraficaDb.Data;
using MvcGraficaDb.Services;

namespace MvcGraficaDb.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;
    private readonly VentasGraficaService _ventasGraficaService;

    public HomeController(AppDbContext db, VentasGraficaService ventasGraficaService)
    {
        _db = db;
        _ventasGraficaService = ventasGraficaService;
    }

    public async Task<IActionResult> Index()
    {
        var ventas = await _db.Ventas
            .OrderBy(v => v.Id)
            .ToListAsync();

        var model = _ventasGraficaService.CrearModelo(ventas);

        return View(model);
    }
}
