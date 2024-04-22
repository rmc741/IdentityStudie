using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Commands
{
    public abstract class QuestionSolicitationCommand : IRequest<Domain.Entities.QuestionSolicitation>
    {
        public string Description { get; set; }
        public int TotalQuestionsRequest { get; set; }
        public int CategoryId { get; set; }
    }
}
