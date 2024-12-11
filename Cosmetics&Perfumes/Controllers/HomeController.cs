using System.Diagnostics;
using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;
using Cosmetics_Perfumes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_Perfumes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRepository;
        public HomeController(IAllProducts productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeProduct = new HomeViewModel{
                favoriteProducts = _productRepository.GetFavProducts,
            };
            return View(homeProduct);
        }
    }
}
