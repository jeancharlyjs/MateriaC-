using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Tests;

[TestClass]
public class CalculadoraTests
{
    private Calculadora _calc = null!;

    // Se ejecuta antes de CADA prueba: prepara un objeto limpio.
    [TestInitialize]
    public void Inicializar()
    {
        _calc = new Calculadora();
    }

    [TestMethod]
    public void Sumar_DosNumerosPositivos_RetornaLaSuma()
    {
        // Arrange
        int a = 5, b = 3;

        // Act
        int resultado = _calc.Sumar(a, b);

        // Assert
        Assert.AreEqual(8, resultado);
    }

    [TestMethod]
    public void Restar_DosNumeros_RetornaLaDiferencia()
    {
        int resultado = _calc.Restar(10, 4);
        Assert.AreEqual(6, resultado);
    }

    [TestMethod]
    public void Multiplicar_DosNumeros_RetornaElProducto()
    {
        int resultado = _calc.Multiplicar(6, 7);
        Assert.AreEqual(42, resultado);
    }

    [TestMethod]
    public void Dividir_NumerosValidos_RetornaElCociente()
    {
        double resultado = _calc.Dividir(10, 4);
        Assert.AreEqual(2.5, resultado, 0.0001); // tolerancia para double
    }

    [TestMethod]
    public void Dividir_EntreCero_LanzaExcepcion()
    {
        Assert.ThrowsException<DivideByZeroException>(() => _calc.Dividir(10, 0));
    }

    // Pruebas parametrizadas: un mismo test con varios juegos de datos.
    [DataTestMethod]
    [DataRow(2, true)]
    [DataRow(0, true)]
    [DataRow(7, false)]
    [DataRow(-4, true)]
    public void EsPar_DevuelveResultadoEsperado(int numero, bool esperado)
    {
        Assert.AreEqual(esperado, _calc.EsPar(numero));
    }

    [DataTestMethod]
    [DataRow(2, true)]
    [DataRow(3, true)]
    [DataRow(4, false)]
    [DataRow(11, true)]
    [DataRow(1, false)]
    [DataRow(9, false)]
    public void EsPrimo_DevuelveResultadoEsperado(int numero, bool esperado)
    {
        Assert.AreEqual(esperado, _calc.EsPrimo(numero));
    }
}
