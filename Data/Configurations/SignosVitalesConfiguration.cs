using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class SignosVitalesConfiguration : IEntityTypeConfiguration<SignosVitales> {
        public void Configure (EntityTypeBuilder<SignosVitales> builder) {
            builder.Property (x => x.AtencionId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.NotaMedicaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.NotaEnfermeriaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Origen)
                .HasColumnType ("varchar(10)");
            builder.Property (x => x.Temperatura)
                .HasColumnType ("decimal(10,2)");
            builder.Property (x => x.UnidadTemperatura)
                .HasColumnType ("varchar(15)");
            builder.Property (x => x.Diuresis)
                .HasColumnType ("decimal(10,2)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);

            builder.HasKey (x => new { x.AtencionId, x.NumItem });

            builder.HasOne (x => x.NotaMedica)
                .WithMany (nm => nm.SignosVitales)
                .HasForeignKey (x => x.NotaMedicaId)
                .HasConstraintName ("FK_SignosVitales_NotaMedica");

            builder.HasOne (x => x.Atencion)
                .WithMany (nm => nm.SignosVitales)
                .HasForeignKey (x => x.AtencionId)
                .HasConstraintName ("FK_SignosVitales_Atencion");

            builder.HasOne (x => x.NotaEnfermeria)
                .WithMany (nm => nm.SignosVitales)
                .HasForeignKey (x => x.NotaEnfermeriaId)
                .HasConstraintName ("FK_SignosVitales_NotaEnfermeria");
        }
    }
}