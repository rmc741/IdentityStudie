using Identity.Domain.Validation;

namespace Identity.Domain.Entities
{
    public class QuestionSolicitation : BaseEntity
    {
        public string Description { get; set; }
        public int TotalQuestionsRequest { get;  set; }
        public int CategoryId { get;  set; }
        public Category Category { get; set; }
        public ICollection<Question>? QuestionList { get; set; }

        public QuestionSolicitation(string description, int totalQuestions, int categoryId)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required.");
            DomainExceptionValidation.When(totalQuestions <= 0, "Invalid Total Questions Request value.");
            DomainExceptionValidation.When(categoryId <= 0, "Invalid Category Id value.");
            Description = description;
            TotalQuestionsRequest = totalQuestions;
            CategoryId = categoryId;
        }

        public QuestionSolicitation(int id, string description, int totalQuestions, int categoryId)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value.");
            Id = id;

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
        //public int? TotalQuestions { get => Questions?.Count; }*/

        /*
        //public Product(string name, string description, decimal price, int stock, string image)
        //{
        //    ValidateDomain(name, description, price, stock, image);
        //}
        //
        //public Product(int id, string name, string description, decimal price, int stock, string image)
        //{
        //    DomainExceptionValidation.When(id < 0, "Invalid Id value.");
        //    Id = id;
        //    ValidateDomain(name, description, price, stock, image);
        //}
        //
        //public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        //{
        //    ValidateDomain(name, description, price, stock, image);
        //    CategoryId = categoryId;
        //}
        //
        //private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        //{
        //    DomainExceptionValidation.When(string.IsNullOrEmpty(name),
        //        "Invalid name. Name is required");
        //
        //    DomainExceptionValidation.When(name.Length < 3,
        //        "Invalid name, too short, minimum 3 characters");
        //
        //    DomainExceptionValidation.When(string.IsNullOrEmpty(description),
        //        "Invalid description. Description is required");
        //
        //    DomainExceptionValidation.When(description.Length < 5,
        //        "Invalid description, too short, minimum 5 characters");
        //
        //    DomainExceptionValidation.When(price < 0, "Invalid price value");
        //
        //    DomainExceptionValidation.When(stock < 0, "Invalid stock value");
        //
        //    DomainExceptionValidation.When(image?.Length > 250,
        //        "Invalid image name, too long, maximum 250 characters");
        //
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //    Stock = stock;
        //    Image = image;
        //}
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        */
    }
}
