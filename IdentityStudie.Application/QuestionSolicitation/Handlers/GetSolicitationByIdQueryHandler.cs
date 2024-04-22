using IdentityStudie.Application.QuestionSolicitation.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class GetSolicitationByIdQueryHandler : IRequestHandler<GetSolicitationByIdQuery, Domain.Entities.QuestionSolicitation>
    {
        public Task<Domain.Entities.QuestionSolicitation> Handle(GetSolicitationByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
