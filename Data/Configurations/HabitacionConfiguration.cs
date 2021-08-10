using System;
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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)");
            

            builder.HasData(new Habitacion[]{
                new Habitacion{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Habitacion 301"
                },
                new Habitacion{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Habitacion 302"
                },
                new Habitacion{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Habitacion 303"
                }
            });
            
        }
    }
}