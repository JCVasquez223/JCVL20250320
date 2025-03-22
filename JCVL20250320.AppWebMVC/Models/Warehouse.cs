using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCVL20250320.AppWebMVC.Models;

public partial class Warehouse
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WarehouseId { get; set; }

    [Required(ErrorMessage = "El nombre de la bodega es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre de la bodega no puede exceder los 100 caracteres")]
    [Display(Name = "Bodegas")]
    public string WarehouseName { get; set; } = null!;

    [StringLength(500, ErrorMessage = "Las notas es demasiado larga")]
    [Required(ErrorMessage = "La notas de la bodega es obligatorio")]
    [Display(Name = "Notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
