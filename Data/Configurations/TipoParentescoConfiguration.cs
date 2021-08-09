using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class TipoParentescoConfiguration : IEntityTypeConfiguration<TipoParentesco>
    {
        public void Configure(EntityTypeBuilder<TipoParentesco> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)")
                .IsRequired();

            
            builder.HasData(new TipoParentesco[]{
                new TipoParentesco{
                    Id = 1,
                    Descripcion = "Esposo/a"
                },
                new TipoParentesco{
                    Id = 2,
                    Descripcion = "Padre"
                },
                new TipoParentesco{
                    Id = 3,
                    Descripcion = "Madre"
                },
                new TipoParentesco{
                    Id = 4,
                    Descripcion = "Hijo/a"
                }
            });

        }
    }
}