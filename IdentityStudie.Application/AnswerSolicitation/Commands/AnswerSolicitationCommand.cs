using IdentityStudie.Domain.Enums;
using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Commands
{
    public abstract class AnswerSolicitationCommand : IRequest<Domain.Entities.QuestionSolicitation>
    {
        public StatusEnum Status { get; set; }
    }
}
