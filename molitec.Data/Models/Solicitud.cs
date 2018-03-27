using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Solicitud
    {
        public Solicitud()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
            CondicionSolicitud = new HashSet<CondicionSolicitud>();
        }

        public int Id { get; set; }
        public int? Cant { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Numero { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
        public virtual ICollection<CondicionSolicitud> CondicionSolicitud { get; set; }
    }
}
