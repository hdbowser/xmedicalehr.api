using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Aseguradora
    {
        public Aseguradora()
        {
            Pacientes = new HashSet<Paciente>();
            Atenciones = new HashSet<AtencionMedica>();
        }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoInt { get; set; }

        // Navigations
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }
    }
}