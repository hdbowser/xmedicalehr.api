using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class Cama {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int HabitacionId { get; set; }

        // Navigations
        public Habitacion Habitacion { get; set; }
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }

    }
}