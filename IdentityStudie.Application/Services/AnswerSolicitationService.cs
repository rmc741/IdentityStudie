using AutoMapper;
using IdentityStudie.Application.AnswerSolicitation.Queries;
using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
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

        public async Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationsByCategoryId(int categoryId)
        {
            var solicitationsByCategoryIdQuery = new GetSolicitationByCategoryIdQuery(categoryId);

            if (solicitationsByCategoryIdQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationsByCategoryIdQuery);

            return _mapper.Map<IEnumerable<QuestionSolicitationDTO>>(result);
        }
    }
}
