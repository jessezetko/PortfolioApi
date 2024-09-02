using MediatR;

namespace PortfolioApi.Features.Product.Queries.Get
{
    public class GetProductQuery : IRequest<List<PortfolioApi.Domain.Models.Product>>
    {
    }
}
