using IdentityStudie.Domain.Validation;

namespace IdentityStudie.Domain.Entities;

public sealed class QuestionSolicitation : BaseEntity
{
    public string Description { get; set; }
    public int TotalQuestionsRequest { get;  set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Question>? QuestionList { get; set; }

    public QuestionSolicitation(string description, int totalQuestions, int categoryId)
    {
        ValidateDomain(description, totalQuestions, categoryId);
    }

    public QuestionSolicitation(int id, string description, int totalQuestions, int categoryId)
    {
        DomainExceptionValidation.When(id < 0, "Invalid id value.");
        Id = id;

        ValidateDomain(description,totalQuestions,categoryId);
    }

    public void Update(string description, int totalQuestions, int categoryId)
    {
        ValidateDomain(description, totalQuestions, categoryId);
    }

    private void ValidateDomain(string description, int totalQuestions, int categoryId)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required.");
        DomainExceptionValidation.When(totalQuestions <= 0, "Invalid Total Questions Request value.");
        DomainExceptionValidation.When(categoryId <= 0, "Invalid Category Id value.");
        Description = description;
        TotalQuestionsRequest = totalQuestions;
        CategoryId = categoryId;
    }

    /*
    //public string UserId { get; set; }
    //public ApplicationUser User { get; set; }
    //public int? TotalQuestions { get => Questions?.Count; }
    */
}
