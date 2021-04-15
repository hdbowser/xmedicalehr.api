using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class PacienteParentescoConfituration : IEntityTypeConfiguration<PacienteParentesco> {
        public void Configure (EntityTypeBuilder<PacienteParentesco> builder) {
            builder.Property (x => x.PacienteId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.ParentescoId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Comentario)
                .HasColumnType ("varchar(200)");

            builder.HasKey (x => new {
                    x.PacienteId,
                        x.TipoParentescoId,
                        x.ParentescoId
                })
                .HasName ("PRIMARY");

            builder.HasOne (x => x.Paciente)
                .WithMany (p => p.PacientesParentescos)
                .HasConstraintName ("FK_ParentescoPaciente_Paciente")
                .HasForeignKey (x => x.PacienteId);

            builder.HasOne (x => x.Parentesco)
                .WithMany (p => p.ParentescosPacientes)
                .HasConstraintName ("FK_ParentescoPaciente_Parentesco")
                .HasForeignKey (x => x.ParentescoId);

            builder.HasOne (x => x.TipoParentesco)
                .WithMany (p => p.PacientesParentescos)
                .HasConstraintName ("FK_ParentescoPaciente_TipoParentesco")
                .HasForeignKey (x => x.TipoParentescoId);
        }
    }
}