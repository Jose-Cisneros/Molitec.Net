using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Persona
    {
        public Persona()
        {
            CartaDePorteChofer = new HashSet<CartaDePorte>();
            CartaDePorteRemitente = new HashSet<CartaDePorte>();
            CartaDePorteTransporte = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public int? Cuit { get; set; }
        public string RazonSocial { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorteChofer { get; set; }
        public virtual ICollection<CartaDePorte> CartaDePorteRemitente { get; set; }
        public virtual ICollection<CartaDePorte> CartaDePorteTransporte { get; set; }
    }
}
