using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class Localidad
    {
        public Localidad()
        {
            Domicilio = new HashSet<Domicilio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? CodigoPostal { get; set; }
        public int ProvinciaId { get; set; }

        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
