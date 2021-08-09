using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
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
            

            builder.HasData(new Cama[]{
                new Cama{
                    Id = 1,
                    Descripcion = "1",
                    HabitacionId = 1
                },
                new Cama{
                    Id = 2,
                    Descripcion = "1",
                    HabitacionId = 2
                },
                new Cama{
                    Id = 3,
                    Descripcion = "1",
                    HabitacionId = 3
                }
            });
        }
    }
}