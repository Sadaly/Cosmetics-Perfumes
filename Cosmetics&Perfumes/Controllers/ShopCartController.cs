using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Data.Repository;
using Cosmetics_Perfumes.Models;
using Cosmetics_Perfumes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_Perfumes.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllProducts _productRepository;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllProducts productRepository, ShopCart shopCart)
        {
            _productRepository = productRepository;
            _shopCart = shopCart;
        }
        public IActionResult Index()
        {
            var items = _shopCart.GetShopCartItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart,
            };

            return View(obj);
        }

        public IActionResult AddToCart(int id)
        {
            var item = _productRepository.Products.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            string refererUrl = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(refererUrl))
            {
                return Redirect(refererUrl);
            }

            return RedirectToAction("Index");
        }
    }
}
