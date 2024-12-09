using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {

        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
