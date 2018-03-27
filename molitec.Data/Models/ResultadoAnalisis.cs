using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class ResultadoAnalisis
    {
        public ResultadoAnalisis()
        {
            Muestra = new HashSet<Muestra>();
        }

        public int Id { get; set; }
        public string Num { get; set; }
        public DateTime? Fecha { get; set; }
        public int CalidadGranoId { get; set; }

        public virtual ICollection<Muestra> Muestra { get; set; }
        public virtual CalidadGrano CalidadGrano { get; set; }
    }
}
