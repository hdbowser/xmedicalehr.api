using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class SolicitudInterconsultaConfiguration : IEntityTypeConfiguration<SolicitudInterconsulta>
    {
        public void Configure(EntityTypeBuilder<SolicitudInterconsulta> builder)
        {
            builder.HasKey(x => new { x.AtencionId, x.NumItem })
                .HasName("PRIMARY");

            builder.Property(x => x.AtencionId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.NumItem)
                .HasColumnType("int");

            builder.Property(x => x.MedicoId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.DepartamentoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.MedicoInterconsultadoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Motivo)
                .HasColumnType("mediumtext");

            builder.Property(x => x.Recomendaciones)
                .HasColumnType("mediumtext");
            
            builder.Property(x => x.Atendido)
                .HasColumnType("tinyint(1)");


            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.UpdatedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.UpdatedBy)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");
            
            builder.Property(x => x.DeletedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");



            builder.HasOne(x => x.Atencion)
                .WithMany(s => s.SolicitudesInterconsultas)
                .HasForeignKey(x => x.AtencionId)
                .HasConstraintName("FK_SolicitudInterconsulta_AtencionMedica");

            builder.HasOne(x => x.Departamento)
                .WithMany(d => d.SolicitudesInterconsultas)
                .HasForeignKey(x => x.DepartamentoId)
                .HasConstraintName("FK_SolicitudInterconsulta_Departamento");

            builder.HasOne(x => x.Medico)
                .WithMany(m => m.InterconsultasSolicitadas)
                .HasForeignKey(x => x.MedicoId)
                .HasConstraintName("FK_SolicitudInterconsulta_MedicoSolicitante");

            builder.HasOne(x => x.MedicoInterconsultado)
                .WithMany(z => z.SolicitudesInterconsultas)
                .HasForeignKey(x => x.MedicoInterconsultadoId)
                .HasConstraintName("FK_SolicitudInterconsulta_MedicoInterconsultado");
        }
    }
}