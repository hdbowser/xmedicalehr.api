using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class TipoAntecedente {
        public int Id { get; set; }
        public string Descricion { get; set; }
        public int GrupoId { get; set; }

        // Navigations
        public virtual GrupoAntecedente Grupo { get; set; }
        public virtual ICollection<AntecedentePaciente> AntecedentesPacientes { get; set; }
    }
}