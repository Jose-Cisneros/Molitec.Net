using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Condventas
    {
        public Condventas()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
