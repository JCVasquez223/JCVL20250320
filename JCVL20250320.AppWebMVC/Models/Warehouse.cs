using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250320.AppWebMVC.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }


    [Display(Name = "Bodegas")]
    public string WarehouseName { get; set; } = null!;


    [Display(Name = "Notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
