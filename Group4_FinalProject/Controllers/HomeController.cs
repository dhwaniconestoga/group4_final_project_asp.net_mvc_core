using System;
using Microsoft.AspNetCore.Mvc;
using Group4_FinalProject.Models;

namespace Group4_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Product> data { get; set; }
        public HomeController(ElectronicsStoreContext ctx) => data = new Repository<Product>(ctx);

        public ViewResult Index()
        {
            var random = data.Get(new QueryOptions<Product> {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }
    }
}