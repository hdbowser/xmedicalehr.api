using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class NotaMedicaCustomFieldConfiguration : IEntityTypeConfiguration<NotaMedicaCustomField> {
        public void Configure (EntityTypeBuilder<NotaMedicaCustomField> builder) {
            builder.Property (x => x.NotaMedicaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Titulo)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Valor)
                .HasColumnType ("medimtext");

            builder.HasKey (x => new { x.NotaMedicaId, x.NumItem })
                .HasName ("PRIMARY");

            builder.HasOne (x => x.NotaMedica)
                .WithMany (nm => nm.CustomFields)
                .HasForeignKey (x => x.NotaMedicaId)
                .HasConstraintName ("FK_NotaMedicacustomField_NotaMedica");
        }
    }
}