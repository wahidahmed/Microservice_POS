using MediatR;
using Purchase.Application.DTOs;

namespace Purchase.Application.Features.Queries
{
    public class GetUnitsQuery:IRequest<List<UnitDto>>
    {
    }
}
