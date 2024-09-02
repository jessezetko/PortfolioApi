using PortfolioApi.Domain.Models;

namespace PortfolioApi.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public async Task<int> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteProductAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
