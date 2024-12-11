using Microsoft.EntityFrameworkCore;
using Cosmetics_Perfumes.Data;

namespace Cosmetics_Perfumes.Models
{
    public class ShopCart
    {
        private readonly AppDbContext appDbContext;

        public ShopCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public string ShopCartId { get; set; }
        
        public List<ShopCartItem> ListShopItems { get; set; }
        
        //Создание новой корзины
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            //Проверяем есть ли в корзине товары путем поиска корзины по айди
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            //Выбираем или создаем корзину
            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {
                ShopCartId = shopCartId,
            };
        }

        public void AddToCart(Product product)
        {
            appDbContext.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Product = product,
                Price = product.Price,
            });

            appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return appDbContext.ShopCartItem.Where(s => s.ShopCartId == ShopCartId).Include(s => s.Product).ToList();
        }
    }
}
