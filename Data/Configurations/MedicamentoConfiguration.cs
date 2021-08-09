using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(512)");
            
            builder.Property(X => X.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");
            
            builder.HasData(new Medicamento[]{
                new Medicamento{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "ACETAMINOFEN",
                    CreatedAt = DateTime.Now
                },
                new Medicamento{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "PARACETAMOL",
                    CreatedAt = DateTime.Now
                },
                new Medicamento{
                    Id = Guid.NewGuid().ToString(),
                    Descripcion = "SOLUCION SALINA MIXTA 1000ml",
                    CreatedAt = DateTime.Now
                }
            });
        }
    }
}