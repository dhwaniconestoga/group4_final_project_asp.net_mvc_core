using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Group4_FinalProject.Models;

namespace Group4_FinalProject.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    //[Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private Repository<Category> data { get; set; }
        public CategoryController(ElectronicsStoreContext ctx) => data = new Repository<Category>(ctx);

        public ViewResult Index()
        {
            var search = new SearchData(TempData);
            search.Clear();

            var genres = data.List(new QueryOptions<Category>
            {
                OrderBy = g => g.Name
            });
            return View(genres);
        }

        [HttpGet]
        public ViewResult Add() => View("Category", new Category());

        [HttpPost]
        public IActionResult Add(Category category)
        {
            var validate = new Validate(TempData);
            if (!validate.IsCategoryChecked)
            {
                validate.CheckCategory(category.CategoryId, data);
                if (!validate.IsValid)
                {
                    ModelState.AddModelError(nameof(category.CategoryId), validate.ErrorMessage);
                }
            }

            if (ModelState.IsValid)
            {
                data.Insert(category);
                data.Save();
                validate.ClearCategory();
                TempData["message"] = $"{category.Name} added to Genres.";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Category", category);
            }
        }

        [HttpGet]
        public ViewResult Edit(string id) => View("Category", data.Get(id));

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                data.Update(category);
                data.Save();
                TempData["message"] = $"{category.Name} updated.";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Category", category);
            }
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            var category = data.Get(new QueryOptions<Category>
            {
                Include = "Products",
                Where = g => g.CategoryId == id
            });

            if (category.Products.Count > 0)
            {
                TempData["message"] = $"Can't delete category {category.Name} "
                                    + "because it's associated with these products.";
                return GoToProductSearchResults(id);
            }
            else
            {
                return View("Category", category);
            }
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            data.Delete(category);
            data.Save();
            TempData["message"] = $"{category.Name} removed from categories.";
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ViewProducts(string id) => GoToProductSearchResults(id);

        private RedirectToActionResult GoToProductSearchResults(string id)
        {
            var search = new SearchData(TempData)
            {
                SearchTerm = id,
                Type = "category"
            };
            return RedirectToAction("Search", "Product");
        }
    }
}