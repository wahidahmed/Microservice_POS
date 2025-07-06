using FluentValidation;
using Purchase.Application.DTOs;
using Purchase.Application.Features.Commands;

namespace Purchase.Application.Validators
{
    public class AddNewProdcutValidator:AbstractValidator<AddNewProductCommand>
    {
        public AddNewProdcutValidator()
        {
            RuleFor(x=>x.ProdcutName).NotEmpty().NotNull().WithMessage("Product name cannot empty");
            RuleFor(x => x.SalesUnitPrice).GreaterThan(0).NotEmpty().NotNull().WithMessage("Sale price must be greater than 0");
        }
    }
}
