using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class TipoAntecedenteConfiguration : IEntityTypeConfiguration<TipoAntecedente>
    {
        public void Configure(EntityTypeBuilder<TipoAntecedente> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
            
            builder.Property(x => x.Id)
                .HasColumnType("int");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(x => x.GrupoId)
                .HasColumnType("int");


            builder.HasOne(x => x.Grupo)
                .WithMany(g => g.TiposAntecedentes)
                .HasForeignKey(x => x.GrupoId)
                .HasConstraintName("FK_TipoAntecedente_GrupoAntecedente");
            

            builder.HasData(new TipoAntecedente[]{
                new TipoAntecedente{
                    Id = 1,
                    Descripcion = "Cardiopatias",
                    GrupoId = 1
                },
                new TipoAntecedente{
                    Id = 2,
                    Descripcion = "Tabaquismo",
                    GrupoId = 2
                },
                new TipoAntecedente{
                    Id = 3,
                    Descripcion = "Conciencia de enfermedad",
                    GrupoId = 3
                }
            });
        }
    }
}