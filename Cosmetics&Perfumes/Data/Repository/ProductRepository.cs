using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;
using System.Data.Entity;

namespace Cosmetics_Perfumes.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products => _context.Product.Include(p => p.Category);

        public IEnumerable<Product> GetFavProducts => _context.Product.Where(p => p.IsFavourite).Include(p => p.Category);

        //Получение объекта по айди
        public Product GetObjectProduct(int product_id)
        {
            return _context.Product.FirstOrDefault(p => p.Id == product_id);
        }
    }
}
