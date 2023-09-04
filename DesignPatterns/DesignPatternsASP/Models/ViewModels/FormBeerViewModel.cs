﻿using System.ComponentModel.DataAnnotations;

namespace DesignPatternsASP.Models.ViewModels
{
    public class FormBeerViewModel
    {
        [Required]
        [Display(Name="Nombre")]
        public string Name { get; set; } = null!;
        [Required]
        [Display(Name="Estilo")]
        public string Style { get; set; } = null!;
        [Display(Name="Marca")]
        public Guid? BrandId { get; set; }
        [Display(Name="Otra marca")]
        public string? OtherBrand { get; set; }
    }
}
