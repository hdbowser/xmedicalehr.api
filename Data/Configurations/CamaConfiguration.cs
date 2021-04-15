using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class CamaConfiguration : IEntityTypeConfiguration<Cama> {
        public void Configure (EntityTypeBuilder<Cama> builder) {
            builder.Property (x => x.Descripcion)
                .HasColumnType ("varchar(45)")
                .IsRequired ();

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");

            builder.HasOne (x => x.Habitacion)
                .WithMany (h => h.Camas)
                .HasForeignKey (x => x.HabitacionId)
                .HasConstraintName ("FK_Cama_Habitacion");
        }
    }
}