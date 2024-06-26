﻿using IdentityStudie.Application.DTOs;

namespace IdentityStudie.Application.Interfaces
{
    public interface ISolicitationService
    {
        Task<IEnumerable<QuestionSolicitationDTO>> GetSolicitations();
        Task Add(QuestionSolicitationDTO questionSolicictationDto);
        Task<QuestionSolicitationDTO> GetById(int id);
        Task Update(QuestionSolicitationDTO questionSolicictationDto);
        Task Remove(int id);
    }
}
