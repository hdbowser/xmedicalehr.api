using System;
namespace xmedical_ehr.Models {
    public class OrdenMedica {
        public string NotaMedicaId { get; set; }
        public int NumItem { get; set; }
        public string TipoId { get; set; }
        public string MedicamentoId { get; set; }
        public string Unidad { get; set; }
        public decimal Cantiad { get; set; }
        public string Via { get; set; }
        public int Intervalo { get; set; }
        public string Tiempo { get; set; }
        public bool Monodosis { get; set; }
        public int NumDiagnostico { get; set; }
        public int TiempoExpiracion { get; set; }
        public bool Suspendido { get; set; }
        public int EstudioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Instruccciones { get; set; }
        public string Comentario { get; set; }
        public int Deleted { get; set; }
        public DateTime CreatedAt { get; set; }

        //Navigations
        public virtual NotaMedica NotaMedica { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual Estudio Estudio { get; set; }
    }
}