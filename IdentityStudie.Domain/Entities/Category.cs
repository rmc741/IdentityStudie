namespace IdentityStudie.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; private set; }
        public ICollection<QuestionSolicitation> QuestionsSolicitations { get; set; }
    }
}
