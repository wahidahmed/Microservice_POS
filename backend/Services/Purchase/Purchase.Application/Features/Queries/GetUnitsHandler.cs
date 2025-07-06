using AutoMapper;
using MediatR;
using Purchase.Application.DTOs;
using Purchase.Domain.Interface;

namespace Purchase.Application.Features.Queries
{
    public class GetUnitsHandler(IMapper mapper, IUnitRepository unitRepository) : IRequestHandler<GetUnitsQuery, List<UnitDto>>
    {
        public async Task<List<UnitDto>> Handle(GetUnitsQuery request, CancellationToken cancellationToken)
        {
            var result = await unitRepository.GetAllAsync();
            var data=mapper.Map<List<UnitDto>>(result);
            return data;
        }
    }
}
