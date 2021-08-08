using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class Provincia
    {
        public Provincia()
        {
            Pacientes = new HashSet<Paciente>();
        }
        
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoInt { get; set; }

        // Navigations
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}