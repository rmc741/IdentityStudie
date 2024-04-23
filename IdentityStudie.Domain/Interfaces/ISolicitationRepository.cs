using IdentityStudie.Domain.Entities;

namespace IdentityStudie.Domain.Interfaces
{
    public interface ISolicitationRepository
    {
        Task<IEnumerable<QuestionSolicitation>> GetSolicitationsAsync();
        Task<QuestionSolicitation> GetByIdAsync(int id);
        Task<QuestionSolicitation> CreateAsync(QuestionSolicitation solicitation);
        Task<QuestionSolicitation> UpdateAsync(QuestionSolicitation solicitation);
        Task<QuestionSolicitation> RemoveAsync(QuestionSolicitation solicitation);
    }
}
