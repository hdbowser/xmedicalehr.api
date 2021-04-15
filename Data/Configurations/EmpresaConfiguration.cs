using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa> {
        public void Configure (EntityTypeBuilder<Empresa> builder) {
            builder.Property (x => x.Id)
                .HasColumnType ("varchar(255");
            builder.Property (x => x.Nombre)
                .HasColumnType ("varchar(255)")
                .IsRequired ();
            builder.Property (x => x.Telefono)
                .HasColumnType ("varchar(45)");
            builder.Property (x => x.Direccion)
                .HasColumnType ("varchar(200)");
            builder.Property (x => x.Eslogan)
                .HasColumnType ("varchar(200)");
            builder.Property (x => x.Logo)
                .HasColumnType ("varbinary(2038)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}