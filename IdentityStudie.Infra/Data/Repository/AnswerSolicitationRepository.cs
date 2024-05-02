using IdentityStudie.Domain.Entities;
using IdentityStudie.Domain.Interfaces;
using IdentityStudie.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Infra.Data.Repository
{
    public class AnswerSolicitationRepository : IAnswerSolicitationRepository
    {
        private ApplicationDbContext _dbContext;

        public AnswerSolicitationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<QuestionSolicitation>> GetSolicitationsByCategoryIdAsync(int categoryId)
        {
            return await _dbContext.Solicitations
                                    .Where(s => s.CategoryId == categoryId)
                                    .ToListAsync();
        }
    }
}
