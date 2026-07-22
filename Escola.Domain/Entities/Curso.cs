using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool Excluido { get; set; } // Propriedade para indicar se o curso foi excluído
        public ICollection<Turma> Turma { get; set; }
    }
}
