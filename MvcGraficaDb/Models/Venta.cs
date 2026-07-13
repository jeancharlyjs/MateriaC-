using System.ComponentModel.DataAnnotations;

namespace MvcGraficaDb.Models;

public class Venta
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Mes { get; set; } = string.Empty;

    [Range(0, double.MaxValue)]
    public decimal Total { get; set; }
}
