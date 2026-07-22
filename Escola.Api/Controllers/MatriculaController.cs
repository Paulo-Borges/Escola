using Escola.Application.DTOs.Matricula;
using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : Controller
    {
        private readonly IMatriculaService _matriculaService;

        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateMatricula(MatriculaPostDTO matriculaPostDTO)
        {
            var createdMatricula = await _matriculaService.AddAsync(matriculaPostDTO);
            if (createdMatricula == null)
            {
                return BadRequest("Não foi possível criar a matrícula.");
            }
            return Ok(new { message = "Matrícula criada com sucesso." });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMatricula(MatriculaPutDTO matriculaPutDTO)
        {
            var updatedMatricula = await _matriculaService.UpdateAsync(matriculaPutDTO);
            if (updatedMatricula == null)
            {
                return BadRequest("Não foi possível atualizar a matrícula.");
            }
            return Ok(new { message = "Matrícula atualizada com sucesso." });
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMatricula(int id)
        {
            var deleted = await _matriculaService.DeleteAsync(id);
            if (deleted == null)
            {
                return BadRequest("Não foi possível deletar a matrícula.");
            }
            return Ok(new { message = "Matrícula deletada com sucesso." });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAllMatriculaById(int id)
        {
            var matricula = await _matriculaService.GetByIdAsync(id);
            if (matricula == null)
                return NotFound("Matricula não encontrada!");
            return Ok(matricula);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllMatriculas()
        {
            var matriculas = await _matriculaService.GetAllAsync();
            return Ok(matriculas);
        }
    }
}
