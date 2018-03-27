using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Silo
    {
        public Silo()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Stock { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
    }
}
