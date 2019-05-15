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
    public class BpoRolegroupsController : Controller
    {
        private readonly MVCContext _context;

        public BpoRolegroupsController(MVCContext context)
        {
            _context = context;
        }

        // GET: BpoRolegroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.BpoRolegroup.ToListAsync());
        }

        // GET: BpoRolegroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bpoRolegroup = await _context.BpoRolegroup
                .FirstOrDefaultAsync(m => m.Bpoid == id);
            if (bpoRolegroup == null)
            {
                return NotFound();
            }

            return View(bpoRolegroup);
        }

        // GET: BpoRolegroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BpoRolegroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bpoid,Bpoadmin,ContractQc,FdicQc,HoldOrders,MarkOrdersShipped,QcBasic,QcPlus,QcSupervisor,ViewRules")] BpoRolegroup bpoRolegroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bpoRolegroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bpoRolegroup);
        }

        // GET: BpoRolegroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bpoRolegroup = await _context.BpoRolegroup.FindAsync(id);
            if (bpoRolegroup == null)
            {
                return NotFound();
            }
            return View(bpoRolegroup);
        }

        // POST: BpoRolegroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bpoid,Bpoadmin,ContractQc,FdicQc,HoldOrders,MarkOrdersShipped,QcBasic,QcPlus,QcSupervisor,ViewRules")] BpoRolegroup bpoRolegroup)
        {
            if (id != bpoRolegroup.Bpoid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bpoRolegroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BpoRolegroupExists(bpoRolegroup.Bpoid))
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
            return View(bpoRolegroup);
        }

        // GET: BpoRolegroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bpoRolegroup = await _context.BpoRolegroup
                .FirstOrDefaultAsync(m => m.Bpoid == id);
            if (bpoRolegroup == null)
            {
                return NotFound();
            }

            return View(bpoRolegroup);
        }

        // POST: BpoRolegroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bpoRolegroup = await _context.BpoRolegroup.FindAsync(id);
            _context.BpoRolegroup.Remove(bpoRolegroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BpoRolegroupExists(int id)
        {
            return _context.BpoRolegroup.Any(e => e.Bpoid == id);
        }
    }
}
