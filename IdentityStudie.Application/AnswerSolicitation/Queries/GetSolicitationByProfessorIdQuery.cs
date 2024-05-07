using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Queries
{
    public class GetSolicitationByProfessorIdQuery : IRequest<IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        public int ProfessorId { get; set; }
        public GetSolicitationByProfessorIdQuery(int id)
        {
            ProfessorId = id;
        }
    }
}
