using IdentityStudie.Domain.Entities;
using IdentityStudie.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace IdentityStudie.Application.DTOs
{
    public class QuestionSolicitationDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [DisplayName("The Description is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The TotalQuestionsRequest is Required")]
        [Range(1, 9999)]
        [DisplayName("TotalQuestionsRequest")]
        public int TotalQuestionsRequest { get; set; }

        [Required(ErrorMessage = "The Category Id is Required")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        //Tirar o json ignora quando ja estiver com o retorno de category e questions ok
        [JsonIgnore]
        public Category? Category { get; set; }

        [JsonIgnore]
        public ICollection<Question>? QuestionList { get; set; }
    }
}
