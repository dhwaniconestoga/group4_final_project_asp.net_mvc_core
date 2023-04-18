using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group4_FinalProject.Models.DomainModels
{
    public class Seller
    {
        public int SellerId { get; set; }

        [Required(ErrorMessage = "Please enter a seller.")]
        [StringLength(200)]
        //[Remote("CheckSeller", "Validation", "Admin", AdditionalFields = "Operation")]
        public string Name { get; set; }

        //public string FullName => $"{Name}";

        //public ICollection<ProductBrand> ProductBrands { get; set; }
    }
}
