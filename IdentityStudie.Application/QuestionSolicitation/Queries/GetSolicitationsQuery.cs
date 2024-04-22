using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Queries
{
    public class GetSolicitationsQuery : IRequest<IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
    }
}
