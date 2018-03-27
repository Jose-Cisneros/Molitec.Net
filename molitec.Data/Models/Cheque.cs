using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Cheque
    {
        public int Id { get; set; }
        public int? Numero { get; set; }
        public int? Monto { get; set; }
        public int OrdenDePagoId { get; set; }

        public virtual OrdenDePago OrdenDePago { get; set; }
    }
}
