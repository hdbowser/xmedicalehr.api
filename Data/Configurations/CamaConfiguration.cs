using System;
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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(50)");
            
            builder.Property(x => x.HabitacionId)
                .HasColumnType("varchar(255)");

            builder.HasOne(x => x.Habitacion)
                .WithMany(h => h.Camas)
                .HasForeignKey(x => x.HabitacionId)
                .HasConstraintName("FK_Cama_Habitacion");
            

        }
    }
}