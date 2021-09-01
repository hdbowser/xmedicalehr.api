using System;

namespace xmedicalehr.api.Core.FilterClass
{
    public class AtencionFilter
    {
        public AtencionFilter()
        {
            Busqueda = string.Empty;
            CreatedAt = null;
            UpdatedAt = null;
            DeletedAt = null;
        }

        public string PacienteId { get; set; }
        public string Busqueda { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}