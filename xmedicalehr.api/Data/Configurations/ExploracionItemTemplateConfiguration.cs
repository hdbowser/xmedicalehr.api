using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Data.Configurations
{
    public class ExploracionItemTemplateConfiguration : IEntityTypeConfiguration<ExploracionItemTemplate>
    {
        public void Configure(EntityTypeBuilder<ExploracionItemTemplate> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(100)");
            
            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint");

        }
    }
}