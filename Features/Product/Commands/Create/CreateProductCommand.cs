using MediatR;

namespace PortfolioApi.Features.Product.Commands.Create
{
    public class CreateProductCommand : IRequest<int>
    {
        public PortfolioApi.Domain.Models.Product Product { get; set; }
    }
}
