using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroContactosMvc.Data;
using RegistroContactosMvc.Models;

namespace RegistroContactosMvc.Controllers;

public class ContactosController : Controller
{
    private readonly AppDbContext _db;

    public ContactosController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index(string? buscar)
    {
        var consulta = _db.Contactos.AsQueryable();

        if (!string.IsNullOrWhiteSpace(buscar))
        {
            consulta = consulta.Where(c =>
                c.Nombre.Contains(buscar) ||
                c.Telefono.Contains(buscar) ||
                c.Correo.Contains(buscar) ||
                c.Ciudad.Contains(buscar));
        }

        var contactos = await consulta
            .OrderBy(c => c.Nombre)
            .ToListAsync();

        ViewBag.Buscar = buscar;
        return View(contactos);
    }

    public async Task<IActionResult> Details(int id)
    {
        var contacto = await _db.Contactos.FirstOrDefaultAsync(c => c.Id == id);

        if (contacto is null)
        {
            return NotFound();
        }

        return View(contacto);
    }

    public IActionResult Create()
    {
        return View(new Contacto { FechaRegistro = DateTime.Today });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Contacto contacto)
    {
        if (!ModelState.IsValid)
        {
            return View(contacto);
        }

        _db.Contactos.Add(contacto);
        await _db.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var contacto = await _db.Contactos.FindAsync(id);

        if (contacto is null)
        {
            return NotFound();
        }

        return View(contacto);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Contacto contacto)
    {
        if (id != contacto.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(contacto);
        }

        _db.Update(contacto);
        await _db.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var contacto = await _db.Contactos.FirstOrDefaultAsync(c => c.Id == id);

        if (contacto is null)
        {
            return NotFound();
        }

        return View(contacto);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var contacto = await _db.Contactos.FindAsync(id);

        if (contacto is not null)
        {
            _db.Contactos.Remove(contacto);
            await _db.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
