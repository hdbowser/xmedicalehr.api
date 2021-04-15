using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Nacionalidad {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string CodigoInt { get; set; }

        // Navigations
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}