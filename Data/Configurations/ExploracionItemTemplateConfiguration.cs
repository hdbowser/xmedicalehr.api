using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;

namespace xmedical_ehr.Data.Configurations
{
    public class ExploracionItemTemplateConfiguration : IEntityTypeConfiguration<ExploracionItemTemplate>
    {
        public void Configure(EntityTypeBuilder<ExploracionItemTemplate> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");
            
            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(100)");

        }
    }
}