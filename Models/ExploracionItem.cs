namespace xmedical_ehr.Models
{
    public class ExploracionItem
    {
        public string NotaMedicaId { get; set; }
        public int ExploracionItemTemplateId { get; set; }
        public string Descripcion { get; set; }
        public bool Deleted { get; set; }

        // Navigations
        public virtual NotaMedica NotaMedica { get; set; }
        public virtual ExploracionItemTemplate ExploracionItemTemplate { get; set; }
    }
}