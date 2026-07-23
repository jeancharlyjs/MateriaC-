using MvcGraficaDb.Models;

namespace MvcGraficaDb.Services;

public class VentasGraficaService
{
    public VentasGraficaViewModel CrearModelo(IEnumerable<Venta> ventas)
    {
        var lista = ventas.OrderBy(v => v.Id).ToList();

        return new VentasGraficaViewModel
        {
            Meses = lista.Select(v => v.Mes).ToList(),
            Totales = lista.Select(v => v.Total).ToList(),
            TotalGeneral = lista.Sum(v => v.Total),
            Promedio = lista.Count == 0 ? 0 : lista.Average(v => v.Total)
        };
    }
}
