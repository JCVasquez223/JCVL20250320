﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JCVL20250320.AppWebMVC.Models;

namespace JCVL20250320.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }


    [Display(Name = "Marcas")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "Pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
