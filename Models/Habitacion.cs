using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class Habitacion
    {
        public Habitacion()
        {
            Camas = new HashSet<Cama>();
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //    Navigations
        public virtual ICollection<Cama> Camas { get; set; }

    }
}