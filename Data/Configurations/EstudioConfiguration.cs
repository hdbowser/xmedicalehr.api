using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class EstudioConfiguration : IEntityTypeConfiguration<Estudio>
    {
        public void Configure(EntityTypeBuilder<Estudio> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(512)")
                .IsRequired();

            builder.Property(x => x.Tipo)
                .HasColumnType("varchar(45)");

        }
    }
}