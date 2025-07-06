using AutoMapper;
using MediatR;
using Purchase.Application.DTOs;
using Purchase.Domain.Common;
using Purchase.Domain.Entities;
using Purchase.Domain.Interface;

namespace Purchase.Application.Features.Commands
{
    public class AddNewProductHandler(IMapper mapper,IProductRepository productRepository,IUnitOfWork unitOfWork) : IRequestHandler<AddNewProductCommand, ProductAddDto>
    {
        public async Task<ProductAddDto> Handle(AddNewProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var product = mapper.Map<Product>(request);
                var result = await productRepository.AddAsync(product);
                await unitOfWork.CommitAsync();
                return mapper.Map<ProductAddDto>(result);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
          
        }
    }
}
