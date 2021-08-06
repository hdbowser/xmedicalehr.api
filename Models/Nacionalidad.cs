using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class Nacionalidad
    {
        public Nacionalidad()
        {
            Pacientes = new HashSet<Paciente>();
        }
        
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string CodigoInt { get; set; }


        // Navigation properties
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}