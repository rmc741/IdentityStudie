using IdentityStudie.Application.AnswerSolicitation.Commands;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Handlers
{
    public class AnswerSolicitationUpdateCommandHandler : IRequestHandler<AnswerSolicitationUpdateCommand, Domain.Entities.QuestionSolicitation>
    {
        private readonly IAnswerSolicitationRepository _answerSolicitationRepository;

        public AnswerSolicitationUpdateCommandHandler(IAnswerSolicitationRepository answerSolicitationRepository)
        {
            _answerSolicitationRepository = answerSolicitationRepository;
        }

        public async Task<Domain.Entities.QuestionSolicitation> Handle(AnswerSolicitationUpdateCommand request, CancellationToken cancellationToken)
        {
            var solicitation = await _answerSolicitationRepository.GetSolicitationById(request.Id);

            if (solicitation == null)
            {
                throw new Exception($"Entity could not be found");
            }
            else
            {
                solicitation.UpdateAnswer(request.Status);
                return await _answerSolicitationRepository.UpdateAsync(solicitation);
            }
        }
    }
}
