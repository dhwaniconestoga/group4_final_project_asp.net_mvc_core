using System.Collections.Generic;

namespace Group4_FinalProject.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Dictionary<int, string> Brands { get; set; }

        public void Load(Product product)
        {
            ProductId = product.ProductId;
            Title = product.Title;
            Price = product.Price;
            Description = product.Description;
            Brands = new Dictionary<int, string>();
            foreach (ProductBrand ba in product.ProductBrands) {
                Brands.Add(ba.Brand.BrandId, ba.Brand.FullName);
            }
        }
    }

}
