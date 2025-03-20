using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JCVL20250320.AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }


    [Display(Name = "Nombre Del Producto")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Description { get; set; }

    [Display(Name = "Precio")]
    [Required(ErrorMessage = "El precio es obligatorio")]
    public decimal Price { get; set; }

    [Display(Name = "Categoria")]
    public int? CategoryId { get; set; }

    [Display(Name = "Marca")]
    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
