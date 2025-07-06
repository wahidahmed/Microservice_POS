using AutoMapper;
using MediatR;
using Purchase.Domain.Interface;
using Unit = Purchase.Domain.Entities.Unit;

namespace Purchase.Application.Features.Commands
{
    public class AddNewUnitHandler(IMapper mapper, IUnitRepository unitRepository,IUnitOfWork unitOfWork) : IRequestHandler<AddNewUnitCommand, AddNewUnitCommand>
    {
        public async Task<AddNewUnitCommand> Handle(AddNewUnitCommand request, CancellationToken cancellationToken)
        {
            var unit = mapper.Map<Unit>(request);
            var result=await unitRepository.AddAsync(unit);
            await  unitOfWork.CommitAsync();
            return mapper.Map<AddNewUnitCommand>(result);
        }
    }
}
