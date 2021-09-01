using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
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
                .HasColumnType("varchar(45)");

            builder.Property(x => x.PacienteId)
                .HasColumnType("varchar(255)");

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
                .HasColumnType("varchar(255)");

            builder.Property(x => x.NombreFinanciador)
                .HasColumnType("varchar(200)");
            
            builder.Property(x => x.FechaIngreso)
                .HasColumnType("datetime");


            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");
                
            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint");

            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.DeletedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.UpdatedBy)
                .HasColumnType("varchar(255)");
            


            builder.HasOne(x => x.Paciente)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.PacienteId)
                .HasConstraintName("FK_AtencionesMedicas_Pacientes");

            builder.HasOne(x => x.TipoAtencion)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.TipoId)
                .HasConstraintName("FK_AtencionesMedicas_TipoAtenciones");

            builder.HasOne(x => x.Medico)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.MedicoId)
                .HasConstraintName("FK_AtencionesMedicas_Medicos");
            
            builder.HasOne(x => x.Cama)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.CamaId)
                .HasConstraintName("FK_AtencionesMedicas_Camas");

            builder.HasOne(x => x.Creator)
                .WithMany(p => p.AtencionesCreadas)
                .HasForeignKey(x => x.CreatedBy)
                .HasConstraintName("FK_AtencionesMedicas_Creator");
            
            builder.HasOne(x => x.Aseguradora)
                .WithMany(p => p.Atenciones)
                .HasForeignKey(x => x.AseguradoraId)
                .HasConstraintName("FK_AtencionesMedicas_Aseguradoras");
        }
    }
}