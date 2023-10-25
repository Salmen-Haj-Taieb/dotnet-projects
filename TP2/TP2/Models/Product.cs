﻿using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string? Designation { get; set; }
        [Required]
        [Display(Name = "Prix en dinar :")]
        public float Prix { get; set; }
        [Required]
        [Display(Name = "Quantité en unité :")]
        public int Quantite { get; set; }
        [Required]
        [Display(Name = "Image :")]
        public string ImagePath { get; set; } = string.Empty;

    }
}
