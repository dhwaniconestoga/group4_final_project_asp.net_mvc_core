using Microsoft.AspNetCore.Mvc;
using Group4_FinalProject.Models;

namespace Group4_FinalProject.Controllers
{
    public class BrandController : Controller
    {
        private Repository<Brand> data { get; set; }
        public BrandController(ElectronicsStoreContext ctx) => data = new Repository<Brand>(ctx);

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List(GridDTO vals)
        {
            string defaultSort = nameof(Brand.Name);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort);
            builder.SaveRouteSegments();

            var options = new QueryOptions<Brand>
            {
                Include = "ProductBrands.Product",
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderByDirection = builder.CurrentRoute.SortDirection
            };
           
            options.OrderBy = a => a.Name;
            

            var vm = new BrandListViewModel
            {
                Brands = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count)
            };

            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var brand = data.Get(new QueryOptions<Brand>
            {
                Include = "ProductBrands.Product",
                Where = a => a.BrandId == id
            });
            return View(brand);
        }
    }
}