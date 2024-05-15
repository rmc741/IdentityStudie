using IdentityStudie.Application.AnswerSolicitation.Queries;
using IdentityStudie.Domain.Entities;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Handlers
{
    public class GetSolicitationByProfessorIdQueryHandler : IRequestHandler<GetSolicitationByProfessorIdQuery, IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        private readonly IAnswerSolicitationRepository _answerSolicitationRepository;
        public GetSolicitationByProfessorIdQueryHandler(IAnswerSolicitationRepository answerSolicitationRepository)
        {
            _answerSolicitationRepository = answerSolicitationRepository;
        }
        public async Task<IEnumerable<Domain.Entities.QuestionSolicitation>> Handle(GetSolicitationByProfessorIdQuery request, CancellationToken cancellationToken)
        {
            return await _answerSolicitationRepository.GetSolicitationsByProfessorIdAsync(request.ProfessorId);
        }
    }
}
