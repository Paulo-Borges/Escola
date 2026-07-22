using Escola.Application.DTOs.Turma;
using Escola.Application.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Application.DTOs.Matricula
{
    public class MatriculaGetDetailDTO
    {
        public int Id { get; set; }
        public UsuarioGetDTO Usuario { get; set; }
        public TurmaGetDTO Turma { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime DataExpiracao { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
    }
}
