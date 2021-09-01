using System;
using System.Collections.Generic;

namespace xmedicalehr.api.Models
{
    public class TipoNotaMedica
    {
        public TipoNotaMedica()
        {
            NotasMedicas = new HashSet<NotaMedica>();
        }
        
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //Navigations
        public virtual ICollection<NotaMedica> NotasMedicas { get; set; }
    }
}