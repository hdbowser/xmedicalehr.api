using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;;

namespace xmedical_ehr.Data.Configurations {
    public class ExploracionItemTemplateConfiguration : IEntityTypeConfiguration<ExploracionItemTemplate> {
        public void Configure (EntityTypeBuilder<ExploracionItemTemplate> builder) {
            builder.Property (x => x.Nombre)
                .HasColumnType ("varchar(100)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}