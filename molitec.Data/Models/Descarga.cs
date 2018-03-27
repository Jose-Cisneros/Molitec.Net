using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Descarga
    {
        public Descarga()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public DateTime? FArribo { get; set; }
        public DateTime? FDescarga { get; set; }
        public int? Turno { get; set; }
        public DateTime? HoraDescarga { get; set; }
        public float? Bruto { get; set; }
        public float? Tara { get; set; }
        public float? Neto { get; set; }
        public DateTime? HoraArribo { get; set; }
        public string Observacion { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
    }
}
