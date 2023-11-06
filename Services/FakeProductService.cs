using CuaHangDienTu.Models;

namespace CuaHangDienTu.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    ProductName = "T-Shirt",
                    Description = "Comfortable cotton t-shirt",
                    Price = 19.99m,
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Jeans",
                    Description = "Stylish denim jeans",
                    Price = 49.99m,
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Sneakers",
                    Description = "Sporty sneakers for daily wear",
                    Price = 39.99m,
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Laptop",
                    Description = "Powerful laptop with high performance",
                    Price = 799.99m,
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Smartphone",
                    Description = "Latest smartphone with great features",
                    Price = 599.99m,
                },
                new Product
                {
                    Id = 6,
                    ProductName = "Watch",
                    Description = "Elegant wristwatch for all occasions",
                    Price = 99.99m,
                },
                new Product
                {
                    Id = 7,
                    ProductName = "Headphones",
                    Description = "High-quality noise-canceling headphones",
                    Price = 129.99m,
                },
                new Product
                {
                    Id = 8,
                    ProductName = "Backpack",
                    Description = "Spacious backpack for travelers",
                    Price = 29.99m,
                },
                new Product
                {
                    Id = 9,
                    ProductName = "Desk Lamp",
                    Description = "Modern LED desk lamp for work or study",
                    Price = 19.99m,
                },
                new Product
                {
                    Id = 10,
                    ProductName = "Coffee Maker",
                    Description = "Automatic coffee maker for your morning brew",
                    Price = 49.99m,
                },
                new Product
                {
                    Id = 11,
                    ProductName = "Running Shoes",
                    Description = "Comfortable running shoes for athletes",
                    Price = 69.99m,
                },
                new Product
                {
                    Id = 12,
                    ProductName = "Gaming Mouse",
                    Description = "High-performance gaming mouse with RGB lighting",
                    Price = 39.99m,
                },
                new Product
                {
                    Id = 13,
                    ProductName = "Keyboard",
                    Description = "Mechanical keyboard for typing enthusiasts",
                    Price = 59.99m,
                },
                new Product
                {
                    Id = 14,
                    ProductName = "Sunglasses",
                    Description = "Stylish sunglasses with UV protection",
                    Price = 24.99m,
                },
                new Product
                {
                    Id = 15,
                    ProductName = "Umbrella",
                    Description = "Compact umbrella for rainy days",
                    Price = 14.99m,
                },
                new Product
                {
                    Id = 16,
                    ProductName = "Toothbrush",
                    Description = "Electric toothbrush for dental care",
                    Price = 34.99m,
                },
                new Product
                {
                    Id = 17,
                    ProductName = "Water Bottle",
                    Description = "Reusable water bottle for hydration",
                    Price = 9.99m,
                },
                new Product
                {
                    Id = 18,
                    ProductName = "Dumbbells",
                    Description = "Set of dumbbells for home workouts",
                    Price = 49.99m,
                },
                new Product
                {
                    Id = 19,
                    ProductName = "Pencil Set",
                    Description = "Artistic pencil set for drawing and sketching",
                    Price = 19.99m,
                },
                new Product
                {
                    Id = 20,
                    ProductName = "Back Support Cushion",
                    Description = "Ergonomic back support cushion for chairs",
                    Price = 29.99m,
                }
            };

            return products;
        }
    }
}
