using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class TipoParentesco {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Navigantions
        public virtual ICollection<PacienteParentesco> PacientesParentescos { get; set; }
    }
}