using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Models;
namespace xmedicalehr.api.Data.Configurations
{
    public class NotaEnfermeriaConfiguration : IEntityTypeConfiguration<NotaEnfermeria>
    {
        public void Configure(EntityTypeBuilder<NotaEnfermeria> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnType("varchar(255)");
                
            builder.Property(x => x.AtencionId)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.HabitusExterior)
                .HasColumnType("mediumtext");

            builder.Property(x => x.Observaciones)
                .HasColumnType("mediumtext");

            builder.Property(x => x.EnfermeraId)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.Fecha)
                .HasColumnType("datetime");
            
            builder.Property(x => x.CreatedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.CreatedBy)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Deleted)
                .HasColumnType("tinyint(1)");

            builder.Property(x => x.DeletedBy)
                .HasColumnType("varchar(255)");
            
            builder.Property(x => x.DeletedAt)
                .HasColumnType("datetime");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("datetime");
            
            builder.Property(x => x.UpdatedBy)
                .HasColumnType("varchar(255)");


            builder.HasOne(x => x.AtencionMedica)
                .WithMany(a => a.NotasEnfermeria)
                .HasForeignKey(x => x.AtencionId)
                .HasConstraintName("FK_NotaEnfermeria_AtencionMedia");

            builder.HasOne(x => x.Enfermera)
                .WithMany(a => a.NotasEnfermeria)
                .HasForeignKey(x => x.EnfermeraId)
                .HasConstraintName("FK_NotaEnfermeria_Enfermera");

        }
    }
}