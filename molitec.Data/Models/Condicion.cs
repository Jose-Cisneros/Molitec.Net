using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Condicion
    {
        public Condicion()
        {
            CondicionDetalle = new HashSet<CondicionDetalle>();
            CondicionMuestra = new HashSet<CondicionMuestra>();
            CondicionSolicitud = new HashSet<CondicionSolicitud>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }

        public virtual ICollection<CondicionDetalle> CondicionDetalle { get; set; }
        public virtual ICollection<CondicionMuestra> CondicionMuestra { get; set; }
        public virtual ICollection<CondicionSolicitud> CondicionSolicitud { get; set; }
    }
}
