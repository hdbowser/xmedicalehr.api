using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class GrupoAntecedenteConfiguration : IEntityTypeConfiguration<GrupoAntecedente> {
        public void Configure (EntityTypeBuilder<GrupoAntecedente> builder) {
            builder.Property (x => x.Descripcion)
                .HasColumnType ("varchar(100)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");
        }
    }
}