using System;
namespace xmedicalehr.api.Models
{
    public class OrdenMedica
    {
        public string AntencionId { get; set; }
        public string NotaMedicaId { get; set; }
        public int NumItem { get; set; }
        public string Tipo { get; set; }
        public string MedicamentoId { get; set; }
        public string UnidadDosis { get; set; }
        public decimal CantidadDosis { get; set; }
        public string Via { get; set; }
        public int Intervalo { get; set; }
        public string Tiempo { get; set; }
        public bool Monodosis { get; set; }
        public int NumDiagnostico { get; set; }
        public int TiempoExpiracion { get; set; }
        public bool Suspendido { get; set; }
        public string EstudioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Instruccciones { get; set; }
        public string Comentario { get; set; }


        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }




        //Navigations
        public virtual AtencionMedica AntencionMedica { get; set; }
        public virtual NotaMedica NotaMedica { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual Estudio Estudio { get; set; }
    }
}