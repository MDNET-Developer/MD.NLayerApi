﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProductFeature
    {
        //Burada Product ile bire bir baglanti olacagi ucun productda BaseEntity istiafe etdiyimiz ucun burada istifade etmeyimize ehtiyyac yoxdur.
        public int Id { get; set; }
        public string? Color { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
