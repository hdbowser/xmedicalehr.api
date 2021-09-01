using System;
namespace xmedicalehr.api.Models
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
        public bool Deleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }


        // Navigation properties
        public virtual AtencionMedica AtencionMedica { get; set; }
        public virtual NotaEnfermeria NotaEnfermeria { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}