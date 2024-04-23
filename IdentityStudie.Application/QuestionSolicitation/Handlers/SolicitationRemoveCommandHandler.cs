using IdentityStudie.Application.QuestionSolicitation.Commands;
using IdentityStudie.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers;

public class SolicitationRemoveCommandHandler : IRequestHandler<SolicitationRemoveCommand, Domain.Entities.QuestionSolicitation>
{
    private readonly ISolicitationsRepository _solicitationRepository;

    public SolicitationRemoveCommandHandler(ISolicitationsRepository solicitationRepository)
    {
        _solicitationRepository = solicitationRepository;
    }

    public async Task<Domain.Entities.QuestionSolicitation> Handle(SolicitationRemoveCommand request, CancellationToken cancellationToken)
    {
        var solicitationById = await _solicitationRepository.GetByIdAsync(request.Id);

        if (solicitationById == null)
        {
            throw new ApplicationException($"Entity could not be found.");
        }
        else
        {
            return await _solicitationRepository.RemoveAsync(solicitationById);

        }
    }
}
