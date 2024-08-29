using BusinessLogic.Contexts;
using BusinessLogic.Model;
using BusinessLogic.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly LocalContext _context;

        public ProductRepository(LocalContext context) => _context = context;

        public async Task<int> CreateProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return 0;
        }

        public async Task<int> DeleteProductAsync(int Id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(x => x.Id == Id);

            if (product == null || product.IsActive == false)
            {
                throw new KeyNotFoundException($"There was no active product found matching Id {Id}");
            }
            else
            {
                product.IsActive = false;
                await _context.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.Where(p => p.IsActive == true).ToListAsync();
        }
    }
}
