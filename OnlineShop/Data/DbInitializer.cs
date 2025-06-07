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
                    Description = "Классическая хлопковая футболка",
                    Price = 1299,
                    ImageUrl = "https://via.placeholder.com/300x200"
                },
                new Product
                {
                    Name = "Джинсы",
                    Description = "Синие джинсы slim fit",
                    Price = 2999,
                    ImageUrl = "https://via.placeholder.com/300x200"
                },
                new Product
                {
                    Name = "Кроссовки",
                    Description = "Удобные повседневные кроссовки",
                    Price = 4999,
                    ImageUrl = "https://via.placeholder.com/300x200"
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
