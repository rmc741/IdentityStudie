using IdentityStudie.Application.QuestionSolicitation.Queries;
using IdentityStudie.Domain.Entities;
using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class GetSolicitationQueryHandler : IRequestHandler<GetSolicitationsQuery, IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        //private readonly ISolicitationRepository _solicitationRepository;

        public GetSolicitationQueryHandler()
        {
        }

        public Task<IEnumerable<Domain.Entities.QuestionSolicitation>> Handle(GetSolicitationsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
