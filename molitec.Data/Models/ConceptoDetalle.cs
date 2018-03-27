using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class ConceptoDetalle
    {
        public int Id { get; set; }
        public int? Cant { get; set; }
        public float? Precio { get; set; }
        public int FacturaId { get; set; }
        public int ConceptoId { get; set; }

        public virtual Concepto Concepto { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
