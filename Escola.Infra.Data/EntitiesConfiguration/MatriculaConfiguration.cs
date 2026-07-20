using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    internal class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.UsuarioId)
                .IsRequired();
            builder.Property(m => m.TurmaId)
                .IsRequired();


            //chaves estrangeiras ForeignKey
            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
            //chaves estrangeiras ForeignKey
            builder.HasOne(x => x.Turma)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.TurmaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
