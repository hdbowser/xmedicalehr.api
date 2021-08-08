using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class NotaMedicaConfiguration : IEntityTypeConfiguration<NotaMedica>
    {
        public void Configure(EntityTypeBuilder<NotaMedica> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.AtencionId)
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.MotivoConsulta)
                .HasColumnType("mediumtext");

            builder.Property(x => x.HistoriaEnfermedad)
                .HasColumnType("mediumtext");

            builder.Property(x => x.Nota)
                .HasColumnType("mediumtext");
            
            builder.Property(x => x.TipoNotaId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.DeOrden)
                .HasColumnType("tinyint(1)");

            builder.Property(x => x.Dieta)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.ExamenFisico)
                .HasColumnType("mediumtext");
            
            builder.Property(x => x.Observaciones)
                .HasColumnType("mediumtext");
            
            builder.Property(x => x.MedicoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.MotivoEgreso)
                .HasColumnType("mediumtext");

            builder.Property(x => x.Pronostico)
                .HasColumnType("varchar(100)");
            
            builder.Property(x => x.Fecha)
                .HasColumnType("datetime");

            builder.Property(x => x.Peso)
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.UnidadPeso)
                .HasColumnType("varchar(45)");
            
            builder.Property(x => x.EscalaGlasgow)
                .HasColumnType("int");
            
            builder.Property(x => x.EscalaDolor)
                .HasColumnType("int");
            
            builder.Property(x => x.SaturacionOxigeno)
                .HasColumnType("int)");

            builder.Property(x => x.OtrosParametros)
                .HasColumnType("varchar(1024)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint");
            
            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.HasOne(x => x.AtencionMedica)
                .WithMany(nm => nm.NotasMedicas)
                .HasForeignKey(x => x.AtencionId)
                .HasConstraintName("FK_NotasMedicas_AtencionesMedica");

            builder.HasOne(x => x.TipoNota)
                .WithMany(nm => nm.NotasMedicas)
                .HasForeignKey(x => x.TipoNotaId)
                .HasConstraintName("FK_NotasMedicas_TiposNota");

            builder.HasOne(x => x.Medico)
                .WithMany(nm => nm.NotasMedicas)
                .HasForeignKey(x => x.MedicoId)
                .HasConstraintName("FK_NotasMedicas_Medicos");

        }
    }
}