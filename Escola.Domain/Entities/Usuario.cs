using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        //public string Senha { get; set; } nunca armazenar senha em texto puro, use hash e salt
        public byte[] PasswordHash { get; set; }  // Armazena o hash da senha
        public byte[] PasswordSalt { get; set; }  // pra verificar o passwordHash
        public string Perfil { get; set; } // Ex: Admin, User, etc.

        // usuario pode ter várias matriculas, então é uma relação de 1 para N
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
