using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidad = new HashSet<Localidad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Localidad> Localidad { get; set; }
    }
}
