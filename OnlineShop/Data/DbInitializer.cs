using OnlineShop.Models;

namespace OnlineShop.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Футболка",
                    Description = "Классическая хлопковая футболка Puma",
                    Price = 1299,
                    ImageUrl = "/images/t-shirt1.jpg"
                },
                new Product
                {
                    Name = "Джинсы",
                    Description = "Синие джинсы slim fit",
                    Price = 2999,
                    ImageUrl = "/images/jeans1.jpg"
                },
                new Product
                {
                    Name = "Air Jordan 1",
                    Description = "Баскетбольная обувь",
                    Price = 12999,
                    ImageUrl = "/images/shoes_jordan.png"
                },

                new Product
                {
                    Name = "Шорты спортивные",
                    Description = "Спортивные шорты для тренировок",
                    Price = 1590,
                    ImageUrl = "/images/shorts1.png"
                },

                new Product
                {
                    Name = "Куртка зимняя",
                    Description = "Утепленная зимняя куртка с капюшоном",
                    Price = 7990,
                    ImageUrl = "/images/winter_jacket.jpg"
                },

                 new Product
                {
                    Name = "Футболка Marcelo Miracles",
                    Description = "Дизайнерская футболка",
                    Price = 1299,
                    ImageUrl = "/images/t-shirt_MM.jpeg"
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
