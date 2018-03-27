using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class OrdenDePago
    {
        public OrdenDePago()
        {
            Cheque = new HashSet<Cheque>();
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public int? Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public float? Importe { get; set; }
        public int ProductorId { get; set; }

        public virtual ICollection<Cheque> Cheque { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual Productor Productor { get; set; }
    }
}
