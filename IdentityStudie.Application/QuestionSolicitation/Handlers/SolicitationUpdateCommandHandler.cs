﻿using IdentityStudie.Application.Interfaces;
using IdentityStudie.Application.QuestionSolicitation.Commands;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.QuestionSolicitation.Handlers
{
    public class SolicitationUpdateCommandHandler : IRequestHandler<SolicitationUpdateCommand, Domain.Entities.QuestionSolicitation>
    {
        private readonly ISolicitationRepository _solicitationRepository;

        public SolicitationUpdateCommandHandler(ISolicitationRepository solicitationRepository)
        {
            _solicitationRepository = solicitationRepository;
        }

        public async Task<Domain.Entities.QuestionSolicitation> Handle(SolicitationUpdateCommand request, CancellationToken cancellationToken)
        {
            var solicitation = await _solicitationRepository.GetByIdAsync(request.Id);

            if (solicitation == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            }
            else
            {
                solicitation.Update(request.Description, request.TotalQuestionsRequest, request.CategoryId, request.ProfessorId, request.Status);
                return await _solicitationRepository.UpdateAsync(solicitation);
            }
        }
    }
}
