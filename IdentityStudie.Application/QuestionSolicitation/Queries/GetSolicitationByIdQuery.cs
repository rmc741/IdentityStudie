using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Queries
{
    public class GetSolicitationByIdQuery : IRequest<Domain.Entities.QuestionSolicitation>
    {
        public int Id { get; set; }
        public GetSolicitationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
