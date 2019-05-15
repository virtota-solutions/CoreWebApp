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
    public class ApplicationaccessesController : Controller
    {
        private readonly MVCContext _context;

        public ApplicationaccessesController(MVCContext context)
        {
            _context = context;
        }

        // GET: Applicationaccesses
        public async Task<IActionResult> Index()
        {
            var mVCContext = _context.Applicationaccess.Include(a => a.AddAccessNavigation).Include(a => a.BporoleGroupNavigation).Include(a => a.LrvroleGroupNavigation).Include(a => a.OtsaccessNavigation).Include(a => a.VmsroleGroupNavigation);
            return View(await mVCContext.ToListAsync());
        }

        // GET: Applicationaccesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationaccess = await _context.Applicationaccess
                .Include(a => a.AddAccessNavigation)
                .Include(a => a.BporoleGroupNavigation)
                .Include(a => a.LrvroleGroupNavigation)
                .Include(a => a.OtsaccessNavigation)
                .Include(a => a.VmsroleGroupNavigation)
                .FirstOrDefaultAsync(m => m.AppId == id);
            if (applicationaccess == null)
            {
                return NotFound();
            }

            return View(applicationaccess);
        }

        // GET: Applicationaccesses/Create
        public IActionResult Create()
        {
            ViewData["AddAccess"] = new SelectList(_context.AddiAccess, "AddiAccessId", "AddiAccessId");
            ViewData["BporoleGroup"] = new SelectList(_context.BpoRolegroup, "Bpoid", "Bpoid");
            ViewData["LrvroleGroup"] = new SelectList(_context.LrvRolegroup, "LrvId", "LrvId");
            ViewData["Otsaccess"] = new SelectList(_context.OtsAccess, "OtsAccessId", "OtsAccessId");
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId");
            return View();
        }

        // POST: Applicationaccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppId,VmsroleGroup,AddAccess,Otsaccess,BporoleGroup,LrvroleGroup,Mas500Access")] Applicationaccess applicationaccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationaccess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddAccess"] = new SelectList(_context.AddiAccess, "AddiAccessId", "AddiAccessId", applicationaccess.AddAccess);
            ViewData["BporoleGroup"] = new SelectList(_context.BpoRolegroup, "Bpoid", "Bpoid", applicationaccess.BporoleGroup);
            ViewData["LrvroleGroup"] = new SelectList(_context.LrvRolegroup, "LrvId", "LrvId", applicationaccess.LrvroleGroup);
            ViewData["Otsaccess"] = new SelectList(_context.OtsAccess, "OtsAccessId", "OtsAccessId", applicationaccess.Otsaccess);
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId", applicationaccess.VmsroleGroup);
            return View(applicationaccess);
        }

        // GET: Applicationaccesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationaccess = await _context.Applicationaccess.FindAsync(id);
            if (applicationaccess == null)
            {
                return NotFound();
            }
            ViewData["AddAccess"] = new SelectList(_context.AddiAccess, "AddiAccessId", "AddiAccessId", applicationaccess.AddAccess);
            ViewData["BporoleGroup"] = new SelectList(_context.BpoRolegroup, "Bpoid", "Bpoid", applicationaccess.BporoleGroup);
            ViewData["LrvroleGroup"] = new SelectList(_context.LrvRolegroup, "LrvId", "LrvId", applicationaccess.LrvroleGroup);
            ViewData["Otsaccess"] = new SelectList(_context.OtsAccess, "OtsAccessId", "OtsAccessId", applicationaccess.Otsaccess);
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId", applicationaccess.VmsroleGroup);
            return View(applicationaccess);
        }

        // POST: Applicationaccesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppId,VmsroleGroup,AddAccess,Otsaccess,BporoleGroup,LrvroleGroup,Mas500Access")] Applicationaccess applicationaccess)
        {
            if (id != applicationaccess.AppId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationaccess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationaccessExists(applicationaccess.AppId))
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
            ViewData["AddAccess"] = new SelectList(_context.AddiAccess, "AddiAccessId", "AddiAccessId", applicationaccess.AddAccess);
            ViewData["BporoleGroup"] = new SelectList(_context.BpoRolegroup, "Bpoid", "Bpoid", applicationaccess.BporoleGroup);
            ViewData["LrvroleGroup"] = new SelectList(_context.LrvRolegroup, "LrvId", "LrvId", applicationaccess.LrvroleGroup);
            ViewData["Otsaccess"] = new SelectList(_context.OtsAccess, "OtsAccessId", "OtsAccessId", applicationaccess.Otsaccess);
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId", applicationaccess.VmsroleGroup);
            return View(applicationaccess);
        }

        // GET: Applicationaccesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationaccess = await _context.Applicationaccess
                .Include(a => a.AddAccessNavigation)
                .Include(a => a.BporoleGroupNavigation)
                .Include(a => a.LrvroleGroupNavigation)
                .Include(a => a.OtsaccessNavigation)
                .Include(a => a.VmsroleGroupNavigation)
                .FirstOrDefaultAsync(m => m.AppId == id);
            if (applicationaccess == null)
            {
                return NotFound();
            }

            return View(applicationaccess);
        }

        // POST: Applicationaccesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicationaccess = await _context.Applicationaccess.FindAsync(id);
            _context.Applicationaccess.Remove(applicationaccess);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationaccessExists(int id)
        {
            return _context.Applicationaccess.Any(e => e.AppId == id);
        }
    }
}
