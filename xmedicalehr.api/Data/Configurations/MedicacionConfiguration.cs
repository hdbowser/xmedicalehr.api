using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class MedicacionConfiguration : IEntityTypeConfiguration<Medicacion>
    {
        public void Configure(EntityTypeBuilder<Medicacion> builder)
        {
            builder.HasKey(x => new {x.AtencionId, x.NotaEnfermeriaId, x.NumItem })
                .HasName("PRIMARY");

            builder.Property(x => x.AtencionId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.NumItem)
                .HasColumnType("int");
            
            builder.Property(x => x.NotaEnfermeriaId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.MedicamentoId)
                .HasColumnType("varchar(45)");
            
            builder.Property(x => x.Cantidad)
                .HasColumnType("int");

            builder.Property(x => x.Unidad)
                .HasColumnType("varchar(25)");

            builder.Property(x => x.Via)
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Comentario)
                .HasColumnType("varchar(250)");

            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");
            
            builder.Property(x => x.DeletedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.UpdatedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.UpdatedAt)
                .HasColumnType("datetime");


            
            builder.HasOne(x => x.AtencionMedica)
                .WithMany(ne => ne.Medicaciones)
                .HasForeignKey(x => x.AtencionId)
                .HasConstraintName("FK_Medicacion_AtencionesMedicas");

            builder.HasOne(x => x.NotaEnfermeria)
                .WithMany(ne => ne.Medicaciones)
                .HasForeignKey(x => x.NotaEnfermeriaId)
                .HasConstraintName("FK_Medicacion_NotasEnfemeria");

            builder.HasOne(x => x.Medicamento)
                .WithMany(ne => ne.Medicaciones)
                .HasForeignKey(x => x.MedicamentoId)
                .HasConstraintName("FK_Medicacion_Medicamentos");
        }
    }
}