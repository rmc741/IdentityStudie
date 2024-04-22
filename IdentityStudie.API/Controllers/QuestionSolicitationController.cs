using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IdentityStudie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionSolicitationController : ControllerBase
    {
        private readonly IQuestionSolicitationService _questionSolicitationService;

        public QuestionSolicitationController(IQuestionSolicitationService questionSolicitationService)
        {
            _questionSolicitationService = questionSolicitationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionSolicitationDTO>>> Get()
        {
            var questionSolicitationList = await _questionSolicitationService.GetSolicitations();
            if (questionSolicitationList == null)
            {
                return BadRequest("Solicitations not found");
            }

            return Ok(questionSolicitationList);
        }

        [HttpGet("{id}", Name = "GetSolicitation")]
        public async Task<ActionResult<QuestionSolicitationDTO>> Get(int id)
        {
            var solicitation = await _questionSolicitationService.GetById(id);
            if (solicitation == null)
            {
                return NotFound("Solicitation not found");
            }
            return Ok(solicitation);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] QuestionSolicitationDTO solicictationDTO)
        {
            if (solicictationDTO == null)
            {
                return BadRequest("Entity Invalid");
            }

            await _questionSolicitationService.Add(solicictationDTO);

            return new CreatedAtRouteResult("GetSolicitation",
                                             new { id = solicictationDTO.Id }, solicictationDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] QuestionSolicitationDTO solicictationDTO)
        {
            if (id != solicictationDTO.Id)
            {
                return BadRequest("Entity Invalid");
            }

            if (solicictationDTO == null)
                return BadRequest("Entity Invalid");

            await _questionSolicitationService.Update(solicictationDTO);

            return Ok(solicictationDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QuestionSolicitationDTO>> Delete(int id)
        {
            var produtoDto = await _questionSolicitationService.GetById(id);

            if (produtoDto == null)
            {
                return NotFound("Product not found");
            }

            await _questionSolicitationService.Remove(id);

            return Ok("Solicitation Removed");
        }
    }
}
