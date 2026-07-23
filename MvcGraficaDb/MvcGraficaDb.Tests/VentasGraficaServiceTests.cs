using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcGraficaDb.Models;
using MvcGraficaDb.Services;

namespace MvcGraficaDb.Tests;

[TestClass]
public class VentasGraficaServiceTests
{
    [TestMethod]
    public void CrearModelo_CuandoHayVentas_CalculaTotalGeneralYPromedio()
    {
        var service = new VentasGraficaService();
        var ventas = new List<Venta>
        {
            new() { Id = 1, Mes = "Enero", Total = 1000 },
            new() { Id = 2, Mes = "Febrero", Total = 2000 },
            new() { Id = 3, Mes = "Marzo", Total = 3000 }
        };

        var resultado = service.CrearModelo(ventas);

        Assert.AreEqual(6000, resultado.TotalGeneral);
        Assert.AreEqual(2000, resultado.Promedio);
    }

    [TestMethod]
    public void CrearModelo_CuandoNoHayVentas_RetornaValoresEnCero()
    {
        var service = new VentasGraficaService();
        var ventas = new List<Venta>();

        var resultado = service.CrearModelo(ventas);

        Assert.AreEqual(0, resultado.TotalGeneral);
        Assert.AreEqual(0, resultado.Promedio);
        Assert.AreEqual(0, resultado.Meses.Count);
        Assert.AreEqual(0, resultado.Totales.Count);
    }

    [TestMethod]
    public void CrearModelo_OrdenaVentasPorIdAntesDeGraficar()
    {
        var service = new VentasGraficaService();
        var ventas = new List<Venta>
        {
            new() { Id = 3, Mes = "Marzo", Total = 3000 },
            new() { Id = 1, Mes = "Enero", Total = 1000 },
            new() { Id = 2, Mes = "Febrero", Total = 2000 }
        };

        var resultado = service.CrearModelo(ventas);

        CollectionAssert.AreEqual(
            new List<string> { "Enero", "Febrero", "Marzo" },
            resultado.Meses.ToList());
        CollectionAssert.AreEqual(
            new List<decimal> { 1000, 2000, 3000 },
            resultado.Totales.ToList());
    }
}
