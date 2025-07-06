using MediatR;
using Purchase.Application.DTOs;

namespace Purchase.Application.Features.Queries
{
    public class GetProductsQuery:IRequest<List<ProductDto>>
    {
    }
}
