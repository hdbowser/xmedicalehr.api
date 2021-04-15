using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class NotaEnfermeriaConfiguration : IEntityTypeConfiguration<NotaEnfermeria> {
        public void Configure (EntityTypeBuilder<NotaEnfermeria> builder) {
            builder.Property (x => x.Id)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.AtencionId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.HabitusExterior)
                .HasColumnType ("mediumtext");
            builder.Property (x => x.Observaciones)
                .HasColumnType ("mediumtext");
            builder.Property (x => x.EnfermeraId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.CreatedBy)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);
            builder.Property (x => x.DeletedBy)
                .HasColumnType ("varchar(255)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");

            builder.HasOne (x => x.AtencionMedica)
                .WithMany (a => a.NotasEnfermeria)
                .HasForeignKey (x => x.AtencionId)
                .HasConstraintName ("FK_NotaEnfermeria_AtencionMedia");

            builder.HasOne (x => x.Enfermera)
                .WithMany (a => a.NotasEnfermeria)
                .HasForeignKey (x => x.EnfermeraId)
                .HasConstraintName ("FK_NotaEnfermeria_Enfermera");

        }
    }
}