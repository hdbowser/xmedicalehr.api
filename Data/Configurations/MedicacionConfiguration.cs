using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class MedicacionConfiguration : IEntityTypeConfiguration<Medicacion> {
        public void Configure (EntityTypeBuilder<Medicacion> builder) {
            builder.Property (x => x.NotaEnfermeriaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.MedicamentoId)
                .HasColumnType ("varchar(45)")
                .IsRequired ();
            builder.Property (x => x.Unidad)
                .HasColumnType ("varchar(25)");
            builder.Property (x => x.Via)
                .HasColumnType ("varchar(45)");
            builder.Property (x => x.Comentario)
                .HasColumnType ("varchar(250)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)");
            builder.Property (x => x.CreatedBy)
                .HasColumnType ("varchar(255)");

            builder.HasKey (x => new { x.NotaEnfermeriaId, x.NumItem });

            builder.HasOne (x => x.NotaEnfermeria)
                .WithMany (ne => ne.Medicaciones)
                .HasForeignKey (x => x.NotaEnfermeriaId);

            builder.HasOne (x => x.Medicamento)
                .WithMany (ne => ne.Medicaciones)
                .HasForeignKey (x => x.MedicamentoId);
        }
    }
}