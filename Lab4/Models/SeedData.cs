using Lab4.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lab4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab4Context(serviceProvider.GetRequiredService<DbContextOptions<Lab4Context>>()))
            {
                // Check if categories already exist
                if (context.Category.Any())
                {
                    return; // DB has been seeded
                }

                // Add categories
                var categories = new List<Categories>
        {
            new Categories { Description = "Beverages" },
            new Categories { Description = "Condiments" },
            new Categories { Description = "Confections" }
        };

                context.Category.AddRange(categories);
                context.SaveChanges();

                // Now that categories are added, you can add products
                var products = new List<Products>
        {
            new Products
            {
                Description = "Chai",
                UnitPrice = 18.00f,
                DateFirstIssued = DateTime.Parse("2000-12-12"),
                QuantityInStock = 39,
                CategoryID = categories[0].ID // Use the actual ID from the inserted categories
            },
            new Products
            {
                Description = "Chang",
                UnitPrice = 19.00f,
                DateFirstIssued = DateTime.Parse("2000-12-12"),
                QuantityInStock = 17,
                CategoryID = categories[0].ID // Use the actual ID from the inserted categories
            }
            // Add more products as needed
        };

                context.Product.AddRange(products);
                context.SaveChanges();
            }
        }
    }


}
