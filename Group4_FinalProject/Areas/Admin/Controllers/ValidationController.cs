using Microsoft.AspNetCore.Mvc;
using Group4_FinalProject.Models;

namespace Group4_FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ValidationController : Controller
    {
        private Repository<Brand> brandData { get; set; }
        private Repository<Category> categoryData { get; set; }

        public ValidationController(ElectronicsStoreContext ctx)
        {
            brandData = new Repository<Brand>(ctx);
            categoryData = new Repository<Category>(ctx);
        }

        public JsonResult CheckCategory(string categoryId)
        {
            var validate = new Validate(TempData);
            validate.CheckCategory(categoryId, categoryData);
            if (validate.IsValid) {
                validate.MarkCategoryChecked();
                return Json(true);
            }
            else {
                return Json(validate.ErrorMessage);
            }
        }

        public JsonResult CheckBrand(string Name,string operation)
        {
            var validate = new Validate(TempData);
            validate.CheckBrand(Name, operation, brandData);
            if (validate.IsValid) {
                validate.MarkBrandChecked();
                return Json(true);
            }
            else {
                return Json(validate.ErrorMessage);
            }
        }
    }
}