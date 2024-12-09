using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> AllCategories => _context.Category;
    }
}
