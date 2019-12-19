using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WizaKonsulPLACOWKA.Data;
using WizaKonsulPLACOWKA.Models;

namespace WizaKonsulPLACOWKA.Controllers
{
    public class SprawasController : Controller
    {
        private readonly WizaKonsulPLACOWKAContext _context;

        public SprawasController(WizaKonsulPLACOWKAContext context)
        {
            _context = context;
        }

        // GET: Sprawas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sprawa.ToListAsync());
        }

        // GET: Sprawas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprawa = await _context.Sprawa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sprawa == null)
            {
                return NotFound();
            }

            return View(sprawa);
        }

        // GET: Sprawas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sprawas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tresc,ImieKlienta,NazwiskoKlienta,AdresKlienta,NrDokumentuKlienta,TypDokumentuKlienta,ZdjecieKlienta,Decyzja")] Sprawa sprawa)
        {
            if (ModelState.IsValid)
            {
                sprawa.Id = Guid.NewGuid();
                _context.Add(sprawa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sprawa);
        }

        // GET: Sprawas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprawa = await _context.Sprawa.FindAsync(id);
            if (sprawa == null)
            {
                return NotFound();
            }
            return View(sprawa);
        }

        // POST: Sprawas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tresc,ImieKlienta,NazwiskoKlienta,AdresKlienta,NrDokumentuKlienta,TypDokumentuKlienta,ZdjecieKlienta,Decyzja")] Sprawa sprawa)
        {
            if (id != sprawa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sprawa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SprawaExists(sprawa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sprawa);
        }

        // GET: Sprawas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprawa = await _context.Sprawa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sprawa == null)
            {
                return NotFound();
            }

            return View(sprawa);
        }

        // POST: Sprawas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sprawa = await _context.Sprawa.FindAsync(id);
            _context.Sprawa.Remove(sprawa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SprawaExists(Guid id)
        {
            return _context.Sprawa.Any(e => e.Id == id);
        }
    }
}
