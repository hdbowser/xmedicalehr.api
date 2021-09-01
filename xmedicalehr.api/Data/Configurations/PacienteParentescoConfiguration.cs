using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class PacienteParentescoConfiguration : IEntityTypeConfiguration<PacienteParentesco>
    {
        public void Configure(EntityTypeBuilder<PacienteParentesco> builder)
        {
            builder.HasKey(x => new
            {
                x.PacienteId,
                x.TipoParentescoId,
                x.ParentescoId
            })
            .HasName("PRIMARY");

            builder.Property(x => x.PacienteId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.TipoParentescoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.ParentescoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Comentario)
                .HasColumnType("varchar(200)");
                


            builder.HasOne(x => x.Paciente)
                .WithMany(p => p.PacienteParentescos)
                .HasConstraintName("FK_PacienteParentescos_Pacientes")
                .HasForeignKey(x => x.PacienteId);

            builder.HasOne(x => x.Parentesco)
                .WithMany(p => p.ParentescosPaciente)
                .HasForeignKey(x => x.ParentescoId)
                .HasConstraintName("FK_ParentescosPaciente_Pacientes");

            builder.HasOne(x => x.TipoParentesco)
                .WithMany(p => p.PacientesParentesco)
                .HasConstraintName("FK_PacientesParentesco_TiposParentesco")
                .HasForeignKey(x => x.TipoParentescoId);
        }
    }
}