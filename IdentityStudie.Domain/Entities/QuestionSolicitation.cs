using IdentityStudie.Domain.Enums;
using IdentityStudie.Domain.Validation;

namespace IdentityStudie.Domain.Entities;

public sealed class QuestionSolicitation : BaseEntity
{
    public string Description { get; set; }
    public int TotalQuestionsRequest { get;  set; }
    public int CategoryId { get; set; }
    public int ProfessorId { get; set; }
    public StatusEnum Status { get; set; } = StatusEnum.Active;
    public Category Category { get; set; }
    public ICollection<Question>? QuestionList { get; set; }

    public QuestionSolicitation()
    {
        
    }

    public QuestionSolicitation(string description, int totalQuestions, int categoryId, int professorId, StatusEnum status)
    {
        ValidateDomain(description, totalQuestions, categoryId, professorId, status);
    }

    public QuestionSolicitation(int id, string description, int totalQuestions, int categoryId, int professorId, StatusEnum status)
    {
        DomainExceptionValidation.When(id < 0, "Invalid id value.");
        Id = id;

        ValidateDomain(description,totalQuestions,categoryId, professorId, status);
    }

    public void Update(string description, int totalQuestions, int categoryId, int professorId, StatusEnum status)
    {
        ValidateDomain(description, totalQuestions, categoryId, professorId, status);
    }

    private void ValidateDomain(string description, int totalQuestions, int categoryId, int professorId, StatusEnum status)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required.");
        DomainExceptionValidation.When(totalQuestions <= 0, "Invalid Total Questions Request value.");
        DomainExceptionValidation.When(categoryId <= 0, "Invalid Category Id value.");
        DomainExceptionValidation.When(professorId <= 0, "Invalid Professor Id value.");
        DomainExceptionValidation.When(status < 0, "Invalid Status value.");
        Description = description;
        TotalQuestionsRequest = totalQuestions;
        CategoryId = categoryId;
        ProfessorId = professorId;
        Status = status;
    }

    /*
    //public string UserId { get; set; }
    //public ApplicationUser User { get; set; }
    //public int? TotalQuestions { get => Questions?.Count; }
    */
}
