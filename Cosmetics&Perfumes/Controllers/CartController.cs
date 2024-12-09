using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_Perfumes.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
