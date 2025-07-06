using MediatR;

namespace Purchase.Application.Features.Commands
{
    public class AddNewUnitCommand:IRequest<AddNewUnitCommand>
    {
        public string UnitName { get; set; }
    }
}
