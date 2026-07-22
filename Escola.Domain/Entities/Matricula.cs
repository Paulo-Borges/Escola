using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Matricula
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TurmaId { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime DataExpiracao { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
        public bool Excluido { get; set; } // Propriedade para indicar se a matrícula foi excluída

        // Matricula pode ter várias Notas, então é uma relação de 1 para N
        public ICollection<Nota> Notas { get; set; }
        public Usuario Usuario { get; set; } = new Usuario();
        public Turma Turma { get; set; }
    }
}
