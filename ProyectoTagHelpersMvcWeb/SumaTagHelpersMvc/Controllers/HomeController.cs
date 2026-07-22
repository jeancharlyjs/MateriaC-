using Microsoft.AspNetCore.Mvc;
using SumaTagHelpersMvc.Models;
using SumaTagHelpersMvc.Services;

namespace SumaTagHelpersMvc.Controllers;

public class HomeController : Controller
{
    private readonly CalculadoraService _calculadora;

    public HomeController(CalculadoraService calculadora)
    {
        _calculadora = calculadora;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(CrearModelo());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(SumaTagHelpersViewModel model)
    {
        model.Operaciones = CrearModelo().Operaciones;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        model.Resultado = _calculadora.Sumar(model.Numero1!.Value, model.Numero2!.Value);
        return View(model);
    }

    private static SumaTagHelpersViewModel CrearModelo()
    {
        return new SumaTagHelpersViewModel();
    }
}
