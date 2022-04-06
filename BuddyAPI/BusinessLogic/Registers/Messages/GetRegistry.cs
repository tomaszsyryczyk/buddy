using BusinessLogic.Registers.Model;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public  class GetRegistry : IRequest<RegistryDetails>
    {
        public int Id { get; set; }
    }
}
