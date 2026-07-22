using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Escola.Application.DTOs.Matricula
{
    public class MatriculaPutDTO
    {
        [Required(ErrorMessage = "O campo Id é obrigatório.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo TurmaId é obrigatório.")]
        public int TurmaId { get; set; }
        [Required(ErrorMessage = "O campo DataExpiracao é obrigatório.")]
        public DateTime DataExpiracao { get; set; } = DateTime.Now;
    }
}
