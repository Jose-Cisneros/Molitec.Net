using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class CondicionDetalle
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public int ContratoCompraId { get; set; }
        public int CondicionId { get; set; }

        public virtual Condicion Condicion { get; set; }
        public virtual ContratoCompra ContratoCompra { get; set; }
    }
}
