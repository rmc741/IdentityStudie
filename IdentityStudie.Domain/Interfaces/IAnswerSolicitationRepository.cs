using IdentityStudie.Domain.Entities;

namespace IdentityStudie.Domain.Interfaces
{
    public interface IAnswerSolicitationRepository
    {
        //informar um valor default para categoryId ou receber automaticamente
        Task<IEnumerable<QuestionSolicitation>> GetSolicitationsByCategoryIdAsync(int categoryId);
    }
}
