using Group4_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Group4_FinalProject.Controllers
{
    public class CheckoutController : Controller
    {
        private ElectronicsStoreUnitOfWork data { get; set; }
        public CheckoutController(ElectronicsStoreContext ctx) => data = new ElectronicsStoreUnitOfWork(ctx);

        public IActionResult Index()
        {
            return View();
        }

        private Cart GetCart()
        {
            var cart = new Cart(HttpContext);
            cart.Load(data.Products);
            return cart;
        }

        public ViewResult PlaceOrder(Order or)
        {
            var cart = GetCart();
            var builder = new ProductsGridBuilder(HttpContext.Session);

            var vm = new CartViewModel
            {
                List = cart.List,
                Subtotal = cart.Subtotal,
                ProductGridRoute = builder.CurrentRoute
            };

            string name = "";
            foreach (CartItem item in vm.List)
            {
                name += item.Product.Title + ",";
            }

            or.ProductName = name;
            or.Subtotal = Convert.ToInt32(vm.Subtotal);

            data.Order.Insert(or);
            data.Save();

            Cart cartempty = GetCart();
            cartempty.Clear();
            cartempty.Save();

            return View("Thankyou");
        }
    }
}
