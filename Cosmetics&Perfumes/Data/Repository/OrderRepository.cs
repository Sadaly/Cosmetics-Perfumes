using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopCart shopCart;

        public OrderRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this.shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);

            var items = shopCart.ListShopItems;

            foreach (var item in items)
            {
                OrderDetail orderDetail = new()
                {
                    ProductId = item.Product.Id,
                    OrderId = order.Id,
                    Price = item.Product.Price,
                };

                appDbContext.OrderDetail.Add(orderDetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
