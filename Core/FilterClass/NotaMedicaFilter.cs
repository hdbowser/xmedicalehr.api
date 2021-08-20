using System;

namespace xmedicalehr.api.Core.FilterClass
{
    public class NotaMedicaFilter
    {
        public NotaMedicaFilter()
        {
            Busqueda = string.Empty;
            CreatedAt = null;
            UpdatedAt = null;
            DeletedAt = null;
        }

        public string AtencionId { get; set; }
        public string MedicoId { get; set; }
        public string TipoNotaId { get; set; }
        public string Busqueda { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}