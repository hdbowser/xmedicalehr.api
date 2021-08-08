using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class TipoAntencionConfiguration : IEntityTypeConfiguration<TipoAtencion>
    {
        public void Configure(EntityTypeBuilder<TipoAtencion> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");
                
            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)")
                .IsRequired();

        }
    }
}