# ProyectoTagHelpersMvcWeb

Proyecto ASP.NET Core MVC en C# que usa Etiquetas Auxiliares de Razor.

## Contenido

- `SumaTagHelpersMvc`: aplicacion MVC Web que solicita dos numeros y calcula la suma.
- `SumaTagHelpersMvc.Tests`: proyecto MSTest con 3 pruebas unitarias.
- `ProyectoTagHelpersMvcWeb.sln`: solucion principal para Visual Studio.

## Tag Helpers incluidos

- Anchor Tag Helper: `asp-controller`, `asp-action`.
- Form Tag Helper: `asp-controller`, `asp-action`, `method`.
- Input Tag Helper: `asp-for`.
- Label Tag Helper: `asp-for`.
- Validation Tag Helpers: `asp-validation-for`, `asp-validation-summary`.
- Select Tag Helper: `asp-items`.
- TextArea Tag Helper: `asp-for`.
- Partial Tag Helper: `partial`.
- Environment Tag Helper: `environment`.
- Link, Script e Image Tag Helpers con `asp-append-version`.
- Cache Tag Helper.
- Tag Helper personalizado: `boton-accion`.

## Ejecutar

```bash
dotnet run --project SumaTagHelpersMvc/SumaTagHelpersMvc.csproj
```

## Ejecutar pruebas

```bash
dotnet test SumaTagHelpersMvc.Tests/SumaTagHelpersMvc.Tests.csproj
```
