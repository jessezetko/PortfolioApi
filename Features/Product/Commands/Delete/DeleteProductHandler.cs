using MediatR;
using PortfolioApi.Infrastructure.Persistence.Repositories.Interfaces;

namespace PortfolioApi.Features.Product.Commands.Delete
{
    internal class DeleteProductHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public DeleteProductHandler(IProductRepository repository) => _repository = repository;

        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteProductAsync(request.Id);
        }
    }
}
