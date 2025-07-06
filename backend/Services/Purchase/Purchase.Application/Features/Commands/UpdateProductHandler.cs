using AutoMapper;
using MediatR;
using Purchase.Application.DTOs;
using Purchase.Domain.Entities;
using Purchase.Domain.Interface;

namespace Purchase.Application.Features.Commands
{
    public class UpdateProductHandler(IMapper mapper, IProductRepository productRepository,IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductCommand, ProductAddDto>
    {
        public async Task<ProductAddDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var entity=mapper.Map<Product>(request);
            var result=productRepository.Update(entity);
            await unitOfWork.CommitAsync();
            //return Task.FromResult(mapper.Map<ProductAddDto>(result));
            return mapper.Map<ProductAddDto>(result);
        }
    }
}
