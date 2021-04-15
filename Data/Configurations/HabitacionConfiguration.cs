using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class HabitacionConfiguration : IEntityTypeConfiguration<Habitacion> {
        public void Configure (EntityTypeBuilder<Habitacion> builder) {
            builder.Property (x => x.Descripcion)
                .HasColumnType ("varchar(45)")
                .IsRequired ();

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}