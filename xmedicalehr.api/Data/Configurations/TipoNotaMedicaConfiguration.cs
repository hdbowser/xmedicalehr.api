using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class TipoNotaMedicaConfiguration : IEntityTypeConfiguration<TipoNotaMedica>
    {
        public void Configure(EntityTypeBuilder<TipoNotaMedica> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)");
            

            builder.HasData(new TipoNotaMedica[]{
                new TipoNotaMedica{
                    Id = "I",
                    Descripcion = "Ingreso"
                },
                new TipoNotaMedica{
                    Id = "E",
                    Descripcion = "Evolucion"
                },
                new TipoNotaMedica{
                    Id = "EG",
                    Descripcion = "Egreso"
                }
            });
        }
    }
}