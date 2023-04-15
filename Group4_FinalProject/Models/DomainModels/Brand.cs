using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Group4_FinalProject.Models
{
    public class Brand
    {
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Please enter a brand.")]
        [StringLength(200)]
        [Remote("CheckBrand", "Validation", "Admin", AdditionalFields = "Operation")]
        public string Name { get; set; }

        public string FullName => $"{Name}";

        public ICollection<ProductBrand> ProductBrands { get; set; }
    }
}
