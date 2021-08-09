using System;
using System.Collections.Generic;
using xmedicalehr.api.Account;

namespace xmedicalehr.api.Models
{
    public class NotaMedica
    {
        public NotaMedica()
        {
            OrdenesMedicas = new HashSet<OrdenMedica>();
            SignosVitales = new HashSet<SignosVitales>();
            ExploracionItems = new HashSet<ExploracionItem>();
            Diagnosticos = new HashSet<Diagnostico>();
            CustomFields = new HashSet<NotaMedicaCustomField>();
        }
        
        public string Id { get; set; }
        public string AtencionId { get; set; }
        public string MotivoConsulta { get; set; }
        public string HistoriaEnfermedad { get; set; }
        public string Nota { get; set; }
        public string TipoNotaId { get; set; }
        public bool DeOrden { get; set; }
        public string Dieta { get; set; }
        public string ExamenFisico { get; set; }
        public string Observaciones { get; set; }
        public string MedicoId { get; set; }
        public string MotivoEgreso { get; set; }
        public string Pronostico { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Peso { get; set; }
        public string UnidadPeso { get; set; }
        public int EscalaGlasgow { get; set; }
        public int EscalaDolor { get; set; }
        public int SaturacionOxigeno { get; set; }
        public string OtrosParametros { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }

        // Navitations
        public virtual AtencionMedica AtencionMedica { get; set; }
        public virtual TipoNotaMedica TipoNota { get; set; }
        public virtual User Medico { get; set; }
        
        public virtual ICollection<OrdenMedica> OrdenesMedicas { get; set; }
        public virtual ICollection<SignosVitales> SignosVitales { get; set; }
        public virtual ICollection<ExploracionItem> ExploracionItems { get; set; }
        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
        public virtual ICollection<NotaMedicaCustomField> CustomFields { get; set; }

    }
}