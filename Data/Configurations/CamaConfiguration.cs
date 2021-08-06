using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class CamaConfiguration : IEntityTypeConfiguration<Cama>
    {
        public void Configure(EntityTypeBuilder<Cama> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder.Property(x => x.HabitacionId)
                .HasColumnType("int");

            builder.HasOne(x => x.Habitacion)
                .WithMany(h => h.Camas)
                .HasForeignKey(x => x.HabitacionId)
                .HasConstraintName("FK_Cama_Habitacion");
        }
    }
}