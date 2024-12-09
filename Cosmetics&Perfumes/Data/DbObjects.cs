using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data
{
    public class DbObjects
    {
        //Выбираем все категории из БД
        public static void Initial(AppDbContext context)
        {
            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Product.Any())
            {
                context.Product.AddRange(Products.Select(c => c.Value));
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                //Если мы получаем пустой список, то мы самостоятельно добавляем значения
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Парфюмерия", Description = "Ароматы для женщин, мужчин и унисекс" },
                        new Category { Name = "Макияж", Description = "Средства для макияжа глаз, губ и лица" },
                        new Category { Name = "Уход за кожей", Description = "Крема, сыворотки и маски для ухода за кожей" },
                        new Category { Name = "Уход за волосами", Description = "Шампуни, бальзамы и средства для стайлинга" },
                        new Category { Name = "Уход за телом", Description = "Лосьоны, скрабы и масла для тела" },
                        new Category { Name = "Натуральная косметика", Description = "Косметика с натуральными ингредиентами" },
                        new Category { Name = "Мужская косметика", Description = "Средства для ухода за кожей и волосами для мужчин" },
                        new Category { Name = "Подарочные наборы", Description = "Наборы косметики и парфюмерии для подарка" }
                    };
                    category = new Dictionary<string, Category>();

                    foreach (var item in list)
                    {
                        category.Add(item.Name, item);
                    }
                }


                return category;
            }
        }

        private static Dictionary<string, Product> product;
        public static Dictionary<string, Product> Products
        {
            get
            {
                //Если мы получаем пустой список, то мы самостоятельно добавляем значения
                if (product == null)
                {
                    var list = new Product[]
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
                        Category = Categories["Парфюмерия"]
                    },
                    new Product {
                        Name = "Dior Sauvage",
                        ShortDescription = "Элегантный мужской парфюм",
                        LongDescription = "Свежий и мужественный аромат для современных мужчин.",
                        Image = "img/dior_sauvage.jpg",
                        Price = 7200,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Парфюмерия"]
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
                        Category = Categories["Макияж"]
                    },
                    new Product {
                        Name = "Матовая помада NYX",
                        ShortDescription = "Долговечная матовая текстура",
                        LongDescription = "Помада с бархатистой текстурой и насыщенным цветом.",
                        Image = "img/nyx_lipstick.jpg",
                        Price = 600,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = Categories["Макияж"]
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
                        Category = Categories["Уход за кожей"]
                    },
                    new Product {
                        Name = "Сыворотка с витамином C",
                        ShortDescription = "Антиоксидантный уход",
                        LongDescription = "Сыворотка для лица с витамином C, придающая коже сияние.",
                        Image = "img/vitamin_c_serum.jpg",
                        Price = 1500,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Уход за кожей"]
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
                        Category = Categories["Уход за волосами"]
                    },
                    new Product {
                        Name = "Бальзам для волос Pantene",
                        ShortDescription = "Питание и восстановление",
                        LongDescription = "Бальзам для укрепления и восстановления структуры волос.",
                        Image = "img/pantene_conditioner.jpg",
                        Price = 450,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Уход за волосами"]
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
                        Category = Categories["Подарочные наборы"]
                    }
                };
                    product = new Dictionary<string, Product>();

                    foreach (var item in list)
                    {
                        product.Add(item.Name, item);
                    }
                }


                return product;
            }
        }
    }
}
