using System;
using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class Paciente
    {
        public Paciente()
        {
            Alergias = new HashSet<AlergiaPaciente>();
            Antecedentes = new HashSet<AntecedentePaciente>();
            PacientesParentesco = new HashSet<PacienteParentesco>();
            Atenciones = new HashSet<AtencionMedica>();
        }
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public decimal Estatura { get; set; }
        public string UnidadEstatura { get; set; }
        public string NacionalidadId { get; set; }
        public string ProvinciaId { get; set; }
        public string Ciudad { get; set; }
        public string AseguradoraId { get; set; }
        public string NSS { get; set; }
        public string NumAsegurado { get; set; }
        public string Nota { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }

        // Navigations
        public virtual Nacionalidad Nacionalidad { get; set; }
        public virtual Aseguradora Aseguradora { get; set; }
        public virtual Provincia Provincia { get; set; }

        public virtual ICollection<AlergiaPaciente> Alergias { get; set; }
        public virtual ICollection<AntecedentePaciente> Antecedentes { get; set; }
        public virtual ICollection<PacienteParentesco> PacientesParentesco { get; set; }
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }
    }
}