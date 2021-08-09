using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class GrupoAntecedenteConfiguration : IEntityTypeConfiguration<GrupoAntecedente>
    {
        public void Configure(EntityTypeBuilder<GrupoAntecedente> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(100)");
            
            
            builder.HasData(new GrupoAntecedente[]{
                new GrupoAntecedente{
                    Id = 1,
                    Descripcion = "PATOLOGICOS"
                },
                new GrupoAntecedente{
                    Id = 2,
                    Descripcion = "NO PATOLOGICOS"
                },
                new GrupoAntecedente{
                    Id = 3,
                    Descripcion = "PSIQUIATRICOS"
                }
            });

        }
    }
}