using Microsoft.EntityFrameworkCore;
using PortfolioApi.Domain.Models;

namespace PortfolioApi.Infrastructure.Persistence
{
    public class LocalContext : DbContext
    {
        public LocalContext(DbContextOptions<LocalContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public static void Seed(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<LocalContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Product 1",
                        Description = "Description for Product 1",
                        Price = 10.99,
                        IsActive = true
                    },
                    new Product
                    {
                        Name = "Product 2",
                        Description = "Description for Product 2",
                        Price = 19.99,
                        IsActive = true
                    },
                    new Product
                    {
                        Name = "Product 3",
                        Description = "Description for Product 3",
                        Price = 29.99,
                        IsActive = false
                    }
                );
                context.SaveChanges();
            }
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
