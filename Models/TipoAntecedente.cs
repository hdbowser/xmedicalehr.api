using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class TipoAntecedente
    {
        public TipoAntecedente()
        {
            AntecedentesPacientes = new HashSet<AntecedentePaciente>();
        }
        
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string GrupoId { get; set; }

        // Navigations
        public virtual GrupoAntecedente Grupo { get; set; }
        public virtual ICollection<AntecedentePaciente> AntecedentesPacientes { get; set; }
    }
}