using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using Escola.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {

        // INJEÇÃO DE DEPENDENCIA DO CONTEXTO
        private readonly ApplicationDbContext _context;
        public CursoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Curso> AddAsync(Curso curso)
        {
            _context.Curso.Add(curso);
            await _context.SaveChangesAsync();
            return curso;
        }

        public async Task<Curso> DeleteAsync(int id)
        {
            // coloca em uma variavel o curso que será excluido, caso não exista retorna null
            var curso = await _context.Curso.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (curso == null)
            {
                return null;
            }
            //se excluir fisicamente, não será possível recuperar o curso, então vamos apenas marcar como excluido
            curso.Excluido = true;

            _context.Curso.Update(curso);
            await _context.SaveChangesAsync();
            return curso;
            
        }

        public async Task<List<Curso>> GetAllAsync()
        {
            return await _context.Curso.Where(x => x.Excluido == false).ToListAsync();
        }

        public async Task<Curso> GetByIdAsync(int id)
        {
            return await _context.Curso.Where(x => x.Id == id && x.Excluido == false).FirstOrDefaultAsync();
        }

        public async Task<Curso> UpdateAsync(Curso curso)
        {
            _context.Curso.Update(curso);
            await _context.SaveChangesAsync();
            return curso;
        }
    }
}
