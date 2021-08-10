using System;
using System.Collections.Generic;
using xmedicalehr.api.Account;

namespace xmedicalehr.api.Models
{
    public class NotaEnfermeria
    {
        public NotaEnfermeria()
        {
            SignosVitales = new HashSet<SignosVitales>();
            Medicaciones = new HashSet<Medicacion>();
        }
        public string Id { get; set; }
        public string AtencionId { get; set; }
        public string HabitusExterior { get; set; }
        public string Observaciones { get; set; }
        public string EnfermeraId { get; set; }
        public DateTime Fecha { get; set; }


        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        

        // Navigations
        public virtual AtencionMedica AtencionMedica { get; set; }
        public virtual User Enfermera { get; set; }
        public virtual ICollection<SignosVitales> SignosVitales { get; set; }
        public ICollection<Medicacion> Medicaciones { get; set; }
    }
}