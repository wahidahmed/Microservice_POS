using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Purchase.Application.DTOs;

namespace Purchase.Application.Validators
{
    public class AddNewProdcutValidator:AbstractValidator<ProductAddDto>
    {
        public AddNewProdcutValidator()
        {
            RuleFor(x=>x.ProdcutName).NotEmpty().NotNull().WithMessage("Product name cannot empty");
            RuleFor(x => x.SalesUnitPrice).GreaterThan(0).NotEmpty().NotNull().WithMessage("Sale price must be greater than 0");
        }
    }
}
