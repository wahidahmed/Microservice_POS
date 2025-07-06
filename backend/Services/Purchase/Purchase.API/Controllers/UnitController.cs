using System.Net;
using CoreApiResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Purchase.Application.DTOs;
using Purchase.Application.Features.Commands;
using Purchase.Application.Features.Queries;

namespace Purchase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : BaseController
    {
        private readonly IMediator mediator;

        public UnitController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(UnitDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await mediator.Send(new GetUnitsQuery());
                if (result.Count == 0)
                {
                    return CustomResult("no data found", HttpStatusCode.NotFound);
                }
                return CustomResult("data loaded",result);
            }
            catch (Exception ex)
            {

                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddNewUnitCommand), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddNew(AddNewUnitCommand command)
        {
            try
            {
                var data = await mediator.Send(command);
                return CustomResult("saved successfully", data);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

    }
}
