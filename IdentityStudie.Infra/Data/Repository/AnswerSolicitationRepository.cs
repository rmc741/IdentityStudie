using IdentityStudie.Domain.Entities;
using IdentityStudie.Domain.Interfaces;
using IdentityStudie.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IdentityStudie.Infra.Data.Repository
{
    public class AnswerSolicitationRepository : IAnswerSolicitationRepository
    {
        private ApplicationDbContext _dbContext;

        public AnswerSolicitationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<QuestionSolicitation> GetSolicitationById(int id)
        {
            return await _dbContext.Solicitations.Include(c => c.Category)
                .SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<QuestionSolicitation>> GetSolicitationsByCategoryIdAsync(int categoryId)
        {
            return await _dbContext.Solicitations
                                    .Where(s => s.CategoryId == categoryId)
                                    .ToListAsync();
        }

        public async Task<IEnumerable<QuestionSolicitation>> GetSolicitationsByProfessorIdAsync(int professorId)
        {
            return await _dbContext.Solicitations
                                    .Where(s => s.ProfessorId == professorId)
                                    .ToListAsync();
        }

        public async Task<QuestionSolicitation> UpdateAsync(QuestionSolicitation solicitation)
        {
            _dbContext.Update(solicitation);
            await _dbContext.SaveChangesAsync();
            return solicitation;
        }
    }
}
