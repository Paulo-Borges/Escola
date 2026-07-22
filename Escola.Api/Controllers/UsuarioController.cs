//using Escola.Application.DTOs.Usuario;
//using Escola.Application.Interfaces;
//using Microsoft.AspNetCore.Mvc;

//namespace Escola.Api.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class UsuarioController : Controller
//    {
//        private readonly IUsuarioService _usuarioService;

//        public UsuarioController(IUsuarioService usuarioService)
//        {
//            _usuarioService = usuarioService;       
//        }

//        [HttpPost]
//        public async Task<ActionResult> CreateUsuario(UsuarioPostDTO usuarioPostDTO)
//        {
//            var createdUsuario = await _usuarioService.AddAsync(usuarioPostDTO);
//            if (createdUsuario == null)
//            {
//                return BadRequest("Não foi possível criar o usuário.");
//            }
//            return Ok(new { message = "Usuário criado com sucesso." });
//        }
//        [HttpPut]
//        public async Task<ActionResult> UpdateUsuario(UsuarioPutDTO usuarioPutDTO)
//        {
//            var updatedUsuario = await _usuarioService.UpdateAsync(usuarioPutDTO);
//            if (updatedUsuario == null)
//            {
//                return BadRequest("Não foi possível atualizar o usuário.");
//            }
//            return Ok(new { message = "Usuário atualizado com sucesso." });
//        }
//        [HttpDelete("{id}")]
//        public async Task<ActionResult> DeleteUsuario(int id)
//        {
//            var deleted = await _usuarioService.DeleteAsync(id);
//            if (deleted == null)
//            {
//                return BadRequest("Não foi possível deletar o usuário.");
//            }
//            return Ok(new { message = "Usuário deletado com sucesso." });
//        }
//        [HttpGet("{id}")]
//        public async Task<ActionResult> GetUsuarioById(int id)
//        {
//            var usuario = await _usuarioService.GetByIdAsync(id);
//            if (usuario == null)
//            {
//                return NotFound("Usuário não encontrado.");
//            }
//            return Ok(usuario);
//        }
//        [HttpGet]
//        public async Task<ActionResult> GetAllUsuarios()
//        {
//            var usuarios = await _usuarioService.GetAllAsync();
//            return Ok(usuarios);
//        }
//    }
//}
