using System.Collections.Generic;

namespace xmedicalehr.api.Models
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