using System.Collections.Generic;

namespace xmedical_ehr.Models
{
    public class Sustancia
    {
        public Sustancia()
        {
            Alergias = new HashSet<AlergiaPaciente>();
        }
        
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Navigations
        public ICollection<AlergiaPaciente> Alergias { get; set; }
    }
}