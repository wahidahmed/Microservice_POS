using MediatR;
using Purchase.Application.DTOs;

namespace Purchase.Application.Features.Commands
{
    public class AddNewProductCommand:IRequest<ProductAddDto>
    {
        public ProductAddDto _productAddDto { get; }
        public AddNewProductCommand(ProductAddDto productAddDto)
        {
            _productAddDto = productAddDto;
        }

       
    }
}
