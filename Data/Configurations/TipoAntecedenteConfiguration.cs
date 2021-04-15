using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class TipoAntecedenteConfiguration : IEntityTypeConfiguration<TipoAntecedente> {
        public void Configure (EntityTypeBuilder<TipoAntecedente> builder) {
            builder.Property (x => x.Descricion)
                .HasColumnType ("varchar(100)")
                .IsRequired ();

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");

            builder.HasOne (x => x.Grupo)
                .WithMany (g => g.TiposAntecedentes)
                .HasForeignKey (x => x.GrupoId)
                .HasConstraintName ("FK_TipoAntecedente_GrupoAntecedente");
        }
    }
}