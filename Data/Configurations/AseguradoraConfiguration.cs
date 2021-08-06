using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;

namespace xmedical_ehr.Data.Configurations
{
    public class AseguradoraConfiguration : IEntityTypeConfiguration<Aseguradora>
    {
        public void Configure(EntityTypeBuilder<Aseguradora> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
                
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.CodigoInt)
                .HasColumnType("varchar(255)");

        }
    }
}