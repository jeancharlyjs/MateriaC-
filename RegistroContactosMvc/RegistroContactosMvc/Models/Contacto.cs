using System.ComponentModel.DataAnnotations;

namespace RegistroContactosMvc.Models;

public class Contacto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(80, ErrorMessage = "El nombre no puede pasar de 80 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El telefono es obligatorio.")]
    [StringLength(20, ErrorMessage = "El telefono no puede pasar de 20 caracteres.")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Debe escribir un correo valido.")]
    [StringLength(120, ErrorMessage = "El correo no puede pasar de 120 caracteres.")]
    public string Correo { get; set; } = string.Empty;

    [StringLength(60, ErrorMessage = "La ciudad no puede pasar de 60 caracteres.")]
    public string Ciudad { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime FechaRegistro { get; set; } = DateTime.Today;
}
