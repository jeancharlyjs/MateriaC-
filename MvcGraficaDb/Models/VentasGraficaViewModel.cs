namespace MvcGraficaDb.Models;

public class VentasGraficaViewModel
{
    public IReadOnlyList<string> Meses { get; init; } = [];
    public IReadOnlyList<decimal> Totales { get; init; } = [];
    public decimal TotalGeneral { get; init; }
    public decimal Promedio { get; init; }
}
