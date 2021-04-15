using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class ExploracionItemTemplate {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Navigations
        public virtual ICollection<ExploracionItem> ExploracionItems { get; set; }

    }
}