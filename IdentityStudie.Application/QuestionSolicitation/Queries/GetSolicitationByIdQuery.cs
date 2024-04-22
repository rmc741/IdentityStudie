using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Queries
{
    public class GetSolicitationByIdQuery : IRequest<QuestionSolicitation>
    {
        public int Id { get; set; }
        public GetSolicitationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
