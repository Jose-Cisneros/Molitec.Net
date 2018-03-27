using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Grano
    {
        public Grano()
        {
            CartaDePorte = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public float? Iva { get; set; }
        public int TipoGranoId { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorte { get; set; }
        public virtual TipoGrano TipoGrano { get; set; }
    }
}
