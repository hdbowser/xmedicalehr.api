using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class GrupoAntecedente
    {
        public GrupoAntecedente()
        {
            TiposAntecedentes = new HashSet<TipoAntecedente>();
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Navigations
        public virtual ICollection<TipoAntecedente> TiposAntecedentes { get; set; }
    }
}