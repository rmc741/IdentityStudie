using AutoMapper;
using IdentityStudie.Application.AnswerSolicitation.Commands;
using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.QuestionSolicitation.Commands;

namespace IdentityStudie.Application.Mappings
{
    public class DtoToCommandMappingProfile : Profile
    {
        public DtoToCommandMappingProfile()
        {
            CreateMap<QuestionSolicitationDTO, SolicitationCreateCommand>();
            CreateMap<QuestionSolicitationDTO, SolicitationUpdateCommand>();

            CreateMap<AnswerSolicitationDTO, AnswerSolicitationUpdateCommand>();
        }
    }
}
