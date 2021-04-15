using System;
using System.Collections.Generic;
using xmedical_ehr.Account;

namespace xmedical_ehr.Models {
    public class AtencionMedica {
        public string Id { get; set; }
        public string PaicienteId { get; set; }
        public string TipoId { get; set; }
        public string AseguradoraId { get; set; }
        public string MedicoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EdadPaciente { get; set; }
        public int CamaId { get; set; }
        public string Origen { get; set; }
        public string NombreFinanciador { get; set; }
        public string TipoFinanciamiento { get; set; }
        public byte[] FirmaPaciente { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }

        // Navigations
        public virtual Paciente Paciente { get; set; }
        public virtual TipoAtencion TipoAtencion { get; set; }
        public virtual User Medico { get; set; }
        public virtual Cama Cama { get; set; }
        public virtual User Creator { get; set; }
        public virtual ICollection<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
        public virtual ICollection<NotaMedica> NotasMedicas { get; set; }
        public virtual ICollection<SignosVitales> SignosVitales { get; set; }
        public virtual ICollection<NotaEnfermeria> NotasEnfermeria { get; set; }
    }
}