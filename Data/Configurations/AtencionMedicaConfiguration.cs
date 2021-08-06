using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class AtencionMedicaConfiguration : IEntityTypeConfiguration<AtencionMedica>
    {
        public void Configure(EntityTypeBuilder<AtencionMedica> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");
                
            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.TipoId)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(x => x.PacienteId)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.AseguradoraId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.MedicoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.EdadPaciente)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Origen)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.TipoFinanciamiento)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.FirmaPaciente)
                .HasColumnType("varbinary(2048)");
            
            builder.Property(x => x.CamaId)
                .HasColumnType("int");

            builder.Property(x => x.NombreFinanciador)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");
                
            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint");

            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            

            builder.HasOne(x => x.Paciente)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.PacienteId)
                .HasConstraintName("FK_AtencionMedica_Paciente");

            builder.HasOne(x => x.TipoAtencion)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.TipoId)
                .HasConstraintName("FK_AtencionMedica_TipoAtencion");

            builder.HasOne(x => x.Medico)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.MedicoId)
                .HasConstraintName("FK_AtencionMedica_Medico");

            builder.HasOne(x => x.Creator)
                .WithMany(p => p.AtencionesCreadas)
                .HasForeignKey(x => x.CreatedBy)
                .HasConstraintName("FK_AtencionMedica_Creator");
        }
    }
}