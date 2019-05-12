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
    public class UserRequirementsController : Controller
    {
        private readonly VirtotaSolutionsContext _context;

        public UserRequirementsController(VirtotaSolutionsContext context)
        {
            _context = context;
        }

        // GET: UserRequirements
        public async Task<IActionResult> Index()
        {
            var virtotaSolutionsContext = _context.UserRequirements.Include(u => u.User);
            return View(await virtotaSolutionsContext.ToListAsync());
        }

        // GET: UserRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRequirements = await _context.UserRequirements
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userRequirements == null)
            {
                return NotFound();
            }

            return View(userRequirements);
        }

        // GET: UserRequirements/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId");
            return View();
        }

        // POST: UserRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRequirements);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", userRequirements.UserId);
            return View(userRequirements);
        }

        // GET: UserRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRequirements = await _context.UserRequirements.FindAsync(id);
            if (userRequirements == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", userRequirements.UserId);
            return View(userRequirements);
        }

        // POST: UserRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (id != userRequirements.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRequirements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRequirementsExists(userRequirements.UserId))
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
            ViewData["UserId"] = new SelectList(_context.UserTable, "UserId", "UserId", userRequirements.UserId);
            return View(userRequirements);
        }

        // GET: UserRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRequirements = await _context.UserRequirements
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userRequirements == null)
            {
                return NotFound();
            }

            return View(userRequirements);
        }

        // POST: UserRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRequirements = await _context.UserRequirements.FindAsync(id);
            _context.UserRequirements.Remove(userRequirements);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRequirementsExists(int id)
        {
            return _context.UserRequirements.Any(e => e.UserId == id);
        }
    }
}
