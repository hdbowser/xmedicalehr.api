using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class NacionalidadConfiguration : IEntityTypeConfiguration<Nacionalidad>
    {
        public void Configure(EntityTypeBuilder<Nacionalidad> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
                
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CodigoInt)
                .HasColumnType("varchar(255)");
            

            builder.HasData(new Nacionalidad[]{
                new Nacionalidad{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "Dominicana"
                }
            });

        }
    }
}