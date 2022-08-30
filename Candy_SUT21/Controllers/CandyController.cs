using Candy_SUT21.Models;
using Candy_SUT21.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Candy_SUT21.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepo;
        private readonly ICategoryRepository _categoryRepo;

        public CandyController(ICandyRepository candyRepo, ICategoryRepository categoryRepo)
        {
            _candyRepo = candyRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Candy> candies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                candies = _candyRepo.GetAllCandy.OrderBy(c => c.CandyId);
                currentCategory = "All Candy";
            }
            else
            {
                candies = _candyRepo.GetAllCandy.Where(c => c.Category.CategoryName == category);
                currentCategory = _categoryRepo.GetAllCategory.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CandyListViewModel
            {
                Candies = candies,
                CurrentCategory = currentCategory,
            });
        }

        public IActionResult Details(int Id)
        {
            var candy = _candyRepo.GetCandyById(Id);
            if (candy == null)
            {
                return NotFound();
            }

            return View(candy);
        }


    }
}
