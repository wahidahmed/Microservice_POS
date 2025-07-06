using AutoMapper;
using MediatR;
using Purchase.Application.DTOs;
using Purchase.Domain.Interface;

namespace Purchase.Application.Features.Queries
{
    public class GetProductsHandler(IMapper mapper,IProductRepository productRepository) : IRequestHandler<GetProductsQuery, List<ProductDto>>
    {
        public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await productRepository.GetAllAsync();
            return mapper.Map<List<ProductDto>>(result);
        }
    }
}
