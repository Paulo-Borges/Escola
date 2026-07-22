using Escola.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Application.DTOs.Matricula
{
    public class MatriculaGetDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TurmaId { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime DataExpiracao { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
       
    }
}
