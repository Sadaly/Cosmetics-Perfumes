using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
