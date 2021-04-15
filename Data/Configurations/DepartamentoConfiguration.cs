using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento> {
        public void Configure (EntityTypeBuilder<Departamento> builder) {
            builder.Property (x => x.Descripcion)
                .HasColumnType ("varchar(100)")
                .IsRequired ();
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}