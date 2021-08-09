using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class Departamento
    {
        public Departamento()
        {
            SolicitudesInterconsultas = new HashSet<SolicitudInterconsulta>();
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Deleted { get; set; }

        // Navigations 
        public virtual ICollection<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
    }
}