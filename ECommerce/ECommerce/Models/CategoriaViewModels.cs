using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ECommerce.Models;

namespace ECommerce.Models
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        public string Categoria { get; set; }

        public bool Seleccionada { get; set; }
    }
}