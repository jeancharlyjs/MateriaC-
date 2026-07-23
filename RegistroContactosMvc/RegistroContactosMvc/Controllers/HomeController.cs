using Microsoft.AspNetCore.Mvc;

namespace RegistroContactosMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Contactos");
    }
}
