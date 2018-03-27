using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Domicilio
    {
        public Domicilio()
        {
            CartaDePorteDestino = new HashSet<CartaDePorte>();
            CartaDePorteOrigen = new HashSet<CartaDePorte>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public int? Piso { get; set; }
        public int? Depto { get; set; }
        public byte? Fiscal { get; set; }
        public int LocalidadId { get; set; }

        public virtual ICollection<CartaDePorte> CartaDePorteDestino { get; set; }
        public virtual ICollection<CartaDePorte> CartaDePorteOrigen { get; set; }
        public virtual Localidad Localidad { get; set; }
    }
}
