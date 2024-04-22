using AutoMapper;
using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Domain.Entities.QuestionSolicitation, QuestionSolicitationDTO>().ReverseMap();
        }
    }
}
