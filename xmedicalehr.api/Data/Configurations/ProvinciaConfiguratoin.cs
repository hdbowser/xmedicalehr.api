using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class ProvinciaConfiguratoin : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
                
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.CodigoInt)
                .HasColumnType("varchar(255)");
            

            builder.HasData(new Provincia[]{
                new Provincia{
                    Id = Guid.NewGuid().ToString(),
                    Nombre = "Duarte"
                }
            });
        }
    }
}