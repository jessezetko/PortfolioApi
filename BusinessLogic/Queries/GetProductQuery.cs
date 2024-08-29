using BusinessLogic.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Queries
{
    public class GetProductQuery : IRequest<List<Product>>
    {
    }
}
