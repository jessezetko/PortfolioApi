using BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories.Interfaces
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
