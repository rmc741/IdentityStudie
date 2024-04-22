using AutoMapper;
using Identity.Domain.Entities;
using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<QuestionSolicitation, QuestionSolicitationDTO>.ReverseMap();
        }
    }
}
