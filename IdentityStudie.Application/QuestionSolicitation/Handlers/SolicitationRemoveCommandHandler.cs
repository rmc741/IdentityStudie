using IdentityStudie.Application.QuestionSolicitation.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class SolicitationRemoveCommandHandler : IRequestHandler<SolicitationRemoveCommand, Domain.Entities.QuestionSolicitation>
    {
        public Task<Domain.Entities.QuestionSolicitation> Handle(SolicitationRemoveCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
