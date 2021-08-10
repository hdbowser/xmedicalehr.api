using System;
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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(512)");

            builder.Property(x => x.Tipo)
                .HasColumnType("varchar(45)");
            
            
            builder.HasData(new Estudio[]{
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "HEMOGRAMA",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "ORINA",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "COPROLOGICO",
                    Tipo = "LAB"
                },
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "SONOGRAFIA",
                    Tipo = "IMG"
                },
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "TOMOGRAFIA",
                    Tipo = "IMG"
                },
                new Estudio {
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "RADIOGRAFIA",
                    Tipo = "IMG"
                }
            });

        }
    }
}