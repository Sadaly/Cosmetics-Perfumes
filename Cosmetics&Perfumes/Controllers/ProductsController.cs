using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;
using Cosmetics_Perfumes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_Perfumes.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;

        public ProductsController(IAllProducts allProducts, IProductsCategory productsCategory)
        {
            _allProducts = allProducts;
            _allCategories = productsCategory;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public IActionResult List(string category)
        {
            IEnumerable<Product> products = null;
            string curCategory = "Все товары";

            if (string.IsNullOrEmpty(category))
            {
                products = _allProducts.Products.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("makeup", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Макияж").Id).OrderBy(i => i.Id);
                    curCategory = "Макияж";
                }
                else if (string.Equals("perfumes", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Парфюмерия").Id).OrderBy(i => i.Id);
                    curCategory = "Парфюмерия";
                }
                else if (string.Equals("skin-care", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Уход за кожей").Id).OrderBy(i => i.Id);
                    curCategory = "Уход за кожей";
                }
                else if (string.Equals("hair-care", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Уход за волосами").Id).OrderBy(i => i.Id);
                    curCategory = "Уход за волосами";
                }
                else if (string.Equals("body-care", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Уход за телом").Id).OrderBy(i => i.Id);
                    curCategory = "Уход за телом";
                }
                else if (string.Equals("natural-cosmetics", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Натуральная косметика").Id).OrderBy(i => i.Id);
                    curCategory = "Натуральная косметика";
                }
                else if (string.Equals("men's-cosmetics", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Мужская косметика").Id).OrderBy(i => i.Id);
                    curCategory = "Мужская косметика";
                }
                else if (string.Equals("gift-sets", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(p => p.CategoryID == _allCategories.AllCategories.First(c => c.Name == "Подарочные наборы").Id).OrderBy(i => i.Id);
                    curCategory = "Подарочные наборы";
                }
            }


            var productObj = new ProductsListViewModel
            {
                AllProducts = products ?? _allProducts.Products,
                CurrentCategory = curCategory,
            };

            return View(productObj);
        }
    }
}
