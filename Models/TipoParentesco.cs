using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class TipoParentesco
    {
        public TipoParentesco()
        {
            PacientesParentesco = new HashSet<PacienteParentesco>();
        }
        
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Navigantions
        public virtual ICollection<PacienteParentesco> PacientesParentesco { get; set; }
    }
}