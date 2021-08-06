using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
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

            
        }
    }
}