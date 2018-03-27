using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class CartaDePorte
    {
        public int Id { get; set; }
        public int? Bruto { get; set; }
        public DateTime? FechaEmi { get; set; }
        public DateTime? FechaVenci { get; set; }
        public int? Neto { get; set; }
        public int? Numero { get; set; }
        public bool PesoEnDestino { get; set; }
        public float? KgsEstimado { get; set; }
        public float? Tara { get; set; }
        public bool Aceptada { get; set; }
        public DateTime? Cosecha { get; set; }
        public string Observaciones { get; set; }
        public string PatenteCamion { get; set; }
        public string PatenteAcoplado { get; set; }
        public int? Cee { get; set; }
        public int? Ctg { get; set; }
        public float? Tarifa { get; set; }
        public bool FletePagado { get; set; }
        public bool Conforme { get; set; }
        public bool Condicional { get; set; }
        public bool DeclaracionCalidad { get; set; }
        public float? KmArecorrer { get; set; }
        public int? DescargaId { get; set; }
        public int ContratoCompraId { get; set; }
        public int? SiloId { get; set; }
        public int? MuestraId { get; set; }
        public int GranoId { get; set; }
        public int? SolicitudId { get; set; }
        public int ChoferId { get; set; }
        public int TransporteId { get; set; }
        public int RemitenteId { get; set; }
        public int OrigenId { get; set; }
        public int DestinoId { get; set; }
        public int? TipoCartaId { get; set; }
        public DateTime FArribo { get; set; }
        public DateTime FDescarga { get; set; }
        public int Turno { get; set; }
        public DateTime HoraDescarga { get; set; }
        public DateTime HoraArribo { get; set; }
        public int BrutoFinal { get; set; }
        public int NetoFinal { get; set; }
        public int TaraFinal { get; set; }
  

        public virtual Persona Chofer { get; set; }
        public virtual ContratoCompra ContratoCompra { get; set; }
        public virtual Descarga Descarga { get; set; }
        public virtual Domicilio Destino { get; set; }
        public virtual Grano Grano { get; set; }
        public virtual Muestra Muestra { get; set; }
        public virtual Domicilio Origen { get; set; }
        public virtual Persona Remitente { get; set; }
        public virtual Silo Silo { get; set; }
        public virtual Solicitud Solicitud { get; set; }
        public virtual TipoCarta TipoCarta { get; set; }
        public virtual Persona Transporte { get; set; }
    }
}
