using IdentityStudie.Domain.Enums;

namespace IdentityStudie.Application.DTOs
{
    public class AnswerSolicitationDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int? TotalQuestionsRequest { get; set; }

        public int? CategoryId { get; set; }

        public int? ProfessorId { get; set; }

        public StatusEnum Status { get; set; }
    }
}
