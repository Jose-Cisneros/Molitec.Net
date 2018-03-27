using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Productor
    {
        public Productor()
        {
            ContratoCompra = new HashSet<ContratoCompra>();
            Factura = new HashSet<Factura>();
            OrdenDePago = new HashSet<OrdenDePago>();
        }

        public int Id { get; set; }
        public string CondIva { get; set; }
        public int? Cuit { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }

        public virtual ICollection<ContratoCompra> ContratoCompra { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<OrdenDePago> OrdenDePago { get; set; }
    }
}
