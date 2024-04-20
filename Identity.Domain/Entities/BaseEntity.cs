namespace Identity.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }

        public DateTime CreatedDate { get; protected set; } = DateTime.Now;
    }
}
