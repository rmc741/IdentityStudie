using AutoMapper;
using IdentityStudie.Application.AnswerSolicitation.Commands;
using IdentityStudie.Application.AnswerSolicitation.Queries;
using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
using IdentityStudie.Application.QuestionSolicitation.Queries;
using IdentityStudie.Domain.Entities;
using MediatR;

namespace IdentityStudie.Application.Services
{
    public class AnswerSolicitationService : IAnswerSolicitationService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AnswerSolicitationService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<QuestionSolicitationDTO> GetSolicitationById(int solicitationId)
        {
            var solicitationByIdQuery = new GetSolicitationByIdQuery(solicitationId);
            if (solicitationByIdQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationByIdQuery);

            return _mapper.Map<QuestionSolicitationDTO>(result);
        }

        public async Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationByProfessorId(int professorId)
        {
            var solicitationsByProfessorIdQuery = new GetSolicitationByProfessorIdQuery(professorId);

            if (solicitationsByProfessorIdQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationsByProfessorIdQuery);

            return _mapper.Map<IEnumerable<QuestionSolicitationDTO>>(result);
        }

        public async Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationsByCategoryId(int categoryId)
        {
            var solicitationsByCategoryIdQuery = new GetSolicitationByCategoryIdQuery(categoryId);

            if (solicitationsByCategoryIdQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationsByCategoryIdQuery);

            return _mapper.Map<IEnumerable<QuestionSolicitationDTO>>(result);
        }

        public async Task Update(AnswerSolicitationDTO questionSolicictationDto)
        {
            var solicitationUpdate = _mapper.Map<AnswerSolicitationUpdateCommand>(questionSolicictationDto);
            await _mediator.Send(solicitationUpdate);
        }
    }
}
