using System;
using System.Collections.Generic;
using xmedical_ehr.Account;

namespace xmedical_ehr.Models {
    public class NotaEnfermeria {
        public string Id { get; set; }
        public string AtencionId { get; set; }
        public string HabitusExterior { get; set; }
        public string Observaciones { get; set; }
        public string EnfermeraId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }

        // Navigations
        public virtual ICollection<SignosVitales> SignosVitales { get; set; }
        public virtual AtencionMedica AtencionMedica { get; set; }
        public virtual User Enfermera { get; set; }
        public ICollection<Medicacion> Medicaciones { get; set; }
    }
}