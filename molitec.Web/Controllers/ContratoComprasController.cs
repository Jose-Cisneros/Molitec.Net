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
    public class ContratoComprasController : Controller
    {
        private readonly CdpContext _context;

        public ContratoComprasController(CdpContext context)
        {
            _context = context;    
        }

        // GET: ContratoCompras
        public async Task<IActionResult> Index()
        {
            var cdpContext = _context.ContratoCompra.Include(c => c.EstadoCartaPorte).Include(c => c.LiquidacionFinal).Include(c => c.LiquidacionParcial).Include(c => c.Productor).Include(c => c.UnidadCantidadGrano);
            return View(await cdpContext.ToListAsync());
        }

        // GET: ContratoCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratoCompra = await _context.ContratoCompra
                .Include(c => c.EstadoCartaPorte)
                .Include(c => c.LiquidacionFinal)
                .Include(c => c.LiquidacionParcial)
                .Include(c => c.Productor)
                .Include(c => c.UnidadCantidadGrano)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contratoCompra == null)
            {
                return NotFound();
            }

            return View(contratoCompra);
        }

        // GET: ContratoCompras/Create
        public IActionResult Create()
        {
            ViewData["EstadoCartaPorteId"] = new SelectList(_context.EstadoCartaPorte, "Id", "Id");
            ViewData["LiquidacionFinalId"] = new SelectList(_context.Factura, "Id", "Id");
            ViewData["LiquidacionParcialId"] = new SelectList(_context.Factura, "Id", "Id");
            ViewData["ProductorId"] = new SelectList(_context.Productor, "Id", "Id");
            ViewData["UnidadCantidadGranoId"] = new SelectList(_context.UnidadCantidadGrano, "Id", "Id");
            return View();
        }

        // POST: ContratoCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cantidad,Fecha,FechaLimite,Numero,Precio,Toneladas,ProductorId,UnidadCantidadGranoId,EstadoCartaPorteId,LiquidacionParcialId,LiquidacionFinalId")] ContratoCompra contratoCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contratoCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["EstadoCartaPorteId"] = new SelectList(_context.EstadoCartaPorte, "Id", "Id", contratoCompra.EstadoCartaPorteId);
            ViewData["LiquidacionFinalId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionFinalId);
            ViewData["LiquidacionParcialId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionParcialId);
            ViewData["ProductorId"] = new SelectList(_context.Productor, "Id", "Id", contratoCompra.ProductorId);
            ViewData["UnidadCantidadGranoId"] = new SelectList(_context.UnidadCantidadGrano, "Id", "Id", contratoCompra.UnidadCantidadGranoId);
            return View(contratoCompra);
        }

        // GET: ContratoCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratoCompra = await _context.ContratoCompra.SingleOrDefaultAsync(m => m.Id == id);
            if (contratoCompra == null)
            {
                return NotFound();
            }
            ViewData["EstadoCartaPorteId"] = new SelectList(_context.EstadoCartaPorte, "Id", "Id", contratoCompra.EstadoCartaPorteId);
            ViewData["LiquidacionFinalId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionFinalId);
            ViewData["LiquidacionParcialId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionParcialId);
            ViewData["ProductorId"] = new SelectList(_context.Productor, "Id", "Id", contratoCompra.ProductorId);
            ViewData["UnidadCantidadGranoId"] = new SelectList(_context.UnidadCantidadGrano, "Id", "Id", contratoCompra.UnidadCantidadGranoId);
            return View(contratoCompra);
        }

        // POST: ContratoCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cantidad,Fecha,FechaLimite,Numero,Precio,Toneladas,ProductorId,UnidadCantidadGranoId,EstadoCartaPorteId,LiquidacionParcialId,LiquidacionFinalId")] ContratoCompra contratoCompra)
        {
            if (id != contratoCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contratoCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContratoCompraExists(contratoCompra.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["EstadoCartaPorteId"] = new SelectList(_context.EstadoCartaPorte, "Id", "Id", contratoCompra.EstadoCartaPorteId);
            ViewData["LiquidacionFinalId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionFinalId);
            ViewData["LiquidacionParcialId"] = new SelectList(_context.Factura, "Id", "Id", contratoCompra.LiquidacionParcialId);
            ViewData["ProductorId"] = new SelectList(_context.Productor, "Id", "Id", contratoCompra.ProductorId);
            ViewData["UnidadCantidadGranoId"] = new SelectList(_context.UnidadCantidadGrano, "Id", "Id", contratoCompra.UnidadCantidadGranoId);
            return View(contratoCompra);
        }

        // GET: ContratoCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratoCompra = await _context.ContratoCompra
                .Include(c => c.EstadoCartaPorte)
                .Include(c => c.LiquidacionFinal)
                .Include(c => c.LiquidacionParcial)
                .Include(c => c.Productor)
                .Include(c => c.UnidadCantidadGrano)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contratoCompra == null)
            {
                return NotFound();
            }

            return View(contratoCompra);
        }

        // POST: ContratoCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contratoCompra = await _context.ContratoCompra.SingleOrDefaultAsync(m => m.Id == id);
            _context.ContratoCompra.Remove(contratoCompra);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ContratoCompraExists(int id)
        {
            return _context.ContratoCompra.Any(e => e.Id == id);
        }
    }
}
