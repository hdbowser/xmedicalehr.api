using System;

namespace xmedical_ehr.Models {
    public class AntecedentePaciente {
        public string PacienteId { get; set; }
        public int TipoAntecedenteId { get; set; }
        public string Detalle { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }

        // Navigations
        public virtual Paciente Paciente { get; set; }
        public virtual TipoAntecedente TipoAntecedente { get; set; }
    }
}