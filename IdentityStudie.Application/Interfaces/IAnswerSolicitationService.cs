using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Interfaces
{
    public interface IAnswerSolicitationService
    {
        Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationsByCategoryId(int categoryId);
        Task<QuestionSolicitationDTO> GetSolicitationById(int solicitationId);
    }
}
