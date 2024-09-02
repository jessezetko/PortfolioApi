using MediatR;
using PortfolioApi.Infrastructure.Persistence.Repositories.Interfaces;

namespace PortfolioApi.Features.Product.Queries.Get
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, List<PortfolioApi.Domain.Models.Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductHandler(IProductRepository repository) => _repository = repository;

        public async Task<List<PortfolioApi.Domain.Models.Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetProductsAsync();
        }
    }
}
