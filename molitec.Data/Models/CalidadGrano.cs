using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class CalidadGrano
    {
        public CalidadGrano()
        {
            ResultadoAnalisis = new HashSet<ResultadoAnalisis>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ResultadoAnalisis> ResultadoAnalisis { get; set; }
    }
}
