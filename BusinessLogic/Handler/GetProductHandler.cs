using BusinessLogic.Model;
using BusinessLogic.Queries;
using BusinessLogic.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Handler
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, List<Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductHandler(IProductRepository repository) => _repository = repository;

        public async Task<List<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetProductsAsync();
        }
    }
}
