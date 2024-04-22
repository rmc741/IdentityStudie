using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Interfaces
{
    public interface IQuestionSolicitationService
    {
        Task<IEnumerable<QuestionSolicitationDTO>> GetProducts();
        Task Add(QuestionSolicitationDTO questionSolicictationDto);
        Task<QuestionSolicitationDTO> GetById(int? id);
        Task Update(QuestionSolicitationDTO questionSolicictationDto);
        Task Remove(int id);
    }
}
