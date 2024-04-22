using AutoMapper;
using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
using IdentityStudie.Application.QuestionSolicitation.Commands;
using IdentityStudie.Application.QuestionSolicitation.Queries;
using MediatR;

namespace IdentityStudie.Application.Services
{
    public class QuestionSolicitationService : IQuestionSolicitationService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public QuestionSolicitationService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitations()
        {
            var solicitationsQuery = new GetSolicitationsQuery();

            if (solicitationsQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationsQuery);

            return _mapper.Map<IEnumerable<QuestionSolicitationDTO>>(result);
        }

        public async Task<QuestionSolicitationDTO> GetById(int id)
        {
            var solicitationByIdQuery = new GetSolicitationByIdQuery(id);

            if (solicitationByIdQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(solicitationByIdQuery);

            return _mapper.Map<QuestionSolicitationDTO>(result);
        }

        public async Task Add(QuestionSolicitationDTO questionSolicictationDto)
        {
            var solicitationsCreateCommand = _mapper.Map<SolicitationCreateCommand>(questionSolicictationDto);
            await _mediator.Send(solicitationsCreateCommand);
        }

        public async Task Update(QuestionSolicitationDTO questionSolicictationDto)
        {
            var solicitationsUpdateCommand = _mapper.Map<SolicitationUpdateCommand>(questionSolicictationDto);
            await _mediator.Send(solicitationsUpdateCommand);
        }

        public async Task Remove(int id)
        {
            var solicitationRemoveCommand = new SolicitationRemoveCommand(id);
            if (solicitationRemoveCommand == null)
                throw new Exception($"Entity could not be loaded.");

            await _mediator.Send(solicitationRemoveCommand);
        }


        /*
           public async Task Remove(int? id)
           {
               var productRemoveCommand = new ProductRemoveCommand(id.Value);
               if (productRemoveCommand == null)
                   throw new Exception($"Entity could not be loaded.");

               await _mediator.Send(productRemoveCommand);
           }
         * 
         */
    }
}
