using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class CondicionSolicitud
    {
        public int Id { get; set; }
        public string Cantidad { get; set; }
        public int CondicionId { get; set; }
        public int SolicitudId { get; set; }

        public virtual Condicion Condicion { get; set; }
        public virtual Solicitud Solicitud { get; set; }
    }
}
