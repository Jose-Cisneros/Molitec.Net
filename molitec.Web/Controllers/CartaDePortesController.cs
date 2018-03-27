using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using molitec.Data.Models;
using molitec.Data;

namespace molitec.Web.Controllers
{
    public class CartaDePortesController : Controller
    {
        private readonly CdpContext _context;

        public CartaDePortesController(CdpContext context)
        {
            _context = context;    
        }

        // GET: CartaDePortes
        public async Task<IActionResult> Index()
        {
            var cdpContext = _context.CartaDePorte.Include(c => c.Chofer).Include(c => c.ContratoCompra).Include(c => c.Descarga).Include(c => c.Destino).Include(c => c.Grano).Include(c => c.Muestra).Include(c => c.Origen).Include(c => c.Remitente).Include(c => c.Silo).Include(c => c.Solicitud).Include(c => c.TipoCarta).Include(c => c.Transporte);
            return View(await cdpContext.ToListAsync());
        }

        public async Task<IActionResult> PorContrato(int? id)
        {
            var cdpContext = _context.CartaDePorte.Include(c => c.Chofer).Include(c => c.ContratoCompra).Include(c => c.Descarga).Include(c => c.Destino).Include(c => c.Grano).Include(c => c.Muestra).Include(c => c.Origen).Include(c => c.Remitente).Include(c => c.Silo).Include(c => c.Solicitud).Include(c => c.TipoCarta).Include(c => c.Transporte);
            var filtrados = cdpContext.Where(x => x.ContratoCompraId == id);
            return View(await filtrados.ToListAsync());
        }

        // GET: CartaDePortes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaDePorte = await _context.CartaDePorte
                .Include(c => c.Chofer)
                .Include(c => c.ContratoCompra)
                .Include(c => c.Descarga)
                .Include(c => c.Destino)
                .Include(c => c.Grano)
                .Include(c => c.Muestra)
                .Include(c => c.Origen)
                .Include(c => c.Remitente)
                .Include(c => c.Silo)
                .Include(c => c.Solicitud)
                .Include(c => c.TipoCarta)
                .Include(c => c.Transporte)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cartaDePorte == null)
            {
                return NotFound();
            }

            return View(cartaDePorte);
        }

        // GET: CartaDePortes/Create
        public IActionResult Create(int? id)
        {
            ViewData["ChoferId"] = new SelectList(_context.Persona, "Id", "RazonSocial",new SelectListItem { });
            ViewData["ContratoCompraId"] = new SelectList(_context.ContratoCompra, "Id", "Numero",id);
            ViewData["DescargaId"] = new SelectList(_context.Descarga, "Id", "Id");
            ViewData["DestinoId"] = new SelectList(_context.Domicilio, "Id", "Nombre");
            ViewData["GranoId"] = new SelectList(_context.Grano, "Id", "Nombre");
            ViewData["MuestraId"] = new SelectList(_context.Muestra, "Id", "Id");
            ViewData["OrigenId"] = new SelectList(_context.Domicilio, "Id", "Nombre");
            ViewData["RemitenteId"] = new SelectList(_context.Persona, "Id", "RazonSocial");
            ViewData["SiloId"] = new SelectList(_context.Silo, "Id", "Id");
            ViewData["SolicitudId"] = new SelectList(_context.Solicitud, "Id", "Id");
            ViewData["TipoCartaId"] = new SelectList(_context.TipoCarta, "Id", "Id");
            ViewData["TransporteId"] = new SelectList(_context.Persona, "Id", "RazonSocial");
            return View();
        }


        // POST: CartaDePortes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bruto,FechaEmi,FechaVenci,Neto,Numero,PesoEnDestino,KgsEstimado,Tara,Aceptada,Cosecha,Observaciones,PatenteCamion,PatenteAcoplado,Cee,Ctg,Tarifa,FletePagado,Conforme,Condicional,DeclaracionCalidad,KmArecorrer,DescargaId,ContratoCompraId,SiloId,MuestraId,GranoId,SolicitudId,ChoferId,TransporteId,RemitenteId,OrigenId,DestinoId,TipoCartaId,FArribo,FDescarga,Turno,HoraDescarga,HoraArribo,BrutoFinal,NetoFinal,TaraFinal")] CartaDePorte cartaDePorte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaDePorte);
                await _context.SaveChangesAsync();
                return RedirectToAction("PorContrato/" + cartaDePorte.ContratoCompraId.ToString());
                
            }
            ViewData["ChoferId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.ChoferId);
            ViewData["ContratoCompraId"] = new SelectList(_context.ContratoCompra, "Id", "Id", cartaDePorte.ContratoCompraId);
            ViewData["DescargaId"] = new SelectList(_context.Descarga, "Id", "Id", cartaDePorte.DescargaId);
            ViewData["DestinoId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.DestinoId);
            ViewData["GranoId"] = new SelectList(_context.Grano, "Id", "Id", cartaDePorte.GranoId);
            ViewData["MuestraId"] = new SelectList(_context.Muestra, "Id", "Id", cartaDePorte.MuestraId);
            ViewData["OrigenId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.OrigenId);
            ViewData["RemitenteId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.RemitenteId);
            ViewData["SiloId"] = new SelectList(_context.Silo, "Id", "Id", cartaDePorte.SiloId);
            ViewData["SolicitudId"] = new SelectList(_context.Solicitud, "Id", "Id", cartaDePorte.SolicitudId);
            ViewData["TipoCartaId"] = new SelectList(_context.TipoCarta, "Id", "Id", cartaDePorte.TipoCartaId);
            ViewData["TransporteId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.TransporteId);
            return View(cartaDePorte);
        }

        // GET: CartaDePortes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaDePorte = await _context.CartaDePorte.SingleOrDefaultAsync(m => m.Id == id);
            if (cartaDePorte == null)
            {
                return NotFound();
            }
            ViewData["ChoferId"] = new SelectList(_context.Persona, "Id", "RazonSocial", cartaDePorte.ChoferId);
            ViewData["ContratoCompraId"] = new SelectList(_context.ContratoCompra, "Id", "Numero", cartaDePorte.ContratoCompraId);
            ViewData["DescargaId"] = new SelectList(_context.Descarga, "Id", "Id", cartaDePorte.DescargaId);
            ViewData["DestinoId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.DestinoId);
            ViewData["GranoId"] = new SelectList(_context.Grano, "Id", "Nombre", cartaDePorte.GranoId);
            ViewData["MuestraId"] = new SelectList(_context.Muestra, "Id", "Id", cartaDePorte.MuestraId);
            ViewData["OrigenId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.OrigenId);
            ViewData["RemitenteId"] = new SelectList(_context.Persona, "Id", "RazonSocial", cartaDePorte.RemitenteId);
            ViewData["SiloId"] = new SelectList(_context.Silo, "Id", "Id", cartaDePorte.SiloId);
            ViewData["SolicitudId"] = new SelectList(_context.Solicitud, "Id", "Id", cartaDePorte.SolicitudId);
            ViewData["TipoCartaId"] = new SelectList(_context.TipoCarta, "Id", "Id", cartaDePorte.TipoCartaId);
            ViewData["TransporteId"] = new SelectList(_context.Persona, "Id", "RazonSocial", cartaDePorte.TransporteId);
            return View(cartaDePorte);
        }

        // POST: CartaDePortes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Bruto,FechaEmi,FechaVenci,Neto,Numero,PesoEnDestino,KgsEstimado,Tara,Aceptada,Cosecha,Observaciones,PatenteCamion,PatenteAcoplado,Cee,Ctg,Tarifa,FletePagado,Conforme,Condicional,DeclaracionCalidad,KmArecorrer,DescargaId,ContratoCompraId,SiloId,MuestraId,GranoId,SolicitudId,ChoferId,TransporteId,RemitenteId,OrigenId,DestinoId,TipoCartaId,FArribo,FDescarga,Turno,HoraDescarga,HoraArribo,BrutoFinal,NetoFinal,TaraFinal")] CartaDePorte cartaDePorte)
        {
            if (id != cartaDePorte.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaDePorte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaDePorteExists(cartaDePorte.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var a = cartaDePorte.ContratoCompraId.ToString();
                return RedirectToAction("PorContrato/"+a);
            }
            ViewData["ChoferId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.ChoferId);
            ViewData["ContratoCompraId"] = new SelectList(_context.ContratoCompra, "Id", "Id", cartaDePorte.ContratoCompraId);
            ViewData["DescargaId"] = new SelectList(_context.Descarga, "Id", "Id", cartaDePorte.DescargaId);
            ViewData["DestinoId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.DestinoId);
            ViewData["GranoId"] = new SelectList(_context.Grano, "Id", "Id", cartaDePorte.GranoId);
            ViewData["MuestraId"] = new SelectList(_context.Muestra, "Id", "Id", cartaDePorte.MuestraId);
            ViewData["OrigenId"] = new SelectList(_context.Domicilio, "Id", "Nombre", cartaDePorte.OrigenId);
            ViewData["RemitenteId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.RemitenteId);
            ViewData["SiloId"] = new SelectList(_context.Silo, "Id", "Id", cartaDePorte.SiloId);
            ViewData["SolicitudId"] = new SelectList(_context.Solicitud, "Id", "Id", cartaDePorte.SolicitudId);
            ViewData["TipoCartaId"] = new SelectList(_context.TipoCarta, "Id", "Id", cartaDePorte.TipoCartaId);
            ViewData["TransporteId"] = new SelectList(_context.Persona, "Id", "Id", cartaDePorte.TransporteId);
            return View(cartaDePorte);
        }

        // GET: CartaDePortes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaDePorte = await _context.CartaDePorte
                .Include(c => c.Chofer)
                .Include(c => c.ContratoCompra)
                .Include(c => c.Descarga)
                .Include(c => c.Destino)
                .Include(c => c.Grano)
                .Include(c => c.Muestra)
                .Include(c => c.Origen)
                .Include(c => c.Remitente)
                .Include(c => c.Silo)
                .Include(c => c.Solicitud)
                .Include(c => c.TipoCarta)
                .Include(c => c.Transporte)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cartaDePorte == null)
            {
                return NotFound();
            }

            return View(cartaDePorte);
        }

        // POST: CartaDePortes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaDePorte = await _context.CartaDePorte.SingleOrDefaultAsync(m => m.Id == id);
            _context.CartaDePorte.Remove(cartaDePorte);
            await _context.SaveChangesAsync();
            var a = cartaDePorte.ContratoCompraId.ToString();
            return RedirectToAction("PorContrato/" + a);
        }

        private bool CartaDePorteExists(int id)
        {
            return _context.CartaDePorte.Any(e => e.Id == id);
        }

        public ActionResult PersonaPartial(int id)
        {
    
            return PartialView(_context.Persona.First(x => x.Id == id));

        }

        public ActionResult GranoPartial(int id)
        {
            return PartialView(_context.Grano.First(x => x.Id == id));

        }

        public ActionResult DomicilioPartial(int id)
        {
            return PartialView(_context.Domicilio.First(x => x.Id == id));
        }
    }
}

