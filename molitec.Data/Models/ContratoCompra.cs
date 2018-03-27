using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class ContratoCompra
    {
        public ContratoCompra()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
            CondicionDetalle = new HashSet<CondicionDetalle>();
        }

        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaLimite { get; set; }
        public int? Numero { get; set; }
        public float? Precio { get; set; }
        public float? Toneladas { get; set; }
        public int ProductorId { get; set; }
        public int UnidadCantidadGranoId { get; set; }
        public int EstadoCartaPorteId { get; set; }
        public int? LiquidacionParcialId { get; set; }
        public int? LiquidacionFinalId { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
        public virtual ICollection<CondicionDetalle> CondicionDetalle { get; set; }
        public virtual EstadoCartaPorte EstadoCartaPorte { get; set; }
        public virtual Factura LiquidacionFinal { get; set; }
        public virtual Factura LiquidacionParcial { get; set; }
        public virtual Productor Productor { get; set; }
        public virtual UnidadCantidadGrano UnidadCantidadGrano { get; set; }
    }
}
