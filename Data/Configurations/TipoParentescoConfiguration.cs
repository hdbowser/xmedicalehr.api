using System;
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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(45)");

            
            builder.HasData(new TipoParentesco[]{
                new TipoParentesco{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Esposo/a"
                },
                new TipoParentesco{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Padre"
                },
                new TipoParentesco{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Madre"
                },
                new TipoParentesco{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Hijo/a"
                }
            });

        }
    }
}