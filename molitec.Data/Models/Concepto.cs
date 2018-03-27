using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Concepto
    {
        public Concepto()
        {
            ConceptoDetalle = new HashSet<ConceptoDetalle>();
        }

        public int Id { get; set; }
        public int? Cant { get; set; }
        public float? Precio { get; set; }

        public virtual ICollection<ConceptoDetalle> ConceptoDetalle { get; set; }
    }
}
