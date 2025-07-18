﻿using MediatR;
using Purchase.Application.DTOs;

namespace Purchase.Application.Features.Commands
{
    public class AddNewProductCommand:IRequest<ProductAddDto>
    {
        public long ProductId { get; set; }
        public string ProdcutName { get; set; }
        public string ProductDescription { get; set; }
        public int UnitId { get; set; }
        public decimal SalesUnitPrice { get; set; }


    }
}
