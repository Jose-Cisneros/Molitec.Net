using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Muestra
    {
        public Muestra()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
            CondicionMuestra = new HashSet<CondicionMuestra>();
        }

        public int Id { get; set; }
        public int? Num { get; set; }
        public DateTime? Fecha { get; set; }
        public int ResultadoAnalisisId { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
        public virtual ICollection<CondicionMuestra> CondicionMuestra { get; set; }
        public virtual ResultadoAnalisis ResultadoAnalisis { get; set; }
    }
}
