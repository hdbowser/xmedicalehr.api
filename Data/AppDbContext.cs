using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using xmedicalehr.api.Account;
using xmedicalehr.api.Data.Configurations;
using xmedicalehr.api.Data.Migrations.Configurations;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Data
{
    public class AppDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<AlergiaPaciente> AlergiasPacientes { get; set; }
        public DbSet<AntecedentePaciente> AntecedetesPacientes { get; set; }
        public DbSet<Aseguradora> Aseguradoras { get; set; }
        public DbSet<GrupoAntecedente> GruposAntecedentes { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PacienteParentesco> PacientesParentescos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Sustancia> Sustancias { get; set; }
        public DbSet<TipoAntecedente> TiposAntecedentes { get; set; }
        public DbSet<TipoParentesco> TiposParentescos { get; set; }
        public DbSet<AtencionMedica> AtencionesMedicas { get; set; }
        public DbSet<TipoAtencion> TiposAtenciones { get; set; }
        public DbSet<Cama> Camas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }
        public DbSet<ExploracionItem> ExploracionItems { get; set; }
        public DbSet<ExploracionItemTemplate> ExploracionItemTemplates { get; set; }
        public DbSet<Medicacion> Medicaciones { get; set; }
        public DbSet<NotaEnfermeria> NotasEnfermeria { get; set; }
        public DbSet<OrdenMedica> OrdenesMedica { get; set; }
        public DbSet<NotaMedica> NotasMedica { get; set; }
        public DbSet<TipoNotaMedica> TiposNotasMedicas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<SignosVitales> SignosVitales { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<NotaMedicaCustomField> NotaMedicaCustomFields { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            builder.ApplyConfiguration(new AlergiaPacienteConfiguration());
            builder.ApplyConfiguration(new AntecedentePacienteConfiguration());
            builder.ApplyConfiguration(new AseguradoraConfiguration());
            builder.ApplyConfiguration(new GrupoAntecedenteConfiguration());
            builder.ApplyConfiguration(new NacionalidadConfiguration());
            builder.ApplyConfiguration(new PacienteConfiguration());
            builder.ApplyConfiguration(new PacienteParentescoConfituration());
            builder.ApplyConfiguration(new ProvinciaConfiguratoin());
            builder.ApplyConfiguration(new SustanciaConfiguration());
            builder.ApplyConfiguration(new TipoAntecedenteConfiguration());
            builder.ApplyConfiguration(new TipoParentescoConfiguration());

            builder.ApplyConfiguration(new AtencionMedicaConfiguration());
            builder.ApplyConfiguration(new TipoAntencionConfiguration());
            builder.ApplyConfiguration(new CamaConfiguration());
            builder.ApplyConfiguration(new HabitacionConfiguration());
            builder.ApplyConfiguration(new SolicitudInterconsultaConfiguration());
            builder.ApplyConfiguration(new DepartamentoConfiguration());

            builder.ApplyConfiguration(new EnfermedadConfiguration());
            builder.ApplyConfiguration(new ExploracionItemConfiguration());
            builder.ApplyConfiguration(new ExploracionItemTemplateConfiguration());
            builder.ApplyConfiguration(new MedicacionConfiguration());
            builder.ApplyConfiguration(new NotaEnfermeriaConfiguration());
            builder.ApplyConfiguration(new OrdenMedicaConfiguration());
            builder.ApplyConfiguration(new TipoNotaMedicaConfiguration());
            builder.ApplyConfiguration(new DiagnosticoConfiguration());
            builder.ApplyConfiguration(new EstudioConfiguration());
            builder.ApplyConfiguration(new MedicamentoConfiguration());
            builder.ApplyConfiguration(new NotaMedicaConfiguration());
            builder.ApplyConfiguration(new SignosVitalesConfiguration());
            builder.ApplyConfiguration(new EmpresaConfiguration());
            builder.ApplyConfiguration(new NotaMedicaCustomFieldConfiguration());

            base.OnModelCreating(builder);
        }
    }
}