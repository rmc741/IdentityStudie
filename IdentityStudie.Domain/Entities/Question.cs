namespace IdentityStudie.Domain.Entities
{
    public class Question : BaseEntity
    {
        //public int Id { get; set; }
        //public string Value { get; set; }
        //public bool WasUsed { get; set; }
        //public int NoticeId { get; set; }
        public int QuestionSolicitationId { get; set; }
        //public virtual ICollection<Options> Options { get; set; }
    }
}
