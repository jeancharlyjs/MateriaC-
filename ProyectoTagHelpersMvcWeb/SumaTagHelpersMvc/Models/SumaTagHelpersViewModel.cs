using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SumaTagHelpersMvc.Models;

public class SumaTagHelpersViewModel
{
    [Required(ErrorMessage = "Digite el primer numero.")]
    [Display(Name = "Primer numero")]
    public decimal? Numero1 { get; set; }

    [Required(ErrorMessage = "Digite el segundo numero.")]
    [Display(Name = "Segundo numero")]
    public decimal? Numero2 { get; set; }

    [Required(ErrorMessage = "Seleccione una operacion.")]
    [Display(Name = "Operacion")]
    public string Operacion { get; set; } = "sumar";

    [Display(Name = "Observacion")]
    [StringLength(200, ErrorMessage = "La observacion no puede pasar de 200 caracteres.")]
    public string? Observacion { get; set; }

    public decimal? Resultado { get; set; }

    public List<SelectListItem> Operaciones { get; set; } =
    [
        new SelectListItem("Sumar", "sumar")
    ];
}
