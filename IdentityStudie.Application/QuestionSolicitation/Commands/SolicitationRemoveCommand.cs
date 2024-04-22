using MediatR;
using Identity.Domain.Entities;

namespace IdentityStudie.Application.QuestionSolicitation.Commands
{
    public class SolicitationRemoveCommand : IRequest<QuestionSolicitation>
    {
        public int Id { get; set; }
        public SolicitationRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
