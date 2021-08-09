using System.Collections.Generic;

namespace xmedicalehr.api.Models
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