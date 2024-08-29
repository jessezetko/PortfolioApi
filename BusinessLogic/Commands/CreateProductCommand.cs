using BusinessLogic.Model;
using MediatR;

namespace BusinessLogic.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public Product Product { get; set; }
    }
}
