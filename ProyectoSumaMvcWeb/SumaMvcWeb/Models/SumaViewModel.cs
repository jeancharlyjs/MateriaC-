using System.ComponentModel.DataAnnotations;

namespace SumaMvcWeb.Models;

public class SumaViewModel
{
    [Required(ErrorMessage = "Digite el primer numero.")]
    [Display(Name = "Primer numero")]
    public decimal? Numero1 { get; set; }

    [Required(ErrorMessage = "Digite el segundo numero.")]
    [Display(Name = "Segundo numero")]
    public decimal? Numero2 { get; set; }

    public decimal? Resultado { get; set; }
}
