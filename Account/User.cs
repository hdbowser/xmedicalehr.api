using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Account
{
    public class User : IdentityUser
    {
        public User()
        {
            Atenciones = new HashSet<AtencionMedica>();
            AtencionesCreadas = new HashSet<AtencionMedica>();
            SolicitudesInterconsultas = new HashSet<SolicitudInterconsulta>();
            InterconsultasSolicitadas = new HashSet<SolicitudInterconsulta>();
            NotasMedicas = new HashSet<NotaMedica>();
            NotasEnfermeria = new HashSet<NotaEnfermeria>();
        }

        public string Name { get; set; }
        public string Prefix { get; set; }

        // Navigations
        public virtual ICollection<AtencionMedica> Atenciones { get; set; }
        public virtual ICollection<AtencionMedica> AtencionesCreadas { get; set; }
        public virtual ICollection<SolicitudInterconsulta> SolicitudesInterconsultas { get; set; }
        public virtual ICollection<SolicitudInterconsulta> InterconsultasSolicitadas { get; set; }
        public virtual ICollection<NotaMedica> NotasMedicas { get; set; }
        public virtual ICollection<NotaEnfermeria> NotasEnfermeria { get; set; }

    }
}