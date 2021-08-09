using System;
namespace xmedicalehr.api.Models {
    public class Diagnostico {
        public string NotaMedicaId { get; set; }
        public int NumItem { get; set; }
        public string EnfermedadId { get; set; }
        public string Comentario { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }

        // Navigations
        public virtual NotaMedica NotaMedica { get; set; }
        public virtual Enfermedad Enfermedad { get; set; }
    }
}