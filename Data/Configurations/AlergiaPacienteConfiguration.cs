using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Data.Configurations
{
    public class AlergiaPacienteConfiguration : IEntityTypeConfiguration<AlergiaPaciente>
    {
        public void Configure(EntityTypeBuilder<AlergiaPaciente> builder)
        {
            builder.HasKey(x => new { x.PacienteId, x.SustanciaId })
                .HasName("PRIMARY");
                
            builder.Property(x => x.PacienteId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.SustanciaId)
                .HasColumnType("int");

            builder.Property(x => x.Comentario)
                .HasColumnType("varchar(200)");


            builder.HasOne(x => x.Paciente)
                .WithMany(p => p.Alergias)
                .HasForeignKey(x => x.PacienteId)
                .HasConstraintName("FK_AlergiaPaciente_Pacientea");

        }
    }
}