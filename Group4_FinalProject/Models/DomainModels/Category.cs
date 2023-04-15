using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Group4_FinalProject.Models
{
    public class Category
    {
        [MaxLength(10)]
        [Required(ErrorMessage = "Please enter a category id.")]
        [Remote("CheckCategory", "Validation", "Admin")]
        public string CategoryId { get; set; }
        
        [StringLength(25)]
        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}