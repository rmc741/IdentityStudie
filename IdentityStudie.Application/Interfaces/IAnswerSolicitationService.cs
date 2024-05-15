using IdentityStudie.Application.AnswerSolicitation.Commands;
using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Interfaces
{
    public interface IAnswerSolicitationService
    {
        Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationsByCategoryId(int categoryId);
        Task<QuestionSolicitationDTO> GetSolicitationById(int solicitationId);
        Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitationByProfessorId(int professorId);
        Task Update(AnswerSolicitationDTO answerSolicictationDto);
    }
}
