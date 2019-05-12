using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCVMurcorWebApp.Models;

namespace PCVMurcorWebApp.Controllers
{
    public class ApplicationaccessesController : Controller
    {
        private readonly VirtotaSolutionsContext _context;

        public ApplicationaccessesController(VirtotaSolutionsContext context)
        {
            _context = context;
        }

        // GET: Applicationaccesses
        public async Task<IActionResult> Index()
        {
            var virtotaSolutionsContext = _context.Applicationaccess.Include(a => a.AddAccessNavigation).Include(a => a.BporoleGroupNavigation).Include(a => a.LrvroleGroupNavigation).Include(a => a.OtsaccessNavigation).Include(a => a.User).Include(a => a.VmsroleGroupNavigation);
            return View(await virtotaSolutionsContext.ToListAsync());
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
                .Include(a => a.User)
                .Include(a => a.VmsroleGroupNavigation)
                .FirstOrDefaultAsync(m => m.UserId == id);
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId");
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId");
            return View();
        }

        // POST: Applicationaccesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,VmsroleGroup,AddAccess,Otsaccess,BporoleGroup,LrvroleGroup,Mas500Access")] Applicationaccess applicationaccess)
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", applicationaccess.UserId);
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", applicationaccess.UserId);
            ViewData["VmsroleGroup"] = new SelectList(_context.VmsRolegroup, "VmsroleGroupId", "VmsroleGroupId", applicationaccess.VmsroleGroup);
            return View(applicationaccess);
        }

        // POST: Applicationaccesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,VmsroleGroup,AddAccess,Otsaccess,BporoleGroup,LrvroleGroup,Mas500Access")] Applicationaccess applicationaccess)
        {
            if (id != applicationaccess.UserId)
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
                    if (!ApplicationaccessExists(applicationaccess.UserId))
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", applicationaccess.UserId);
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
                .Include(a => a.User)
                .Include(a => a.VmsroleGroupNavigation)
                .FirstOrDefaultAsync(m => m.UserId == id);
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
            return _context.Applicationaccess.Any(e => e.UserId == id);
        }
    }
}
