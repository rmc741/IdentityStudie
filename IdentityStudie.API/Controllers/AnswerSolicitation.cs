using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityStudie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerSolicitation : ControllerBase
    {
        private readonly IAnswerSolicitationService _answerSolicitationService;

        public AnswerSolicitation(IAnswerSolicitationService answerSolicitations)
        {
            _answerSolicitationService = answerSolicitations;
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<IEnumerable<QuestionSolicitationDTO>>> GetSolicitationsByCategoryId(int categoryId)
        {
            var solicitationsList = await _answerSolicitationService.GetSolicitationsByCategoryId(categoryId);
            if (solicitationsList == null)
            {
                return NotFound("Solicitations not found");
            }

            return Ok(solicitationsList);
        }

        /*
         * TO-DO 
         * ENDPOINTS para Update e get solicitações por id
         * 
         */
    }
}
