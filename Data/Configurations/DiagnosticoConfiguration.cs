using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.HasKey(x => new { x.NotaMedicaId, x.NumItem })
                .HasName("PRIMARY");

            builder.Property(x => x.NotaMedicaId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.NumItem)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.EnfermedadId)
                .HasColumnType("varchar(255)");
                
            builder.Property(x => x.Comentario)
                .HasColumnType("varchar(1024)");

            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");

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



            builder.HasOne(x => x.NotaMedica)
                .WithMany(x => x.Diagnosticos)
                .HasForeignKey(x => x.NotaMedicaId)
                .HasConstraintName("FK_Diagnosticos_NotasMedicas");

            builder.HasOne(x => x.Enfermedad)
                .WithMany(x => x.Diagnosticos)
                .HasForeignKey(x => x.EnfermedadId)
                .HasConstraintName("FK_Diagnosticos_Enfermerdad");

        }
    }
}