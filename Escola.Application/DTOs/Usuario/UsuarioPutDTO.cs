using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Escola.Application.DTOs.Usuario
{
    public class UsuarioPutDTO
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O campo Nome deve ter no máximo 250 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O campo Email deve ter no máximo 250 caracteres.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O campo Senha deve ter no máximo 250 caracteres.")]
        [MinLength(6, ErrorMessage = "O campo Senha deve ter no mínimo 6 caracteres.")]
        public string Senha { get; set; }
    }
}
