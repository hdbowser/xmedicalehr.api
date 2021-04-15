using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Models;
namespace xmedical_ehr.Data.Configurations {
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente> {
        public void Configure (EntityTypeBuilder<Paciente> builder) {
            builder.Property (x => x.Id)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Nombres)
                .HasColumnType ("varchar(100)")
                .IsRequired ();
            builder.Property (x => x.PrimerApellido)
                .HasColumnType ("varchar(100)");
            builder.Property (x => x.SegundoApellido)
                .HasColumnType ("varchar(100)");
            builder.Property (x => x.Sexo)
                .HasColumnType ("char(1)")
                .IsRequired ();
            builder.Property (x => x.EstadoCivil)
                .HasColumnType ("char(1)");
            builder.Property (x => x.Telefono)
                .HasColumnType ("varchar(20)");
            builder.Property (x => x.Celular)
                .HasColumnType ("varchar(20)");
            builder.Property (x => x.Email)
                .HasColumnType ("varchar(100)");
            builder.Property (x => x.Cedula)
                .HasColumnType ("varchar(15)");
            builder.Property (x => x.Direccion)
                .HasColumnType ("varchar(250)");
            builder.Property (x => x.Estatura)
                .HasColumnType ("decimal(10,2)");
            builder.Property (x => x.UnidadEstatura)
                .HasColumnType ("varchar(10)");
            builder.Property (x => x.NacionalidadId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.ProvinciaId)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Ciudad)
                .HasColumnType ("varchar(150)");
            builder.Property (x => x.NSS)
                .HasColumnType ("varchar(20)");
            builder.Property (x => x.NumAsegurado)
                .HasColumnType ("varchar(20)");
            builder.Property (x => x.Nota)
                .HasColumnType ("varchar(512)");
            builder.Property (x => x.CreatedBy)
                .HasColumnType ("varchar(255)");
            builder.Property (x => x.Deleted)
                .HasColumnType ("tinyint(1)")
                .HasDefaultValue (0);
            builder.Property (x => x.DeletedBy)
                .HasColumnType ("varchar(255)");

            builder.HasKey (x => x.Id)
                .HasName ("PRIMARY");

            builder.HasIndex (x => x.Cedula)
                .HasDatabaseName ("Cedula_UNIQUE")
                .IsUnique ();

            builder.HasOne (x => x.Aseguradora)
                .WithMany (a => a.Pacientes)
                .HasConstraintName ("FK_Paciente_Aseguradora")
                .HasForeignKey (x => x.AseguradoraId);

            builder.HasOne (x => x.Nacionalidad)
                .WithMany (n => n.Pacientes)
                .HasConstraintName ("FK_Paciente_Nacionalidad")
                .HasForeignKey (x => x.NacionalidadId);

            builder.HasOne (x => x.Provincia)
                .WithMany (n => n.Pacientes)
                .HasConstraintName ("FK_Paciente_Provincia")
                .HasForeignKey (x => x.ProvinciaId);
        }
    }
}