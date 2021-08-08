using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations
{
    public class SignosVitalesConfiguration : IEntityTypeConfiguration<SignosVitales>
    {
        public void Configure(EntityTypeBuilder<SignosVitales> builder)
        {
            builder.HasKey(x => new { x.AtencionId, x.NumItem })
                .HasName("PRIMARY");

            builder.Property(x => x.AtencionId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.NumItem)
                .HasColumnType("INT");

            builder.Property(x => x.NotaMedicaId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.NotaEnfermeriaId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Origen)
                .HasColumnType("varchar(10)");

            builder.Property(x => x.Temperatura)
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.UnidadTemperatura)
                .HasColumnType("varchar(15)");
            
            builder.Property(x => x.FrecuenciaRespiratoria)
                .HasColumnType("int");
            
            builder.Property(x => x.FrecuenciaCardiaca)
                .HasColumnType("int");
            
            builder.Property(x => x.PresionSistolica)
                .HasColumnType("int");
            
            builder.Property(x => x.PresionDiastolica)
                .HasColumnType("int");

            builder.Property(x => x.Diuresis)
                .HasColumnType("decimal(10,2)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");


            builder.HasOne(x => x.NotaMedica)
                .WithMany(nm => nm.SignosVitales)
                .HasForeignKey(x => x.NotaMedicaId)
                .HasConstraintName("FK_SignosVitales_NotasMedica");

            builder.HasOne(x => x.Atencion)
                .WithMany(nm => nm.SignosVitales)
                .HasForeignKey(x => x.AtencionId)
                .HasConstraintName("FK_SignosVitales_Atenciones");

            builder.HasOne(x => x.NotaEnfermeria)
                .WithMany(nm => nm.SignosVitales)
                .HasForeignKey(x => x.NotaEnfermeriaId)
                .HasConstraintName("FK_SignosVitales_NotasEnfermeria");
        }
    }
}