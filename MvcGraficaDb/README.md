# Aplicacion MVC Core con base de datos y grafica

Esta aplicacion esta hecha en C# con ASP.NET Core MVC, Entity Framework Core y SQLite.

## Como ejecutarla

1. Instala el SDK de .NET 8 si no lo tienes.
2. Abre una terminal en esta carpeta.
3. Restaura los paquetes:

```bash
dotnet restore
```

4. Ejecuta la aplicacion:

```bash
dotnet run
```

5. Abre la URL que muestre la terminal, normalmente:

```text
https://localhost:5001
```

La base de datos `ventas.db` se crea automaticamente la primera vez que corre la aplicacion.

## Archivos principales

- `Models/Venta.cs`: modelo de datos.
- `Data/AppDbContext.cs`: conexion con la base de datos.
- `Data/DbInitializer.cs`: datos iniciales para la grafica.
- `Controllers/HomeController.cs`: consulta los datos y los manda a la vista.
- `Views/Home/Index.cshtml`: pagina que muestra la grafica.
- `wwwroot/js/ventas-chart.js`: configuracion de Chart.js.
