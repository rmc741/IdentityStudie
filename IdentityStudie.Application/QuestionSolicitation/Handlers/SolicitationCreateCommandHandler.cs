using IdentityStudie.Application.QuestionSolicitation.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class SolicitationCreateCommandHandler : IRequestHandler<SolicitationCreateCommand, Domain.Entities.QuestionSolicitation>
    {
        public Task<Domain.Entities.QuestionSolicitation> Handle(SolicitationCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
