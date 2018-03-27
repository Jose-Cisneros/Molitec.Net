using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class TipoGrano
    {
        public TipoGrano()
        {
            Grano = new HashSet<Grano>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Grano> Grano { get; set; }
    }
}
