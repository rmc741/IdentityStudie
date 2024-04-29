using System.Text.Json.Serialization;

namespace IdentityStudie.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; private set; }

        [JsonIgnore]
        public ICollection<QuestionSolicitation> QuestionsSolicitations { get; set; }
    }
}
