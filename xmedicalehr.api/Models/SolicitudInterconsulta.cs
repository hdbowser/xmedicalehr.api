using System;
using System.Collections.Generic;
using xmedicalehr.api.Account;

namespace xmedicalehr.api.Models
{
    public class SolicitudInterconsulta
    {
        public string AtencionId { get; set; }
        public int NumItem { get; set; }
        public string MedicoId { get; set; }
        public string DepartamentoId { get; set; }
        public string MedicoInterconsultadoId { get; set; }
        public string Motivo { get; set; }
        public string Recomendaciones { get; set; }
        public bool Atendido { get; set; }
        
        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        

        // Navitagions

        public virtual AtencionMedica Atencion { get; set; }
        public virtual User Medico { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual User MedicoInterconsultado { get; set; }
    }
}