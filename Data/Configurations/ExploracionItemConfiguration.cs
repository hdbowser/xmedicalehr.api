using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class ExploracionItemConfiguration : IEntityTypeConfiguration<ExploracionItem>
    {
        public void Configure(EntityTypeBuilder<ExploracionItem> builder)
        {

            builder.HasKey(x => new { x.NotaMedicaId, x.ExploracionItemTemplateId })
                .HasName("PRIMARY");

            builder.Property(x => x.NotaMedicaId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.ExploracionItemTemplateId)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)")
                .HasDefaultValue(0);


            builder.HasOne(x => x.NotaMedica)
                .WithMany(nm => nm.ExploracionItems)
                .HasForeignKey(x => x.NotaMedicaId)
                .HasConstraintName("FK_ExploracionItem_NotasMedicas");

            builder.HasOne(x => x.ExploracionItemTemplate)
                .WithMany(nm => nm.ExploracionItems)
                .HasForeignKey(x => x.ExploracionItemTemplateId)
                .HasConstraintName("FK_ExploracionItem_ExploracionItemTemplate");
        }
    }
}