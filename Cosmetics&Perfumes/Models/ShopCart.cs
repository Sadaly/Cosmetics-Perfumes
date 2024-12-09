namespace Cosmetics_Perfumes.Models
{
    public class ShopCart
    {
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }
    }
}
