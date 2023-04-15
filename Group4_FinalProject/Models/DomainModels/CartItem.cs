using Newtonsoft.Json;

namespace Group4_FinalProject.Models
{
    public class CartItem
    {
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => Product.Price * Quantity;
    }
}
