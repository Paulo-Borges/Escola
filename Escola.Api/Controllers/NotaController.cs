using Escola.Application.DTOs.Nota;
using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaController : Controller
    {
        private readonly INotaService _notaService;

        public NotaController(INotaService notaService)
        {
            _notaService = notaService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateNota(NotaPostDTO notaPostDTO)
        {
            var createdNota = await _notaService.AddAsync(notaPostDTO);
            if (createdNota == null)
            {
                return BadRequest("Não foi possível criar a nota.");
            }
            return Ok(new { message = "Nota criada com sucesso." });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(NotaPutDTO notaPutDTO)
        {
            var updatedNota = await _notaService.UpdateAsync(notaPutDTO);
            if (updatedNota == null)
            {
                return BadRequest("Não foi possível atualizar a nota.");
            }
            return Ok(new { message = "Nota atualizada com sucesso." });
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var deleted = await _notaService.DeleteAsync(id);
            if (deleted == null)
            {
                return BadRequest("Não foi possível deletar a nota.");
            }
            return Ok(new { message = "Nota deletada com sucesso." });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var nota = await _notaService.GetByIdAsync(id);
            if (nota == null)
                return NotFound("Nota não encontrada!");
            return Ok(nota);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var notas = await _notaService.GetAllAsync();
            return Ok(notas);
        }
    }
}
