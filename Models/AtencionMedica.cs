using System;
using System.Collections.Generic;
using xmedicalehr.api.Account;

namespace xmedicalehr.api.Models
{
    public class AtencionMedica
    {
        public AtencionMedica()
        {
            SolicitudesInterconsultas = new HashSet<SolicitudInterconsulta>();
            NotasMedicas = new HashSet<NotaMedica>();
            SignosVitales = new HashSet<SignosVitales>();
            NotasEnfermeria = new HashSet<NotaEnfermeria>();
            Medicaciones = new HashSet<Medicacion>();
        }
        public string Id { get; set; }
        public string PacienteId { get; set; }
        public string TipoId { get; set; }
        public string AseguradoraId { get; set; }
        public string MedicoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EdadPaciente { get; set; }
        public string CamaId { get; set; }
        public string Origen { get; set; }
        public string NombreFinanciador { get; set; }
        public string TipoFinanciamiento { get; set; }
        public byte[] FirmaPaciente { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }



        // Navigation properties
        public virtual Paciente Paciente { get; set; }
        public virtual TipoAtencion TipoAtencion { get; set; }
        public virtual User Medico { get; set; }
        public virtual Cama Cama { get; set; }
        public virtual User Creator { get; set; }
        public virtual Aseguradora Aseguradora { get; set; }

        public virtual ICollection<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
        public virtual ICollection<NotaMedica> NotasMedicas { get; set; }
        public virtual ICollection<SignosVitales> SignosVitales { get; set; }
        public virtual ICollection<NotaEnfermeria> NotasEnfermeria { get; set; }
        public virtual ICollection<Medicacion> Medicaciones { get; set; }
    }
}