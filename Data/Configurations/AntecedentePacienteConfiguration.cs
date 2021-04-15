using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class AntecedentePacienteConfiguration : IEntityTypeConfiguration<AntecedentePaciente> {
        public void Configure (EntityTypeBuilder<AntecedentePaciente> builder) {
            builder.Property (x => x.PacienteId)
                .HasColumnType ("varchar(255)");

            builder.Property (x => x.Detalle)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.CreatedBy)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);

            builder.HasKey (x => new { x.PacienteId, x.TipoAntecedenteId })
                .HasName ("PRIMARY");

            builder.HasOne (x => x.Paciente)
                .WithMany (p => p.Antecedentes)
                .HasForeignKey (x => x.PacienteId)
                .HasConstraintName ("FK_AntecedentePaciente_Paciente");

            builder.HasOne (x => x.TipoAntecedente)
                .WithMany (p => p.AntecedentesPacientes)
                .HasForeignKey (x => x.TipoAntecedenteId)
                .HasConstraintName ("FK_AntecedentePaciente_TipoAntecedente");
        }
    }
}