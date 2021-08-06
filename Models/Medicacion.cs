using System;
namespace xmedical_ehr.Models
{
    public class Medicacion
    {
        public string AtencionId { get; set; }
        public int NumItem { get; set; }
        public string NotaEnfermeriaId { get; set; }
        public string MedicamentoId { get; set; }
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Via { get; set; }
        public string Comentario { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Deleted { get; set; }
        public DateTime DeletedAt { get; set; }


        // Navigation properties
        public virtual AtencionMedica AtencionMedica { get; set; }
        public virtual NotaEnfermeria NotaEnfermeria { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}