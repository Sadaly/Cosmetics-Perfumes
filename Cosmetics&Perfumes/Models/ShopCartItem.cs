namespace Cosmetics_Perfumes.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string ShopCartId { get; set; }
        public ushort Price {  get; set; }

    }
}
