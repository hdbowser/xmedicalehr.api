using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class SustanciaConfiguration : IEntityTypeConfiguration<Sustancia> {
        public void Configure (EntityTypeBuilder<Sustancia> builder) {
            builder.Property (x => x.Descripcion)
                .HasColumnType ("varchar(200)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }

    }
}