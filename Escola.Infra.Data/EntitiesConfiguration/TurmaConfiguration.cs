using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    internal class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(t => t.CursoId)
                .IsRequired();
                

            //chaves estrangeiras ForeignKey
            builder.HasOne(t => t.Curso)
                .WithMany(c => c.Turma)
                .HasForeignKey(t => t.CursoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
