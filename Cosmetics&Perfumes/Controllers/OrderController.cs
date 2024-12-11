using Cosmetics_Perfumes.Data;
using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_Perfumes.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.ListShopItems = new List<ShopCartItem>(); ;
            return View();
        }
    }
}
