using IdentityStudie.Application.AnswerSolicitation.Queries;
using IdentityStudie.Domain.Interfaces;
using MediatR;

namespace IdentityStudie.Application.AnswerSolicitation.Handlers
{
    public class GetSolicitationByCategoryIdQueryHandler : IRequestHandler<GetSolicitationByCategoryIdQuery, IEnumerable<Domain.Entities.QuestionSolicitation>>
    {
        private readonly IAnswerSolicitationRepository _answerSolicitationRepository;

        public GetSolicitationByCategoryIdQueryHandler(IAnswerSolicitationRepository answerSolicitationRepository)
        {
            _answerSolicitationRepository = answerSolicitationRepository;
        }

        public async Task<IEnumerable<Domain.Entities.QuestionSolicitation>> Handle(GetSolicitationByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            /*
             * TO-DO
             * Implementar busca da lista de solicitações por category id
             */

            try
            {
                return await _answerSolicitationRepository.GetSolicitationsByCategoryIdAsync(request.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
