namespace Calculadora;

/// <summary>
/// Clase de ejemplo con operaciones aritméticas básicas.
/// Sirve como "código bajo prueba" (System Under Test) para las pruebas unitarias.
/// </summary>
public class Calculadora
{
    /// <summary>Suma dos números.</summary>
    public int Sumar(int a, int b) => a + b;

    /// <summary>Resta dos números.</summary>
    public int Restar(int a, int b) => a - b;

    /// <summary>Multiplica dos números.</summary>
    public int Multiplicar(int a, int b) => a * b;

    /// <summary>
    /// Divide dos números.
    /// Lanza <see cref="DivideByZeroException"/> si el divisor es 0.
    /// </summary>
    public double Dividir(int dividendo, int divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException("No se puede dividir entre cero.");

        return (double)dividendo / divisor;
    }

    /// <summary>Indica si un número es par.</summary>
    public bool EsPar(int numero) => numero % 2 == 0;

    /// <summary>Indica si un número entero es primo.</summary>
    public bool EsPrimo(int numero)
    {
        if (numero < 2) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
