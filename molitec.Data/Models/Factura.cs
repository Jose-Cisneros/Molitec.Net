using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Factura
    {
        public Factura()
        {
            ConceptoDetalle = new HashSet<ConceptoDetalle>();
            ContratoCompraLiquidacionFinal = new HashSet<ContratoCompra>();
            ContratoCompraLiquidacionParcial = new HashSet<ContratoCompra>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public byte? Liquidacionfinal { get; set; }
        public float? Total { get; set; }
        public int? Numero { get; set; }
        public string Facturacol { get; set; }
        public int OrdenDePagoId { get; set; }
        public int ProductorId { get; set; }
        public int CondventasId { get; set; }

        public virtual ICollection<ConceptoDetalle> ConceptoDetalle { get; set; }
        public virtual ICollection<ContratoCompra> ContratoCompraLiquidacionFinal { get; set; }
        public virtual ICollection<ContratoCompra> ContratoCompraLiquidacionParcial { get; set; }
        public virtual Condventas Condventas { get; set; }
        public virtual OrdenDePago OrdenDePago { get; set; }
        public virtual Productor Productor { get; set; }
    }
}
