using AutoMapper;
using PrimeiraWebAPI.Domain.DTOs;
using PrimeiraWebAPI.Domain.Models.EmployeeAggregate;

namespace PrimeiraWebAPI.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}
