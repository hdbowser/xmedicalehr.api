using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(512)");
            
            builder.Property(X => X.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");
        }
    }
}