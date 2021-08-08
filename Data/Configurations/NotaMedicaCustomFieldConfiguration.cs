using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class NotaMedicaCustomFieldConfiguration : IEntityTypeConfiguration<NotaMedicaCustomField>
    {
        public void Configure(EntityTypeBuilder<NotaMedicaCustomField> builder)
        {
            builder.HasKey(x => new { x.NotaMedicaId, x.NumItem })
                .HasName("PRIMARY");

            builder.Property(x => x.NotaMedicaId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.NumItem)
                .HasColumnType("int");

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Valor)
                .HasColumnType("mediumtext");

            builder.HasOne(x => x.NotaMedica)
                .WithMany(nm => nm.CustomFields)
                .HasForeignKey(x => x.NotaMedicaId)
                .HasConstraintName("FK_NotasMedicasCustomField_NotasMedica");
        }
    }
}