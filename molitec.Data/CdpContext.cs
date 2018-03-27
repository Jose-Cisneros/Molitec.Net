using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using molitec.Data.Models;

namespace molitec.Data
{
    public partial class CdpContext : DbContext
    {
        public virtual DbSet<AuthGroup> AuthGroup { get; set; }
        public virtual DbSet<AuthGroupPermissions> AuthGroupPermissions { get; set; }
        public virtual DbSet<AuthPermission> AuthPermission { get; set; }
        public virtual DbSet<AuthUser> AuthUser { get; set; }
        public virtual DbSet<AuthUserGroups> AuthUserGroups { get; set; }
        public virtual DbSet<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
        public virtual DbSet<CalidadGrano> CalidadGrano { get; set; }
        public virtual DbSet<CartaDePorte> CartaDePorte { get; set; }
        public virtual DbSet<Cheque> Cheque { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<ConceptoDetalle> ConceptoDetalle { get; set; }
        public virtual DbSet<Condicion> Condicion { get; set; }
        public virtual DbSet<CondicionDetalle> CondicionDetalle { get; set; }
        public virtual DbSet<CondicionMuestra> CondicionMuestra { get; set; }
        public virtual DbSet<CondicionSolicitud> CondicionSolicitud { get; set; }
        public virtual DbSet<Condventas> Condventas { get; set; }
        public virtual DbSet<ContratoCompra> ContratoCompra { get; set; }
        public virtual DbSet<Descarga> Descarga { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<EstadoCartaPorte> EstadoCartaPorte { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Grano> Grano { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Muestra> Muestra { get; set; }
        public virtual DbSet<OrdenDePago> OrdenDePago { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Productor> Productor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<ResultadoAnalisis> ResultadoAnalisis { get; set; }
        public virtual DbSet<Silo> Silo { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<TipoCarta> TipoCarta { get; set; }
        public virtual DbSet<TipoGrano> TipoGrano { get; set; }
        public virtual DbSet<UnidadCantidadGrano> UnidadCantidadGrano { get; set; }


        public CdpContext(DbContextOptions<CdpContext> options) : base(options)
        {
   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group", "emtargc1_diseno");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(80)")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<AuthGroupPermissions>(entity =>
            {
                entity.ToTable("auth_group_permissions", "emtargc1_diseno");

                entity.HasIndex(e => e.GroupId)
                    .HasName("auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("auth_group_permissions_permission_id_84c5c92e");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId })
                    .HasName("auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission", "emtargc1_diseno");

                entity.HasIndex(e => e.ContentTypeId)
                    .HasName("auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename })
                    .HasName("auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasColumnName("codename")
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100);

                entity.Property(e => e.ContentTypeId)
                    .HasColumnName("content_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user", "emtargc1_diseno");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateJoined)
                    .HasColumnName("date_joined")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(254)")
                    .HasMaxLength(254);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(30)")
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsStaff)
                    .HasColumnName("is_staff")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsSuperuser)
                    .HasColumnName("is_superuser")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(30)")
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(128)")
                    .HasMaxLength(128);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(150)")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AuthUserGroups>(entity =>
            {
                entity.ToTable("auth_user_groups", "emtargc1_diseno");

                entity.HasIndex(e => e.GroupId)
                    .HasName("auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.UserId)
                    .HasName("auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.UserId, e.GroupId })
                    .HasName("auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AuthUserUserPermissions>(entity =>
            {
                entity.ToTable("auth_user_user_permissions", "emtargc1_diseno");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.UserId)
                    .HasName("auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.UserId, e.PermissionId })
                    .HasName("auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CalidadGrano>(entity =>
            {
                entity.ToTable("calidadGrano", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<CartaDePorte>(entity =>
            {
                entity.ToTable("cartaDePorte", "emtargc1_diseno");

                entity.HasIndex(e => e.ChoferId)
                    .HasName("fk_cartaDePorte_persona1_idx");

                entity.HasIndex(e => e.ContratoCompraId)
                    .HasName("fk_cartaDePorte_contratoCompra1_idx");

                entity.HasIndex(e => e.DescargaId)
                    .HasName("fk_cartaDePorte_descarga1_idx");

                entity.HasIndex(e => e.DestinoId)
                    .HasName("fk_cartaDePorte_domicilio1_idx");

                entity.HasIndex(e => e.GranoId)
                    .HasName("fk_cartaDePorte_grano1_idx");

                entity.HasIndex(e => e.MuestraId)
                    .HasName("fk_cartaDePorte_Muestra1_idx");

                entity.HasIndex(e => e.OrigenId)
                    .HasName("fk_cartaDePorte_domicilio2_idx");

                entity.HasIndex(e => e.RemitenteId)
                    .HasName("fk_cartaDePorte_persona2_idx");

                entity.HasIndex(e => e.SiloId)
                    .HasName("fk_cartaDePorte_silo1_idx");

                entity.HasIndex(e => e.SolicitudId)
                    .HasName("fk_cartaDePorte_solicitud1_idx");

                entity.HasIndex(e => e.TipoCartaId)
                    .HasName("fk_cartaDePorte_tipoCarta1_idx");

                entity.HasIndex(e => e.TransporteId)
                    .HasName("fk_cartaDePorte_persona3_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aceptada)
                    .HasColumnName("aceptada")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Bruto)
                    .HasColumnName("bruto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cee)
                    .HasColumnName("cee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChoferId)
                    .HasColumnName("chofer_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Condicional)
                    .HasColumnName("condicional")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Conforme)
                    .HasColumnName("conforme")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ContratoCompraId)
                    .HasColumnName("contratoCompra_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cosecha)
                    .HasColumnName("cosecha")
                    .HasColumnType("date");

                entity.Property(e => e.Ctg)
                    .HasColumnName("ctg")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeclaracionCalidad)
                    .HasColumnName("declaracionCalidad")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.DescargaId)
                    .HasColumnName("descarga_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DestinoId)
                    .HasColumnName("destino_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaEmi)
                    .HasColumnName("fechaEmi")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVenci)
                    .HasColumnName("fechaVenci")
                    .HasColumnType("date");

                entity.Property(e => e.FletePagado)
                    .HasColumnName("fletePagado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.GranoId)
                    .HasColumnName("grano_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KgsEstimado).HasColumnName("kgsEstimado");

                entity.Property(e => e.KmArecorrer).HasColumnName("kmARecorrer");

                entity.Property(e => e.MuestraId)
                    .HasColumnName("Muestra_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Neto)
                    .HasColumnName("neto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.OrigenId)
                    .HasColumnName("origen_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PatenteAcoplado)
                    .HasColumnName("patenteAcoplado")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.PatenteCamion)
                    .HasColumnName("patenteCamion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.PesoEnDestino)
                    .HasColumnName("pesoEnDestino")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RemitenteId)
                    .HasColumnName("remitente_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SiloId)
                    .HasColumnName("silo_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SolicitudId)
                    .HasColumnName("solicitud_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.Tarifa).HasColumnName("tarifa");

                entity.Property(e => e.TipoCartaId)
                    .HasColumnName("tipoCarta_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TransporteId)
                    .HasColumnName("transporte_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FArribo)
                    .HasColumnName("fArribo")
                    .HasColumnType("date");

                entity.Property(e => e.FDescarga)
                    .HasColumnName("fDescarga")
                    .HasColumnType("date");

                entity.Property(e => e.HoraArribo)
                    .HasColumnName("horaArribo")
                    .HasColumnType("time");

                entity.Property(e => e.HoraDescarga)
                    .HasColumnName("horaDescarga")
                    .HasColumnType("time");
                entity.Property(e => e.BrutoFinal)
                    .HasColumnName("brutoFinal")
                    .HasColumnType("int(11)");
                entity.Property(e => e.TaraFinal)
                    .HasColumnName("TaraFinal")
                    .HasColumnType("int(11)");
                entity.Property(e => e.NetoFinal)
                    .HasColumnName("NetoFinal")
                    .HasColumnType("int(11)");
                entity.Property(e => e.Turno)
                  .HasColumnName("turno")
                  .HasColumnType("int(11)");



                entity.HasOne(d => d.Chofer)
                    .WithMany(p => p.CartaDePorteChofer)
                    .HasForeignKey(d => d.ChoferId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_persona1");

                entity.HasOne(d => d.ContratoCompra)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.ContratoCompraId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_contratoCompra1");

                entity.HasOne(d => d.Descarga)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.DescargaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_descarga1");

                entity.HasOne(d => d.Destino)
                    .WithMany(p => p.CartaDePorteDestino)
                    .HasForeignKey(d => d.DestinoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_domicilio1");

                entity.HasOne(d => d.Grano)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.GranoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_grano1");

                entity.HasOne(d => d.Muestra)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.MuestraId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_Muestra1");

                entity.HasOne(d => d.Origen)
                    .WithMany(p => p.CartaDePorteOrigen)
                    .HasForeignKey(d => d.OrigenId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_domicilio2");

                entity.HasOne(d => d.Remitente)
                    .WithMany(p => p.CartaDePorteRemitente)
                    .HasForeignKey(d => d.RemitenteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_persona2");

                entity.HasOne(d => d.Silo)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.SiloId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_silo1");

                entity.HasOne(d => d.Solicitud)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.SolicitudId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_solicitud1");

                entity.HasOne(d => d.TipoCarta)
                    .WithMany(p => p.CartaDePorte)
                    .HasForeignKey(d => d.TipoCartaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_tipoCarta1");

                entity.HasOne(d => d.Transporte)
                    .WithMany(p => p.CartaDePorteTransporte)
                    .HasForeignKey(d => d.TransporteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cartaDePorte_persona3");
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.ToTable("cheque", "emtargc1_diseno");

                entity.HasIndex(e => e.OrdenDePagoId)
                    .HasName("fk_cheque_ordenDePago1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenDePagoId)
                    .HasColumnName("ordenDePago_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.OrdenDePago)
                    .WithMany(p => p.Cheque)
                    .HasForeignKey(d => d.OrdenDePagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_cheque_ordenDePago1");
            });

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.ToTable("concepto", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cant)
                    .HasColumnName("cant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<ConceptoDetalle>(entity =>
            {
                entity.ToTable("conceptoDetalle", "emtargc1_diseno");

                entity.HasIndex(e => e.ConceptoId)
                    .HasName("fk_conceptoDetalle_concepto1_idx");

                entity.HasIndex(e => e.FacturaId)
                    .HasName("fk_conceptoDetalle_factura1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cant)
                    .HasColumnName("cant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConceptoId)
                    .HasColumnName("concepto_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FacturaId)
                    .HasColumnName("factura_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.Concepto)
                    .WithMany(p => p.ConceptoDetalle)
                    .HasForeignKey(d => d.ConceptoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_conceptoDetalle_concepto1");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.ConceptoDetalle)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_conceptoDetalle_factura1");
            });

            modelBuilder.Entity<Condicion>(entity =>
            {
                entity.ToTable("condicion", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Unidad)
                    .HasColumnName("unidad")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<CondicionDetalle>(entity =>
            {
                entity.ToTable("condicionDetalle", "emtargc1_diseno");

                entity.HasIndex(e => e.CondicionId)
                    .HasName("fk_condicionDetalle_condicion1_idx");

                entity.HasIndex(e => e.ContratoCompraId)
                    .HasName("fk_condicionDetalle_contratoCompra1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CondicionId)
                    .HasColumnName("condicion_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContratoCompraId)
                    .HasColumnName("contratoCompra_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Condicion)
                    .WithMany(p => p.CondicionDetalle)
                    .HasForeignKey(d => d.CondicionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionDetalle_condicion1");

                entity.HasOne(d => d.ContratoCompra)
                    .WithMany(p => p.CondicionDetalle)
                    .HasForeignKey(d => d.ContratoCompraId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionDetalle_contratoCompra1");
            });

            modelBuilder.Entity<CondicionMuestra>(entity =>
            {
                entity.ToTable("condicionMuestra", "emtargc1_diseno");

                entity.HasIndex(e => e.CondicionId)
                    .HasName("fk_condicionMuestra_condicion1_idx");

                entity.HasIndex(e => e.MuestraId)
                    .HasName("fk_condicionMuestra_Muestra1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CondicionId)
                    .HasColumnName("condicion_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MuestraId)
                    .HasColumnName("Muestra_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Unidad)
                    .HasColumnName("unidad")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.HasOne(d => d.Condicion)
                    .WithMany(p => p.CondicionMuestra)
                    .HasForeignKey(d => d.CondicionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionMuestra_condicion1");

                entity.HasOne(d => d.Muestra)
                    .WithMany(p => p.CondicionMuestra)
                    .HasForeignKey(d => d.MuestraId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionMuestra_Muestra1");
            });

            modelBuilder.Entity<CondicionSolicitud>(entity =>
            {
                entity.ToTable("condicionSolicitud", "emtargc1_diseno");

                entity.HasIndex(e => e.CondicionId)
                    .HasName("fk_condicionSolicitud_condicion1_idx");

                entity.HasIndex(e => e.SolicitudId)
                    .HasName("fk_condicionSolicitud_solicitud1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.CondicionId)
                    .HasColumnName("condicion_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SolicitudId)
                    .HasColumnName("solicitud_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Condicion)
                    .WithMany(p => p.CondicionSolicitud)
                    .HasForeignKey(d => d.CondicionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionSolicitud_condicion1");

                entity.HasOne(d => d.Solicitud)
                    .WithMany(p => p.CondicionSolicitud)
                    .HasForeignKey(d => d.SolicitudId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_condicionSolicitud_solicitud1");
            });

            modelBuilder.Entity<Condventas>(entity =>
            {
                entity.ToTable("condventas", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<ContratoCompra>(entity =>
            {
                entity.ToTable("contratoCompra", "emtargc1_diseno");

                entity.HasIndex(e => e.EstadoCartaPorteId)
                    .HasName("fk_contratoCompra_estadoCartaPorte1_idx");

                entity.HasIndex(e => e.LiquidacionFinalId)
                    .HasName("fk_contratoCompra_factura2_idx");

                entity.HasIndex(e => e.LiquidacionParcialId)
                    .HasName("fk_contratoCompra_factura1_idx");

                entity.HasIndex(e => e.ProductorId)
                    .HasName("fk_contratoCompra_productor1_idx");

                entity.HasIndex(e => e.UnidadCantidadGranoId)
                    .HasName("fk_contratoCompra_cantidadGrano1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstadoCartaPorteId)
                    .HasColumnName("estadoCartaPorte_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaLimite)
                    .HasColumnName("fechaLimite")
                    .HasColumnType("date");

                entity.Property(e => e.LiquidacionFinalId)
                    .HasColumnName("liquidacionFinal_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LiquidacionParcialId)
                    .HasColumnName("liquidacionParcial_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.ProductorId)
                    .HasColumnName("productor_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Toneladas).HasColumnName("toneladas");

                entity.Property(e => e.UnidadCantidadGranoId)
                    .HasColumnName("unidadCantidadGrano_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.EstadoCartaPorte)
                    .WithMany(p => p.ContratoCompra)
                    .HasForeignKey(d => d.EstadoCartaPorteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_contratoCompra_estadoCartaPorte1");

                entity.HasOne(d => d.LiquidacionFinal)
                    .WithMany(p => p.ContratoCompraLiquidacionFinal)
                    .HasForeignKey(d => d.LiquidacionFinalId)
                    .HasConstraintName("fk_contratoCompra_factura2");

                entity.HasOne(d => d.LiquidacionParcial)
                    .WithMany(p => p.ContratoCompraLiquidacionParcial)
                    .HasForeignKey(d => d.LiquidacionParcialId)
                    .HasConstraintName("fk_contratoCompra_factura1");

                entity.HasOne(d => d.Productor)
                    .WithMany(p => p.ContratoCompra)
                    .HasForeignKey(d => d.ProductorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_contratoCompra_productor1");

                entity.HasOne(d => d.UnidadCantidadGrano)
                    .WithMany(p => p.ContratoCompra)
                    .HasForeignKey(d => d.UnidadCantidadGranoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_contratoCompra_cantidadGrano1");
            });

            modelBuilder.Entity<Descarga>(entity =>
            {
                entity.ToTable("descarga", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bruto).HasColumnName("bruto");

                entity.Property(e => e.FArribo)
                    .HasColumnName("fArribo")
                    .HasColumnType("date");

                entity.Property(e => e.FDescarga)
                    .HasColumnName("fDescarga")
                    .HasColumnType("date");

                entity.Property(e => e.HoraArribo)
                    .HasColumnName("horaArribo")
                    .HasColumnType("date");

                entity.Property(e => e.HoraDescarga)
                    .HasColumnName("horaDescarga")
                    .HasColumnType("date");

                entity.Property(e => e.Neto).HasColumnName("neto");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Tara).HasColumnName("tara");

                entity.Property(e => e.Turno)
                    .HasColumnName("turno")
                    .HasColumnType("int(11)");
            });

           

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.ToTable("domicilio", "emtargc1_diseno");

                entity.HasIndex(e => e.LocalidadId)
                    .HasName("fk_domicilio_localidad1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Depto)
                    .HasColumnName("depto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fiscal)
                    .HasColumnName("fiscal")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.LocalidadId)
                    .HasColumnName("localidad_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Piso)
                    .HasColumnName("piso")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Localidad)
                    .WithMany(p => p.Domicilio)
                    .HasForeignKey(d => d.LocalidadId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_domicilio_localidad1");
            });

            modelBuilder.Entity<EstadoCartaPorte>(entity =>
            {
                entity.ToTable("estadoCartaPorte", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("factura", "emtargc1_diseno");

                entity.HasIndex(e => e.CondventasId)
                    .HasName("fk_factura_condventas1_idx");

                entity.HasIndex(e => e.OrdenDePagoId)
                    .HasName("fk_factura_ordenDePago1_idx");

                entity.HasIndex(e => e.ProductorId)
                    .HasName("fk_factura_productor1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CondventasId)
                    .HasColumnName("condventas_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Facturacol)
                    .HasColumnName("facturacol")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Liquidacionfinal)
                    .HasColumnName("liquidacionfinal")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenDePagoId)
                    .HasColumnName("ordenDePago_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductorId)
                    .HasColumnName("productor_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Condventas)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.CondventasId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_factura_condventas1");

                entity.HasOne(d => d.OrdenDePago)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.OrdenDePagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_factura_ordenDePago1");

                entity.HasOne(d => d.Productor)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.ProductorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_factura_productor1");
            });

            modelBuilder.Entity<Grano>(entity =>
            {
                entity.ToTable("grano", "emtargc1_diseno");

                entity.HasIndex(e => e.TipoGranoId)
                    .HasName("fk_grano_tipoGrano1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iva).HasColumnName("iva");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.TipoGranoId)
                    .HasColumnName("tipoGrano_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TipoGrano)
                    .WithMany(p => p.Grano)
                    .HasForeignKey(d => d.TipoGranoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_grano_tipoGrano1");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.ToTable("localidad", "emtargc1_diseno");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("fk_localidad_provincia1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigoPostal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("provincia_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_localidad_provincia1");
            });

            modelBuilder.Entity<Muestra>(entity =>
            {
                entity.ToTable("Muestra", "emtargc1_diseno");

                entity.HasIndex(e => e.ResultadoAnalisisId)
                    .HasName("fk_Muestra_resultadoAnalisis1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResultadoAnalisisId)
                    .HasColumnName("resultadoAnalisis_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ResultadoAnalisis)
                    .WithMany(p => p.Muestra)
                    .HasForeignKey(d => d.ResultadoAnalisisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_Muestra_resultadoAnalisis1");
            });

            modelBuilder.Entity<OrdenDePago>(entity =>
            {
                entity.ToTable("ordenDePago", "emtargc1_diseno");

                entity.HasIndex(e => e.ProductorId)
                    .HasName("fk_ordenDePago_productor1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnName("importe");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductorId)
                    .HasColumnName("productor_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Productor)
                    .WithMany(p => p.OrdenDePago)
                    .HasForeignKey(d => d.ProductorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ordenDePago_productor1");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razonSocial")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Productor>(entity =>
            {
                entity.ToTable("productor", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CondIva)
                    .HasColumnName("condIVA")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razonSocial")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("provincia", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<ResultadoAnalisis>(entity =>
            {
                entity.ToTable("resultadoAnalisis", "emtargc1_diseno");

                entity.HasIndex(e => e.CalidadGranoId)
                    .HasName("fk_resultadoAnalisis_calidadGrano1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalidadGranoId)
                    .HasColumnName("calidadGrano_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.HasOne(d => d.CalidadGrano)
                    .WithMany(p => p.ResultadoAnalisis)
                    .HasForeignKey(d => d.CalidadGranoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_resultadoAnalisis_calidadGrano1");
            });

            modelBuilder.Entity<Silo>(entity =>
            {
                entity.ToTable("silo", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.ToTable("solicitud", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cant)
                    .HasColumnName("cant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TipoCarta>(entity =>
            {
                entity.ToTable("tipoCarta", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TipoGrano>(entity =>
            {
                entity.ToTable("tipoGrano", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<UnidadCantidadGrano>(entity =>
            {
                entity.ToTable("unidadCantidadGrano", "emtargc1_diseno");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasMaxLength(45);
            });
        }
    }
}