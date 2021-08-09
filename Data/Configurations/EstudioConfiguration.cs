using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class EstudioConfiguration : IEntityTypeConfiguration<Estudio>
    {
        public void Configure(EntityTypeBuilder<Estudio> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(512)")
                .IsRequired();

            builder.Property(x => x.Tipo)
                .HasColumnType("varchar(45)");
            
            
            builder.HasData(new Estudio[]{
                new Estudio {
                    Id = 1,
                    Descripcion = "HEMOGRAMA",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = 2,
                    Descripcion = "ORINA",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = 3,
                    Descripcion = "COPROLOGICO",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = 4,
                    Descripcion = "SONOGRAFIA",
                    Tipo = "IMG"
                },
                new Estudio {
                    Id = 5,
                    Descripcion = "TOMOGRAFIA",
                    Tipo = "IMG"
                },
                new Estudio {
                    Id = 6,
                    Descripcion = "RADIOGRAFIA",
                    Tipo = "IMG"
                }
            });

        }
    }
}