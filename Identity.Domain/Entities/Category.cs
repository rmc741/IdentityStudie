namespace Identity.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; private set; }
        public ICollection<QuestionSolicitation> QuestionsSolicitations { get; private set; }
    }
}
