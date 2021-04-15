using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using xmedical_ehr.Models;

namespace xmedical_ehr.Account {
    public class User : IdentityUser {
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