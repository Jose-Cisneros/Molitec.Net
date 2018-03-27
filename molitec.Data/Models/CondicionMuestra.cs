using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class CondicionMuestra
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public string Unidad { get; set; }
        public int MuestraId { get; set; }
        public int CondicionId { get; set; }

        public virtual Condicion Condicion { get; set; }
        public virtual Muestra Muestra { get; set; }
    }
}
