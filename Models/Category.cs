﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace konoha.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Display(Name="Nombre")]
        [Required]
        [StringLength(40, MinimumLength = 3, ErrorMessage ="Debes ingrsar de 3 a 50 caracteres")]
        public string  Name { get; set;  }

        [Display(Name="Acronimo")]
        [StringLength(20, MinimumLength = 3 , ErrorMessage = "Dedes ingresar menos de 3 a 20 caracteres")]
        public string Acronym { get; set; }

        [Display(Name="Descripción")]
        [StringLength(200, MinimumLength = 3, ErrorMessage ="Dedes ingresar menos de 3 a 200 caracteres")]
        public string Desciption { get; set; }

        public List<Post> Posts { get; set; }

    }
}
