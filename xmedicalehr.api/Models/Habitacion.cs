using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Habitacion
    {
        public Habitacion()
        {
            Camas = new HashSet<Cama>();
        }
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //    Navigations
        public virtual ICollection<Cama> Camas { get; set; }

    }
}