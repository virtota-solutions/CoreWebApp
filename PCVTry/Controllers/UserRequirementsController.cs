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
    public class UserRequirementsController : Controller
    {
        private readonly MVCContext _context;

        public UserRequirementsController(MVCContext context)
        {
            _context = context;
        }

        // GET: UserRequirements
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRequirements.ToListAsync());
        }

        // GET: UserRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRequirements = await _context.UserRequirements
                .FirstOrDefaultAsync(m => m.UserReqId == id);
            if (userRequirements == null)
            {
                return NotFound();
            }

            return View(userRequirements);
        }

        // GET: UserRequirements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserReqId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRequirements);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(userRequirements);
        }

        // POST: UserRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserReqId,FloorNum,CubeNum,DidNum,DualMon,RemoAcc,RemoLap,Mobile,UserStatus,UserName")] UserRequirements userRequirements)
        {
            if (id != userRequirements.UserReqId)
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
                    if (!UserRequirementsExists(userRequirements.UserReqId))
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
                .FirstOrDefaultAsync(m => m.UserReqId == id);
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
            return _context.UserRequirements.Any(e => e.UserReqId == id);
        }
    }
}
