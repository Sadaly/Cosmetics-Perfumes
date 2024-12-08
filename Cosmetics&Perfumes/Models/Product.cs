namespace Cosmetics_Perfumes.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public bool IsAvailable { get; set; }
        public ushort Price { get; set; }
        public string Image { get; set; }
        public bool IsFavourite { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
