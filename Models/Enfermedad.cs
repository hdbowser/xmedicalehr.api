using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Enfermedad {
        public string Id { get; set; }
        public string Catalogo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Keywords { get; set; }

        // Vavigations
        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}