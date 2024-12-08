using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProduct = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    // Парфюмерия
                    new Product {
                        Name = "Chanel No.5",
                        ShortDescription = "Классический аромат",
                        LongDescription = "Легендарный аромат для женщин от Chanel, подходящий для любого случая.",
                        Image = "img/chanel_no5.jpg",
                        Price = 8500,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Парфюмерия")
                    },
                    new Product {
                        Name = "Dior Sauvage",
                        ShortDescription = "Элегантный мужской парфюм",
                        LongDescription = "Свежий и мужественный аромат для современных мужчин.",
                        Image = "img/dior_sauvage.jpg",
                        Price = 7200,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Парфюмерия")
                    },

                    // Макияж
                    new Product {
                        Name = "Тушь для ресниц Maybelline",
                        ShortDescription = "Объем и удлинение",
                        LongDescription = "Популярная тушь для ресниц, придающая объем и длину.",
                        Image = "img/maybelline_mascara.jpg",
                        Price = 500,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Макияж")
                    },
                    new Product {
                        Name = "Матовая помада NYX",
                        ShortDescription = "Долговечная матовая текстура",
                        LongDescription = "Помада с бархатистой текстурой и насыщенным цветом.",
                        Image = "img/nyx_lipstick.jpg",
                        Price = 600,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Макияж")
                    },

                    // Уход за кожей
                    new Product {
                        Name = "Крем для лица Nivea",
                        ShortDescription = "Увлажняющий крем",
                        LongDescription = "Подходит для ежедневного использования, увлажняет и питает кожу.",
                        Image = "img/nivea_cream.jpg",
                        Price = 300,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Уход за кожей")
                    },
                    new Product {
                        Name = "Сыворотка с витамином C",
                        ShortDescription = "Антиоксидантный уход",
                        LongDescription = "Сыворотка для лица с витамином C, придающая коже сияние.",
                        Image = "img/vitamin_c_serum.jpg",
                        Price = 1500,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Уход за кожей")
                    },

                    // Уход за волосами
                    new Product {
                        Name = "Шампунь Head & Shoulders",
                        ShortDescription = "Против перхоти",
                        LongDescription = "Эффективное средство для борьбы с перхотью.",
                        Image = "img/head_shoulders_shampoo.jpg",
                        Price = 400,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Уход за волосами")
                    },
                    new Product {
                        Name = "Бальзам для волос Pantene",
                        ShortDescription = "Питание и восстановление",
                        LongDescription = "Бальзам для укрепления и восстановления структуры волос.",
                        Image = "img/pantene_conditioner.jpg",
                        Price = 450,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Уход за волосами")
                    },

                    // Подарочные наборы
                    new Product {
                        Name = "Подарочный набор Rituals",
                        ShortDescription = "Ароматный уход за телом",
                        LongDescription = "Набор из геля для душа, крема и ароматизированной свечи.",
                        Image = "img/rituals_gift_set.jpg",
                        Price = 3000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryProduct.AllCategories.First(category => category.Name == "Подарочные наборы")
                    }
                };
            }
        }

        public IEnumerable<Product> GetFavProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Product IAllProducts.GetObjectProduct(int product_id)
        {
            throw new NotImplementedException();
        }
    }
}
