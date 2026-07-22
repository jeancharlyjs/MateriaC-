# Aplicacion MVC Web con Tag Helpers

Esta aplicacion esta hecha en C# con ASP.NET Core MVC. Solicita dos numeros, calcula la suma y muestra el resultado usando Etiquetas Auxiliares de Razor.

## Como ejecutarla

1. Instala el SDK de .NET 8 si no lo tienes.
2. Abre la solucion `ProyectoTagHelpersMvcWeb.sln` en Visual Studio.
3. Ejecuta el proyecto `SumaTagHelpersMvc`.

Tambien puedes usar terminal:

```bash
dotnet restore
dotnet run --project SumaTagHelpersMvc/SumaTagHelpersMvc.csproj
```

Abre la URL que muestre la terminal, normalmente:

```text
https://localhost:5001
```

## Como ejecutar las pruebas

En Visual Studio:

```text
Test > Test Explorer > Run All Tests
```

En terminal, desde la carpeta de la solucion:

```bash
dotnet test SumaTagHelpersMvc.Tests/SumaTagHelpersMvc.Tests.csproj
```

## Archivos principales

- `Models/SumaTagHelpersViewModel.cs`: modelo usado por el formulario.
- `Services/CalculadoraService.cs`: logica de suma.
- `Controllers/HomeController.cs`: recibe los numeros y envia el resultado a la vista.
- `Views/Home/Index.cshtml`: formulario MVC Web.
- `TagHelpers/BotonAccionTagHelper.cs`: Tag Helper personalizado.
- `../SumaTagHelpersMvc.Tests/CalculadoraServiceTests.cs`: tres pruebas unitarias.
