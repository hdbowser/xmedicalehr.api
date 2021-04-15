using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class SolicitudInterconsultaConfiguration : IEntityTypeConfiguration<SolicitudInterconsulta> {
        public void Configure (EntityTypeBuilder<SolicitudInterconsulta> builder) {
            builder.Property (x => x.AtencionId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.MedicoId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.MedicoInterconsultadoId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Motivo)
                .HasColumnType ("mediumtext");
            builder.Property (x => x.Recomentaciones)
                .HasColumnType ("mediumtext");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);
            builder.Property (x => x.Atendido)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);

            builder.HasKey (x => new { x.AtencionId, x.NumItem })
                .HasName ("PRIMARY");

            builder.HasOne (x => x.Atencion)
                .WithMany (s => s.SolicitudesInterconsultas)
                .HasConstraintName ("FK_SolicitudInterconsulta_AtencionMedica")
                .HasForeignKey (x => x.AtencionId);

            builder.HasOne (x => x.Departamento)
                .WithMany (d => d.SolicitudesInterconsultas)
                .HasForeignKey (x => x.DepartamentoId)
                .HasConstraintName ("FK_SolicitudInterconsulta_Departamento");

            builder.HasOne (x => x.Medico)
                .WithMany (m => m.InterconsultasSolicitadas)
                .HasConstraintName ("FK_SolicitudInterconsulta_MedicoSolicitante")
                .HasForeignKey (x => x.MedicoId);

            builder.HasOne (x => x.MedicoInterconsultado)
                .WithMany (z => z.SolicitudesInterconsultas)
                .HasForeignKey (x => x.MedicoInterconsultadoId)
                .HasConstraintName ("FK_SolicitudInterconsulta_MedicoInterconsultado");
        }
    }
}