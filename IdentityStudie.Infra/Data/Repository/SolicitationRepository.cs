using IdentityStudie.Domain.Entities;
using IdentityStudie.Domain.Interfaces;
using IdentityStudie.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IdentityStudie.Infra.Data.Repository
{
    public class SolicitationRepository : ISolicitationRepository
    {
        private ApplicationDbContext _dbContext;

        public SolicitationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<QuestionSolicitation> CreateAsync(QuestionSolicitation solicitation)
        {
            _dbContext.Add(solicitation);
            await _dbContext.SaveChangesAsync();
            return solicitation;
        }

        public async Task<QuestionSolicitation> GetByIdAsync(int id)
        {
            return await _dbContext.Solicitations.Include(c => c.Category)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<QuestionSolicitation>> GetSolicitationsAsync()
        {
            return await _dbContext.Solicitations.ToListAsync();
        }

        public async Task<QuestionSolicitation> RemoveAsync(QuestionSolicitation solicitation)
        {
            _dbContext.Remove(solicitation);
            await _dbContext.SaveChangesAsync();
            return solicitation;
        }

        public async Task<QuestionSolicitation> UpdateAsync(QuestionSolicitation solicitation)
        {
            _dbContext.Update(solicitation);
            await _dbContext.SaveChangesAsync();
            return solicitation;
        }
    }
}
