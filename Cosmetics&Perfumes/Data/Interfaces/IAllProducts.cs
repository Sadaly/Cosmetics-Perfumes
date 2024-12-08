using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> GetFavProducts { get; set; }
        Product GetObjectProduct(int product_id);

    }
}
