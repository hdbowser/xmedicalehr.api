using System;

namespace xmedicalehr.api.Core.FilterClass
{
    public class DiagnosticoFilter
    {
        public DiagnosticoFilter()
        {
            Busqueda = string.Empty;
            CreatedAt = null;
            UpdatedAt = null;
            DeletedAt = null;
        }
        
        public string NotaMedicaId { get; set; }
        public string EnfemeraId { get; set; }
        public string EnfermedadId { get; set; }
        public string Busqueda { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}