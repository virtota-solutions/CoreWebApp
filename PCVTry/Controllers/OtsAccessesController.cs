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
    public class OtsAccessesController : Controller
    {
        private readonly MVCContext _context;

        public OtsAccessesController(MVCContext context)
        {
            _context = context;
        }

        // GET: OtsAccesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.OtsAccess.ToListAsync());
        }

        // GET: OtsAccesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otsAccess = await _context.OtsAccess
                .FirstOrDefaultAsync(m => m.OtsAccessId == id);
            if (otsAccess == null)
            {
                return NotFound();
            }

            return View(otsAccess);
        }

        // GET: OtsAccesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OtsAccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OtsAccessId,Return,MultiAssign,DeleteOrder,ToReassign,RecreateOrder,AppraisalTagShip,MaintainTagReasons,MaintainClariReasons,AuditAdmin,DisputeQueueAccess")] OtsAccess otsAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otsAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(otsAccess);
        }

        // GET: OtsAccesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otsAccess = await _context.OtsAccess.FindAsync(id);
            if (otsAccess == null)
            {
                return NotFound();
            }
            return View(otsAccess);
        }

        // POST: OtsAccesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OtsAccessId,Return,MultiAssign,DeleteOrder,ToReassign,RecreateOrder,AppraisalTagShip,MaintainTagReasons,MaintainClariReasons,AuditAdmin,DisputeQueueAccess")] OtsAccess otsAccess)
        {
            if (id != otsAccess.OtsAccessId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(otsAccess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtsAccessExists(otsAccess.OtsAccessId))
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
            return View(otsAccess);
        }

        // GET: OtsAccesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otsAccess = await _context.OtsAccess
                .FirstOrDefaultAsync(m => m.OtsAccessId == id);
            if (otsAccess == null)
            {
                return NotFound();
            }

            return View(otsAccess);
        }

        // POST: OtsAccesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otsAccess = await _context.OtsAccess.FindAsync(id);
            _context.OtsAccess.Remove(otsAccess);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OtsAccessExists(int id)
        {
            return _context.OtsAccess.Any(e => e.OtsAccessId == id);
        }
    }
}
