using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class OrdenMedicaConfiguration : IEntityTypeConfiguration<OrdenMedica> {
        public void Configure (EntityTypeBuilder<OrdenMedica> builder) {
            builder.Property (x => x.NotaMedicaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.TipoId)
                .HasColumnType ("varchar(45)")
                .IsRequired ();
            builder.Property (x => x.MedicamentoId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Unidad)
                .HasColumnType ("varchar(45)");
            builder.Property (x => x.Cantiad)
                .HasColumnType ("decimal(10,2");
            builder.Property (x => x.Via)
                .HasColumnType ("varchar(100)");
            builder.Property (x => x.Tiempo)
                .HasColumnType ("varchar(45)");
            builder.Property (x => x.Monodosis)
                .HasColumnType ("tinyint(1)");
            builder.Property (x => x.Suspendido)
                .HasColumnType ("tinyint(1)");
            builder.Property (x => x.Instruccciones)
                .HasColumnType ("mediumtext");
            builder.Property (x => x.EstudioId)
                .HasColumnType ("mediumtext");

            builder.HasKey (x => new { x.NotaMedicaId, x.NumItem });

            builder.HasOne (x => x.NotaMedica)
                .WithMany (nm => nm.OrdenesMedicas)
                .HasForeignKey (x => x.NotaMedicaId)
                .HasConstraintName ("FK_OrdenMedica_NotaMedica");

            builder.HasOne (x => x.Medicamento)
                .WithMany (nm => nm.OrdenesMedicas)
                .HasForeignKey (x => x.MedicamentoId);

            builder.HasOne (x => x.Estudio)
                .WithMany (nm => nm.OrdenesMedicas)
                .HasForeignKey (x => x.EstudioId);
        }
    }
}