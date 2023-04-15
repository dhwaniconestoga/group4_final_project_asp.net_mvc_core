using System.Collections.Generic;

namespace Group4_FinalProject.Models
{
    public class CartViewModel 
    {
        public IEnumerable<CartItem> List { get; set; }
        public double Subtotal { get; set; }
        public RouteDictionary ProductGridRoute { get; set; }
    }
}
