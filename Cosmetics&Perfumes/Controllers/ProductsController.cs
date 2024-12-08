using Cosmetics_Perfumes.Data.Interfaces;
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

        public ViewResult Index()
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model.AllProducts = _allProducts.Products;
            model.CurrentCategory = "Косметика";
            return View(model);
        }
    }
}
