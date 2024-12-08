using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
