using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class HabitacionConfiguration : IEntityTypeConfiguration<Habitacion>
    {
        public void Configure(EntityTypeBuilder<Habitacion> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)")
                .IsRequired();
            

            builder.HasData(new Habitacion[]{
                new Habitacion{
                    Id = 1,
                    Descripcion = "Habitacion 301"
                },
                new Habitacion{
                    Id = 2,
                    Descripcion = "Habitacion 302"
                },
                new Habitacion{
                    Id = 3,
                    Descripcion = "Habitacion 303"
                }
            });
            
        }
    }
}