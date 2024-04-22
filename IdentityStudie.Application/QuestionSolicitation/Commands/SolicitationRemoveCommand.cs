using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Commands
{
    public class SolicitationRemoveCommand : IRequest<Domain.Entities.QuestionSolicitation>
    {
        public int Id { get; set; }
        public SolicitationRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
