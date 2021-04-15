using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class GrupoAntecedente {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Navigations
        public virtual ICollection<TipoAntecedente> TiposAntecedentes { get; set; }
    }
}