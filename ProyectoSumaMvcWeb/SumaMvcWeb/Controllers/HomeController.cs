using Microsoft.AspNetCore.Mvc;
using SumaMvcWeb.Models;
using SumaMvcWeb.Services;

namespace SumaMvcWeb.Controllers;

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
        return View(new SumaViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(SumaViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        model.Resultado = _calculadora.Sumar(model.Numero1!.Value, model.Numero2!.Value);
        return View(model);
    }
}
