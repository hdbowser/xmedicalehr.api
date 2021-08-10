using System;

namespace xmedicalehr.api.Models
{
    public class AntecedentePaciente
    {
        public string PacienteId { get; set; }
        public string TipoAntecedenteId { get; set; }
        public string Detalle { get; set; }


        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }


        // Navigations
        public virtual Paciente Paciente { get; set; }
        public virtual TipoAntecedente TipoAntecedente { get; set; }
    }
}