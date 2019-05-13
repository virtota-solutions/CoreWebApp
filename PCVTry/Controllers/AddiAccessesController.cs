using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVTry.Models;

namespace PCVTry.Controllers
{
    public class AddiAccessesController : Controller
    {
        private readonly MVCContext _context;

        public AddiAccessesController(MVCContext context)
        {
            _context = context;
        }

        // GET: AddiAccesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.AddiAccess.ToListAsync());
        }

        // GET: AddiAccesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addiAccess = await _context.AddiAccess
                .FirstOrDefaultAsync(m => m.AddiAccessId == id);
            if (addiAccess == null)
            {
                return NotFound();
            }

            return View(addiAccess);
        }

        // GET: AddiAccesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddiAccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddiAccessId,Pci,Fdic,Crm,CopyOf")] AddiAccess addiAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addiAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addiAccess);
        }

        // GET: AddiAccesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addiAccess = await _context.AddiAccess.FindAsync(id);
            if (addiAccess == null)
            {
                return NotFound();
            }
            return View(addiAccess);
        }

        // POST: AddiAccesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddiAccessId,Pci,Fdic,Crm,CopyOf")] AddiAccess addiAccess)
        {
            if (id != addiAccess.AddiAccessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addiAccess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddiAccessExists(addiAccess.AddiAccessId))
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
            return View(addiAccess);
        }

        // GET: AddiAccesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addiAccess = await _context.AddiAccess
                .FirstOrDefaultAsync(m => m.AddiAccessId == id);
            if (addiAccess == null)
            {
                return NotFound();
            }

            return View(addiAccess);
        }

        // POST: AddiAccesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addiAccess = await _context.AddiAccess.FindAsync(id);
            _context.AddiAccess.Remove(addiAccess);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddiAccessExists(int id)
        {
            return _context.AddiAccess.Any(e => e.AddiAccessId == id);
        }
    }
}
