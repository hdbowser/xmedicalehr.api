using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class OrdenMedicaConfiguration : IEntityTypeConfiguration<OrdenMedica>
    {
        public void Configure(EntityTypeBuilder<OrdenMedica> builder)
        {
            builder.HasKey(x => new { x.NotaMedicaId, x.NumItem });

            builder.Property(x => x.NotaMedicaId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.NumItem)
                .HasColumnType("int");

            builder.Property(x => x.TipoId)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.MedicamentoId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Unidad)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Cantiad)
                .HasColumnType("decimal(10,2");

            builder.Property(x => x.Via)
                .HasColumnType("varchar(100)");
            
            builder.Property(x => x.Intervalo)
                .HasColumnType("int");

            builder.Property(x => x.Tiempo)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Monodosis)
                .HasColumnType("tinyint(1)");
            
            builder.Property(x => x.NumDiagnostico)
                .HasColumnType("int");
            
            builder.Property(x => x.TiempoExpiracion)
                .HasColumnType("int");

            builder.Property(x => x.Suspendido)
                .HasColumnType("tinyint(1)");
            
            builder.Property(x => x.EstudioId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.Fecha)
                .HasColumnType("datetime");

            builder.Property(x => x.Instruccciones)
                .HasColumnType("mediumtext");

            builder.Property(x => x.Comentario)
                .HasColumnType("mediumtext");
            
            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.DeletedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.UpdatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.UpdatedAt)
                .HasColumnType("datetime");


            builder.HasOne(x => x.NotaMedica)
                .WithMany(nm => nm.OrdenesMedicas)
                .HasForeignKey(x => x.NotaMedicaId)
                .HasConstraintName("FK_OrdenesMedica_NotasMedica");

            builder.HasOne(x => x.Medicamento)
                .WithMany(nm => nm.OrdenesMedicas)
                .HasForeignKey(x => x.MedicamentoId)
                .HasConstraintName("FK_OrdenesMedica_Medicamentos");;

            builder.HasOne(x => x.Estudio)
                .WithMany(nm => nm.OrdenesMedicas)
                .HasForeignKey(x => x.EstudioId)
                .HasConstraintName("FK_OrdenesMedica_Estudios");;
        }
    }
}