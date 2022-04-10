using System;
using BusinessLogic.Registers.Model;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class GetRegistryList : IRequest<RegistryList>
    {
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }
    }
}
