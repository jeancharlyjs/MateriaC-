# Pruebas Unitarias en C# / .NET

Proyecto de ejemplo para el tema **Introducción a pruebas unitarias en C# .NET (Unit Testing)**.
Usa **.NET 8** y el framework de pruebas **MSTest**.

## Estructura

```
PruebasUnitarias/
├── PruebasUnitarias.sln          # Solución
├── Calculadora/                  # Proyecto con el código a probar
│   ├── Calculadora.csproj
│   └── Calculadora.cs
├── Calculadora.Tests/            # Proyecto de pruebas unitarias
│   ├── Calculadora.Tests.csproj
│   └── CalculadoraTests.cs
└── .github/workflows/dotnet.yml  # CI: compila y ejecuta las pruebas en GitHub
```

## Cómo ejecutar

Necesitas el **SDK de .NET 8** ([descarga](https://dotnet.microsoft.com/download)).
En Codespaces / workstation de GitHub ya viene instalado.

```bash
cd PruebasUnitarias

# Restaurar paquetes NuGet
dotnet restore

# Compilar
dotnet build

# Ejecutar las pruebas unitarias
dotnet test
```

Salida esperada (todas en verde):

```
Aprobado! - Con error: 0, Superado: 15, Omitido: 0, Total: 15
```

## Conceptos que muestra el proyecto

- **Patrón AAA** (Arrange – Act – Assert) para estructurar cada prueba.
- `[TestClass]` y `[TestMethod]`: marcan la clase y los métodos de prueba.
- `[TestInitialize]`: prepara un objeto limpio antes de cada prueba.
- `Assert.AreEqual`, `Assert.ThrowsException`: verificaciones.
- **Pruebas parametrizadas** con `[DataTestMethod]` + `[DataRow]` (un mismo test con varios datos).
- Manejo de **excepciones** (división entre cero).

## GitHub Actions

El archivo `.github/workflows/dotnet.yml` ejecuta automáticamente las pruebas
en cada `push` o `pull request`. Para que funcione, la carpeta `.github` debe
quedar en la **raíz del repositorio**.
