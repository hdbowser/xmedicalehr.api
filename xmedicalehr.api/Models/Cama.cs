using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Cama
    {
        public Cama()
        {
            Atenciones = new HashSet<AtencionMedica>();
        }
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string HabitacionId { get; set; }

        // Navigations
        public Habitacion Habitacion { get; set; }
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }

    }
}