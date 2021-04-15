using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Estudio {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }

        //Navigations
        public virtual ICollection<OrdenMedica> OrdenesMedicas { get; set; }
    }
}