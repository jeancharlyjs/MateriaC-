using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumaMvcWeb.Services;

namespace SumaMvcWeb.Tests;

[TestClass]
public class CalculadoraServiceTests
{
    [TestMethod]
    public void Sumar_DosNumerosPositivos_RetornaResultadoCorrecto()
    {
        var calculadora = new CalculadoraService();

        var resultado = calculadora.Sumar(8, 5);

        Assert.AreEqual(13, resultado);
    }

    [TestMethod]
    public void Sumar_NumeroPositivoYNegativo_RetornaResultadoCorrecto()
    {
        var calculadora = new CalculadoraService();

        var resultado = calculadora.Sumar(10, -4);

        Assert.AreEqual(6, resultado);
    }

    [TestMethod]
    public void Sumar_NumerosDecimales_RetornaResultadoCorrecto()
    {
        var calculadora = new CalculadoraService();

        var resultado = calculadora.Sumar(2.5m, 3.75m);

        Assert.AreEqual(6.25m, resultado);
    }
}
