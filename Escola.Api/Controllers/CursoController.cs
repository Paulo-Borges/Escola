using Escola.Application.DTOs.Curso;
using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : Controller
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;   
        }

        [HttpPost]
        public async Task<ActionResult> CreateCurso(CursoPostDTO cursoPostDTO)
        {
            var createdCurso = await _cursoService.AddAsync(cursoPostDTO);
            if (createdCurso == null)
            {
                return BadRequest("Não foi possível criar o curso.");
            }
            return Ok(new { message = "Curso criado com sucesso." });
        }
        [HttpPut]
        public async Task<ActionResult> UpdateCurso(CursoPutDTO cursoPutDTO)
        {
            var updatedCurso = await _cursoService.UpdateAsync(cursoPutDTO);
            if (updatedCurso == null)
            {
                return BadRequest("Não foi possível atualizar o curso.");
            }
            return Ok(new { message = "Curso atualizado com sucesso." });
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteCurso(int id)
        {
            var deleted = await _cursoService.DeleteAsync(id);
            if (deleted == null)
            {
                return BadRequest("Não foi possível deletar o curso.");
            }
            return Ok(new { message = "Curso deletado com sucesso." });
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCursoById(int id)
        {
            var curso = await _cursoService.GetByIdAsync(id);
            if (curso == null)
            {
                return NotFound("Curso não encontrado.");
            }
            return Ok(curso);
        }
        [HttpGet]
        public async Task<ActionResult> GetAllCursos()
        {
            var cursos = await _cursoService.GetAllAsync();
            return Ok(cursos);
        }
    }
}
