using BusinessLogic.Registers.Model;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class GetRegistryList : IRequest<RegistryList>
    {
    }
}
