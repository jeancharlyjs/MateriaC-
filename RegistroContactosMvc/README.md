# Registro de Contactos MVC Core

Aplicacion web hecha con C#, ASP.NET Core MVC, Razor, Entity Framework Core y SQLite.

## Funciones

- Listar contactos guardados en la base de datos.
- Buscar contactos por nombre, telefono, correo o ciudad.
- Crear nuevos contactos.
- Editar contactos existentes.
- Ver detalle de un contacto.
- Eliminar contactos.
- Visualizar los datos usando vistas Razor.

## Como ejecutarlo

Abre una terminal dentro de esta carpeta:

```bash
cd RegistroContactosMvc
dotnet restore
dotnet run
```

Luego abre la direccion que muestre la terminal.

Tambien puedes abrir `RegistroContactosMvc.sln` en Visual Studio y ejecutar el proyecto.

## Base de datos

La aplicacion usa SQLite con el archivo `contactos.db`.

La base de datos se crea automaticamente cuando corres el proyecto por primera vez.

## Archivos principales

- `RegistroContactosMvc/Models/Contacto.cs`
- `RegistroContactosMvc/Data/AppDbContext.cs`
- `RegistroContactosMvc/Data/DbInitializer.cs`
- `RegistroContactosMvc/Controllers/ContactosController.cs`
- `RegistroContactosMvc/Views/Contactos/Index.cshtml`
- `RegistroContactosMvc/Views/Contactos/Create.cshtml`
- `RegistroContactosMvc/Views/Contactos/Edit.cshtml`
- `RegistroContactosMvc/Views/Contactos/Details.cshtml`
- `RegistroContactosMvc/Views/Contactos/Delete.cshtml`
