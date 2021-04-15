using System;
using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Medicamento {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }

        // Navigations
        public virtual ICollection<OrdenMedica> OrdenesMedicas { get; set; }
        public ICollection<Medicacion> Medicaciones { get; set; }

    }
}