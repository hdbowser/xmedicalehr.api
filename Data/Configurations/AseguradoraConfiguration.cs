using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Data.Configurations
{
    public class AseguradoraConfiguration : IEntityTypeConfiguration<Aseguradora>
    {
        public void Configure(EntityTypeBuilder<Aseguradora> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CodigoInt)
                .HasColumnType("varchar(255)");


            builder.HasData(new Aseguradora[]{
                new Aseguradora{
                    Id = Guid.NewGuid().ToString(),
                    Nombre = "SENASA"
                },
                new Aseguradora{
                    Id = Guid.NewGuid().ToString(),
                    Nombre = "ARS HUMANO"
                },
                new Aseguradora{
                    Id = Guid.NewGuid().ToString(),
                    Nombre = "UNIVERSAL"
                }
            });

        }
    }
}