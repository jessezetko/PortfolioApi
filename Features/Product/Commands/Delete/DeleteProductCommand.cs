using MediatR;

namespace PortfolioApi.Features.Product.Commands.Delete
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
