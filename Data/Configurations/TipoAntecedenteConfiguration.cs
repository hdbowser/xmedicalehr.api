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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Descripcion)
                .HasColumnType("varchar(100)");
            
            builder.Property(x => x.GrupoId)
                .HasColumnType("varchar(255)");


            builder.HasOne(x => x.Grupo)
                .WithMany(g => g.TiposAntecedentes)
                .HasForeignKey(x => x.GrupoId)
                .HasConstraintName("FK_TipoAntecedente_GrupoAntecedente");
            
        }
    }
}