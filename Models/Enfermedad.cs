using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Enfermedad
    {
        public Enfermedad()
        {
            Diagnosticos = new HashSet<Diagnostico>();
        }
        public string Id { get; set; }
        public string Catalogo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Keywords { get; set; }

        // Vavigations
        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}