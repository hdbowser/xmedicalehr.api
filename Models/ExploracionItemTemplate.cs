using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class ExploracionItemTemplate
    {
        public ExploracionItemTemplate()
        {
            ExploracionItems = new HashSet<ExploracionItem>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Navigations
        public virtual ICollection<ExploracionItem> ExploracionItems { get; set; }

    }
}