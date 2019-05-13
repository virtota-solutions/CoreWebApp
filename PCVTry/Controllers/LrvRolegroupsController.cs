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
    public class LrvRolegroupsController : Controller
    {
        private readonly MVCContext _context;

        public LrvRolegroupsController(MVCContext context)
        {
            _context = context;
        }

        // GET: LrvRolegroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.LrvRolegroup.ToListAsync());
        }

        // GET: LrvRolegroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lrvRolegroup = await _context.LrvRolegroup
                .FirstOrDefaultAsync(m => m.LrvId == id);
            if (lrvRolegroup == null)
            {
                return NotFound();
            }

            return View(lrvRolegroup);
        }

        // GET: LrvRolegroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LrvRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LrvId,LrvAdmin,FannieQc,RegularQc,AllQueues")] LrvRolegroup lrvRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lrvRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lrvRolegroup);
        }

        // GET: LrvRolegroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lrvRolegroup = await _context.LrvRolegroup.FindAsync(id);
            if (lrvRolegroup == null)
            {
                return NotFound();
            }
            return View(lrvRolegroup);
        }

        // POST: LrvRolegroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LrvId,LrvAdmin,FannieQc,RegularQc,AllQueues")] LrvRolegroup lrvRolegroup)
        {
            if (id != lrvRolegroup.LrvId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lrvRolegroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LrvRolegroupExists(lrvRolegroup.LrvId))
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
            return View(lrvRolegroup);
        }

        // GET: LrvRolegroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lrvRolegroup = await _context.LrvRolegroup
                .FirstOrDefaultAsync(m => m.LrvId == id);
            if (lrvRolegroup == null)
            {
                return NotFound();
            }

            return View(lrvRolegroup);
        }

        // POST: LrvRolegroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lrvRolegroup = await _context.LrvRolegroup.FindAsync(id);
            _context.LrvRolegroup.Remove(lrvRolegroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LrvRolegroupExists(int id)
        {
            return _context.LrvRolegroup.Any(e => e.LrvId == id);
        }
    }
}
