using AutoMapper;
using BusinessLogic.Registers.Entities;
using BusinessLogic.Registers.Model;


namespace BusinessLogic.Registers
{
    public class RegistersProfile : Profile
    {
        public RegistersProfile()
        {
            CreateMap<Registry, RegistryDetails>();
        }
    }
}
