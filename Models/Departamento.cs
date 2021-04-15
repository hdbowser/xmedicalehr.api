using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Departamento {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Deleted { get; set; }

        // Navigations 
        public virtual ICollection<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
    }
}