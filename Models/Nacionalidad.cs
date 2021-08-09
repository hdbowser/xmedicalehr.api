using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Nacionalidad
    {
        public Nacionalidad()
        {
            Pacientes = new HashSet<Paciente>();
        }
        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string CodigoInt { get; set; }


        // Navigation properties
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}