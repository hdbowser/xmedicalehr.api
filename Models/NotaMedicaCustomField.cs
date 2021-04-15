namespace xmedical_ehr.Models {
    public class NotaMedicaCustomField {
        public string NotaMedicaId { get; set; }
        public int NumItem { get; set; }
        public string Titulo { get; set; }
        public string Valor { get; set; }

        // Navigations
        public virtual NotaMedica NotaMedica { get; set; }
    }
}