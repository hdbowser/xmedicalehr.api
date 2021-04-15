using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class TipoAtencion {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //Navigations
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }
    }
}