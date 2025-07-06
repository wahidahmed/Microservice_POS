using System.Net;
using CoreApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Purchase.Application.DTOs;
using Purchase.Application.Features.Commands;
using Purchase.Application.Features.Queries;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Purchase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //public class ProductController : ControllerBase
    public class ProductController : BaseController
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDto>),(int) HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            
            try
            {
                var result = await mediator.Send(new GetProductsQuery());
                if (result.Count == 0)
                {
                    return CustomResult("no data found", HttpStatusCode.NoContent);
                }
                return CustomResult("data loaded", result);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProductAddDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddProduct(AddNewProductCommand  addNew)
        {
            try
            {
                var data = await mediator.Send(addNew);
                if (data == null)
                {
                    return CustomResult("There is no data", HttpStatusCode.NoContent);
                }
                return CustomResult("data saved successfully", data);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProductAddDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            try
            {
                var data = await mediator.Send(command);
                if (data == null)
                {
                    return CustomResult("There is no data", HttpStatusCode.NoContent);
                }
                return CustomResult("data update successfully", data);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }
    }
}
