using Candy_SUT21.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Candy_SUT21.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryMenu(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepo.GetAllCategory.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
