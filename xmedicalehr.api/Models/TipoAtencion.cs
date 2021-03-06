using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class TipoAtencion
    {
        public TipoAtencion()
        {
            Atenciones = new HashSet<AtencionMedica>();
        }
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //Navigations
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }
    }
}