using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Estudio
    {
        public Estudio()
        {
            OrdenesMedicas = new HashSet<OrdenMedica>();
        }
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }

        //Navigations
        public virtual ICollection<OrdenMedica> OrdenesMedicas { get; set; }
    }
}