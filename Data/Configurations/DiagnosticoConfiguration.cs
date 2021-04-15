using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico> {
        public void Configure (EntityTypeBuilder<Diagnostico> builder) {
            builder.Property (x => x.NotaMedicaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.EnfermedadId)
                .HasColumnType ("varchar(255)")
                .IsRequired ();
            builder.Property (x => x.Comentario)
                .HasColumnType ("varchar(1024)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);

            builder.HasKey (x => new { x.NotaMedicaId, x.NumItem })
                .HasName ("PRIMARY");
        }
    }
}