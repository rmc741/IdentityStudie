using IdentityStudie.Application.AnswerSolicitation.Commands;
using IdentityStudie.Application.DTOs;
using IdentityStudie.Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IdentityStudie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAnyOrigin")]
    public class AnswerSolicitationController : ControllerBase
    {
        private readonly IAnswerSolicitationService _answerSolicitationService;

        public AnswerSolicitationController(IAnswerSolicitationService answerSolicitations)
        {
            _answerSolicitationService = answerSolicitations;
        }

        /// <summary>
        /// Rota para buscar todas Solicitações por Id de Categoria
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<IEnumerable<QuestionSolicitationDTO>>> GetSolicitationsByCategoryId(int categoryId)
        {
            var solicitationsList = await _answerSolicitationService.GetSolicitationsByCategoryId(categoryId);
            if (solicitationsList == null)
            {
                return NotFound("Solicitations not found");
            }

            return Ok(solicitationsList);
        }

        [HttpGet("solicitation/{solicitationId}")]
        public async Task<ActionResult<QuestionSolicitationDTO>> GetSolicitationById(int solicitationId)
        {
            var solicitation = await _answerSolicitationService.GetSolicitationById(solicitationId);
            if (solicitation == null)
            {
                return NotFound("Solicitation not found");
            }

            return Ok(solicitation);
        }

        [HttpGet("professor/{professorId}")]
        public async Task<ActionResult<IEnumerable<QuestionSolicitationDTO>>> GetSolicitationByProfessorId(int professorId)
        {
            var solicitation = await _answerSolicitationService.GetSolicitationByProfessorId(professorId);
            if (solicitation == null)
            {
                return NotFound("Solicitation not found");
            }

            return Ok(solicitation);
        }

        [HttpPut("solicitation/{solicitationId}")]
        //Criar um DTO para AnswerSolicitation
        public async Task<ActionResult<AnswerSolicitationDTO>> UpdateAnswerSolicitation(int solicitationId, [FromBody] AnswerSolicitationDTO solicitationDto)
        {
            if (solicitationId != solicitationDto.Id)
            {
                return BadRequest("Entity Invalid");
            }

            if (solicitationDto == null)
                return BadRequest("Entity Invalid");

            await _answerSolicitationService.Update(solicitationDto);

            return Ok(solicitationDto);
        }

        /*
         * TO-DO 
         * ENDPOINTS para Update e get solicitações por id
         * Endpoint para responser solicitação
         * Professor so poderá responder solicitação
         * Endpoint para professores so terá busca por categoria de acordo com categoria de seu perfil(role)
         */
    }
}
