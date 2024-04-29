using IdentityStudie.Application.QuestionSolicitation.Queries;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class GetSolicitationByIdQueryHandler : IRequestHandler<GetSolicitationByIdQuery, Domain.Entities.QuestionSolicitation>
    {
        private readonly ISolicitationRepository _solicitationRepository;

        public GetSolicitationByIdQueryHandler(ISolicitationRepository solicitationRepository)
        {
            _solicitationRepository = solicitationRepository;
        }

        public async Task<Domain.Entities.QuestionSolicitation> Handle(GetSolicitationByIdQuery request, CancellationToken cancellationToken)
        {
            return await _solicitationRepository.GetByIdAsync(request.Id);
        }
    }
}
