using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Queries
{
    public class GetSolicitationByCategoryIdQuery : IRequest<IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        public int Id { get; set; }
        public GetSolicitationByCategoryIdQuery(int id)
        {
            Id = id;
        }
    }
}
