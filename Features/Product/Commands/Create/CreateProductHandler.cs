using MediatR;
using PortfolioApi.Infrastructure.Persistence.Repositories.Interfaces;

namespace PortfolioApi.Features.Product.Commands.Create
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return await _repository.CreateProductAsync(request.Product);
        }
    }
}
