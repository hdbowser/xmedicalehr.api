using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class EnfermedadConfiguration : IEntityTypeConfiguration<Enfermedad>
    {
        public void Configure(EntityTypeBuilder<Enfermedad> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
                
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Catalogo)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Codigo)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(1024)")
                .IsRequired();

            builder.Property(x => x.Keywords)
                .HasColumnType("varchar(2045)");

        }
    }
}