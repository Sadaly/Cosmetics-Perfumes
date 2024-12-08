using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Models;

namespace Cosmetics_Perfumes.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
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
            }
        }
    }
}
