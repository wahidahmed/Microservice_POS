using AutoMapper;
using MediatR;
using Purchase.Application.DTOs;
using Purchase.Domain.Entities;
using Purchase.Domain.Interface;

namespace Purchase.Application.Features.Commands
{
    public class AddNewProductHandler(IMapper mapper,IProductRepository productRepository) : IRequestHandler<AddNewProductCommand, ProductAddDto>
    {
        public async Task<ProductAddDto> Handle(AddNewProductCommand request, CancellationToken cancellationToken)
        {
            var prodcut=mapper.Map<Product>(request._productAddDto);
            var result= await productRepository.AddAsync(prodcut);
            return mapper.Map<ProductAddDto>(result);
        }
    }
}
