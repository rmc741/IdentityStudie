using IdentityStudie.Application.QuestionSolicitation.Commands;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers;

public class SolicitationCreateCommandHandler : IRequestHandler<SolicitationCreateCommand, Domain.Entities.QuestionSolicitation>
{
    private readonly ISolicitationRepository _solicitationRepository;

    public SolicitationCreateCommandHandler(ISolicitationRepository solicitationRepository)
    {
        _solicitationRepository = solicitationRepository;
    }

    public async Task<Domain.Entities.QuestionSolicitation> Handle(SolicitationCreateCommand request, CancellationToken cancellationToken)
    {
        var solicitation = new Domain.Entities.QuestionSolicitation(request.Description,
            request.TotalQuestionsRequest, request.CategoryId, request.ProfessorId, request.Status);

        if (solicitation == null)
        {
            throw new ApplicationException($"Error creating entity");
        }
        else
        {
            return await _solicitationRepository.CreateAsync(solicitation);
        }
    }
}
