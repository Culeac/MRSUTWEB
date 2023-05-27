using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplication1.Models.Product
{
    public class NewProduct
    {
        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Numele produsului este obligatoriu")]
        public string Name { get; set; }

        [Display(Name = "Product description")]
        [Required(ErrorMessage = "Descrierea produsului este obligatorie")]
        public string Description { get; set; }

        [Display(Name = "Product price")]
        [Required(ErrorMessage = "Pretul produsului este obligatoriu")]
        public int Price { get; set; }

        [Display(Name = "Product image")]
        public string ImageLink { get; set; }
    }
}