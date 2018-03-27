using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class TipoCarta
    {
        public TipoCarta()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
    }
}
