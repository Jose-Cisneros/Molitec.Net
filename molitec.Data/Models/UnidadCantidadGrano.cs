﻿using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class UnidadCantidadGrano
    {
        public UnidadCantidadGrano()
        {
            ContratoCompra = new HashSet<ContratoCompra>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ContratoCompra> ContratoCompra { get; set; }
    }
}
