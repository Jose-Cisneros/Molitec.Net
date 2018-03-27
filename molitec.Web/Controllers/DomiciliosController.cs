using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using molitec.Data;
using molitec.Data.Models;

namespace molitec.Web.Controllers
{
    public class DomiciliosController : Controller
    {
        private readonly CdpContext _context;

        public DomiciliosController(CdpContext context)
        {
            _context = context;    
        }

        // GET: Domicilios
        public async Task<IActionResult> Index()
        {
            var cdpContext = _context.Domicilio.Include(d => d.Localidad);
            return View(await cdpContext.ToListAsync());
        }

        // GET: Domicilios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domicilio = await _context.Domicilio
                .Include(d => d.Localidad)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (domicilio == null)
            {
                return NotFound();
            }

            return View(domicilio);
        }

        // GET: Domicilios/Create
        public IActionResult Create()
        {
            ViewData["LocalidadId"] = new SelectList(_context.Localidad, "Id", "Id");
            return View();
        }

        // POST: Domicilios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Calle,Numero,Piso,Depto,Fiscal,LocalidadId")] Domicilio domicilio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domicilio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidad, "Id", "Id", domicilio.LocalidadId);
            return View(domicilio);
        }

        // GET: Domicilios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domicilio = await _context.Domicilio.SingleOrDefaultAsync(m => m.Id == id);
            if (domicilio == null)
            {
                return NotFound();
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidad, "Id", "Id", domicilio.LocalidadId);
            return View(domicilio);
        }

        // POST: Domicilios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Calle,Numero,Piso,Depto,Fiscal,LocalidadId")] Domicilio domicilio)
        {
            if (id != domicilio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domicilio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomicilioExists(domicilio.Id))
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
            ViewData["LocalidadId"] = new SelectList(_context.Localidad, "Id", "Id", domicilio.LocalidadId);
            return View(domicilio);
        }

        // GET: Domicilios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domicilio = await _context.Domicilio
                .Include(d => d.Localidad)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (domicilio == null)
            {
                return NotFound();
            }

            return View(domicilio);
        }

        // POST: Domicilios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domicilio = await _context.Domicilio.SingleOrDefaultAsync(m => m.Id == id);
            _context.Domicilio.Remove(domicilio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DomicilioExists(int id)
        {
            return _context.Domicilio.Any(e => e.Id == id);
        }
    }
}
