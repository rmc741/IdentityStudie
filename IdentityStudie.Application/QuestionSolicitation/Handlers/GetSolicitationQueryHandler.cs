using IdentityStudie.Application.QuestionSolicitation.Queries;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class GetSolicitationQueryHandler : IRequestHandler<GetSolicitationsQuery, IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        private readonly ISolicitationRepository _solicitationRepository;

        public GetSolicitationQueryHandler(ISolicitationRepository solicitationRepository)
        {
            _solicitationRepository = solicitationRepository;
        }

        public async Task<IEnumerable<Domain.Entities.QuestionSolicitation>> Handle(GetSolicitationsQuery request, CancellationToken cancellationToken)
        {
            return await _solicitationRepository.GetSolicitationsAsync();
        }
    }
}
