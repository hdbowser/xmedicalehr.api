using System;
using System.Collections.Generic;

namespace xmedical_ehr.Models {
    public class TipoNotaMedica{
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //Navigations
        public virtual ICollection<NotaMedica> NotasMedicas { get; set; }
    }
}