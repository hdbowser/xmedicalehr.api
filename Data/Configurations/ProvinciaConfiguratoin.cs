using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class ProvinciaConfiguratoin : IEntityTypeConfiguration<Provincia> {
        public void Configure (EntityTypeBuilder<Provincia> builder) {
            builder.Property (x => x.Id)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Nombre)
                .HasColumnType ("varchar(200)")
                .IsRequired ();
            builder.Property (x => x.CodigoInt)
                .HasColumnType ("varchar(255)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}