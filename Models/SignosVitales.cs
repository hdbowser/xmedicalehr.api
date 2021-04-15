using System;

namespace xmedical_ehr.Models {
    public class SignosVitales {
        public string AtencionId { get; set; }
        public int NumItem { get; set; }
        public string NotaMedicaId { get; set; }
        public string NotaEnfermeriaId { get; set; }
        public string Origen { get; set; }
        public decimal Temperatura { get; set; }
        public string UnidadTemperatura { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public int PresionSistolica { get; set; }
        public int PresionDisatolica { get; set; }
        public decimal Diuresis { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }

        // Navigations
        public virtual AtencionMedica Atencion { get; set; }
        public virtual NotaMedica NotaMedica { get; set; }
        public virtual NotaEnfermeria NotaEnfermeria { get; set; }
    }
}